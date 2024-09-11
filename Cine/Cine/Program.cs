using System;
using System.Collections.Generic;

public enum Formato
{
    _2D_Doblada,
    _2D_Subtitulada,
    _3D_Doblada,
    _3D_Subtitulada,
    IMAX_Doblada,
    IMAX_Subtitulada
}

public enum TipoAsiento
{
    Estandar,
    Superseat
}

public class Pelicula
{
    public string NombrePelicula{ get; private set;}
    public string GeneroPelicula{ get; private set;}
    public int DuracionMin{ get; private set;}
    public Formato Formato{ get; private set;}
    public Pelicula(string nombrePelicula, string generoPelicula, int duracionMin, Formato formato)
    {
        NombrePelicula = nombrePelicula;
        GeneroPelicula = generoPelicula;
        DuracionMin = duracionMin;
        Formato = formato;
    }
}

public class Asiento
{
    public char Letra{ get; private set;}
    public int Numero{ get; private set;}
    public TipoAsiento Tipo{ get; private set;}
    public bool Ocupado{ get; private set;}
    public Asiento(char letra, int numero, TipoAsiento tipo)
    {
        Letra = letra;
        Numero = numero;
        Tipo = tipo;
        Ocupado = false;
    }
    public void CambiarOcupado() => Ocupado = !Ocupado;
    
}

public class Sala
{
    public List<Asiento> Asientos{ get; private set;} = new List<Asiento>();
    public int NumeroSala
    {
        get { return _numeroSala; }
        private set
        {
            if (value > 0)
            {
                _numeroSala = value;
            }
            else
            {
                throw new Exception("El número de sala debe ser igual o mayor a 1");
            }
        }
    }
// al poner signo de pregunta indicamos q el dato puede estar como no, pueden ser nulos
    public Pelicula? Pelicula { get; private set;}

    public DateTime Horario { get; private set;}

    public Sala(int numeroSala)
    {
        NumeroSala = numeroSala;
    }

    public void AgregarAsiento(Asiento asiento)
    {
        Asientos.Add(asiento);
    }
    public void AgregarAsiento(List<Asiento> asientos)
    {
        Asientos.AddRange(asientos);
    }

    public void DefinirHorario(DateTime hora) => Horario = hora;

    public void ReproducirPelicula()
    {
        if (_pelicula != null)
        {
            Console.WriteLine($"Reproduciendo {_pelicula.NombrePelicula}...");
        }
        else
        {
            Console.WriteLine("No se ha definido una película para esta sala.");
        }
    }
}

public class Cinema
{
    public string NombreCine { get; private set; }
    public List<Sala> Salas { get; private set; } = new List <Sala>();

    public Cinema(string nombreCine)
    {
        NombreCine = nombreCine;
        Salas = new List<Sala>();
    }

    public void AgregarSala(Sala sala)
    {
        Salas.Add(sala);
    }
}

public class Entrada
{

    public Cinema Cine { get; private set;}
    public Pelicula PeliculaE { get; private set;}

    // se hace a traves de cine.Salas 
    public Sala Sala { get; private set;}

    public Asiento AsientoE { get; private set;}

    public Formato FormatoE{ get; private set;}

    public double Precio
    {
        get
        {
            if (PeliculaE == null || AsientoE == null)
            {
                throw new InvalidOperationException("Película o asiento no están definidos.");
            }

            double basePrecio;

            
            switch (PeliculaE.Formato)
            {
                case Formato._2D_Subtitulada:
                    basePrecio = 50;
                    break;
                case Formato._2D_Doblada:
                    basePrecio = 80;
                    break;
                case Formato._3D_Subtitulada:
                    basePrecio = 100;
                    break;
                case Formato._3D_Doblada:
                    basePrecio = 150;
                    break;
                case Formato.IMAX_Subtitulada:
                    basePrecio = 200;
                    break;
                case Formato.IMAX_Doblada:
                    basePrecio = 280;
                    break;
                default:
                    throw new Exception("El formato de película es desconocido");
            }

            // Ajustar el precio según el tipo de asiento
            switch (AsientoE.Tipo)
            {
                case TipoAsiento.Superseat:
                    return basePrecio + 100;
                case TipoAsiento.Estandar:
                    return basePrecio + 50;
                default:
                    throw new Exception("Tipo de asiento desconocido");
            }
        }
    }

    public Entrada(Pelicula pelicula, Sala sala, Asiento asientoE)
    {
        Pelicula = pelicula;
        Sala = sala;
        AsientoE = asientoE;
        FormatoE = pelicula.Formato;
    }
}
public class Boleteria
{
    public List<Entrada> EntradasVendidas { get; private set; }

    public Boleteria()
    {
        EntradasVendidas = new List<Entrada>();
    }

    public Entrada VenderEntrada(Sala sala, Asiento asiento, Pelicula pelicula)
    {
        if (asiento.Ocupado)
        {
            throw new InvalidOperationException("El asiento ya está ocupado.");
        }
        else
        {
            Console.WriteLine($"Tu asiento es el {asiento.Letra}{asiento.Numero} en la sala {sala.NumeroSala}");
            asiento.Ocupado = true;
        }

        var entrada = new Entrada(pelicula, sala, asiento);

        EntradasVendidas.Add(entrada);

        return entrada;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cinema cine = new Cinema("Showcase");
        Pelicula gaturro = new Pelicula("Gaturro", "Infantil", 120, Formato._3D_Doblada) ;
        Pelicula avengers = new Pelicula("Los Vengadores", "Fantasia", 180, Formato._2D_Subtitulada);
        Asiento asiento1 = new Asiento('A', 1, TipoAsiento.Estandar, false);
        Asiento asiento2 = new Asiento('B', 1, TipoAsiento.Estandar, true);
        Asiento asiento3 = new Asiento('C', 1, TipoAsiento.Superseat, false); 
        Sala sala1 = new Sala(1, gaturro);
        cine.AgregarSala(sala1);
        Sala sala2 = new Sala(2, avengers);
        cine.AgregarSala(sala1);
        sala1.AgregarAsiento(asiento1);
        sala1.AgregarAsiento(asiento2);
        sala1.AgregarAsiento(asiento3); 
        sala2.AgregarAsiento(asiento1);
        sala2.AgregarAsiento(asiento2);
        sala2.AgregarAsiento(asiento3);
        Console.WriteLine($"Que pelicula desea ver?: " +
            $"1. {gaturro.NombrePelicula}" +
            $"2. {avengers.NombrePelicula}");
        int peli = int.Parse(Console.ReadLine());
        
        Console.WriteLine("En que horario?: ");
        DateTime horario = DateTime.Parse(Console.ReadLine());
        Boleteria boleteria = new Boleteria();
        if(peli == 1) {
            
            boleteria.VenderEntrada(sala1, asiento1, gaturro);
        }
        if (peli == 2)
        {

            boleteria.VenderEntrada(sala2, asiento2, avengers);
        }




    }     
}
