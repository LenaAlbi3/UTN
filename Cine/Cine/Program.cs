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
    private string _nombrePelicula;
    private string _generoPelicula;
    private int _duracionMin;
    private Formato _formato;

    public string NombrePelicula
    {
        get { return _nombrePelicula; }
        private set { _nombrePelicula = value; }
    }

    public string GeneroPelicula
    {
        get { return _generoPelicula; }
        private set { _generoPelicula = value; }
    }

    public int DuracionMin
    {
        get { return _duracionMin; }
        private set { _duracionMin = value; }
    }

    public Formato Formato
    {
        get { return _formato; }
        private set { _formato = value; }
    }

    public Pelicula(string nombrePelicula, string generoPelicula, int duracionMin, Formato formato)
    {
        _nombrePelicula = nombrePelicula;
        _generoPelicula = generoPelicula;
        _duracionMin = duracionMin;
        _formato = formato;
    }
}

public class Asiento
{
    private char _letra;
    private int _numero;
    private TipoAsiento _tipo;
    private bool _ocupado;

    public char Letra
    {
        get { return _letra; }
        private set { _letra = value; }
    }

    public int Numero
    {
        get { return _numero; }
        private set { _numero = value; }
    }

    public TipoAsiento Tipo
    {
        get { return _tipo; }
        private set { _tipo = value; }
    }

    public bool Ocupado
    {
        get { return _ocupado; }
        set { _ocupado = value; }
    }

    public Asiento(char letra, int numero, TipoAsiento tipo, bool ocupado)
    {
        _letra = letra;
        _numero = numero;
        _tipo = tipo;
        _ocupado = ocupado;
    }
}

public class Sala
{
    private int _numeroSala;
    private List<Asiento> _asientos;
    private Pelicula _pelicula;
    private DateTime _horario;

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

    public Pelicula Pelicula
    {
        get { return _pelicula; }
        private set { _pelicula = value; }
    }

    public DateTime Horario
    {
        get { return _horario; }
        private set { _horario = value; }
    }

    public Sala(int numeroSala, Pelicula pelicula)
    {
        _numeroSala = numeroSala;
        _asientos = new List<Asiento>();
        _pelicula = pelicula; // Asignación del valor de _pelicula
    }

    public void AgregarAsiento(Asiento asiento)
    {
        _asientos.Add(asiento);
    }

    public void DefinirHorario(DateTime hora)
    {
        _horario = hora;
    }

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
    private string _nombreCine;
    private List<Sala> _salas;

    public string NombreCine
    {
        get { return _nombreCine; }
        private set { _nombreCine = value; }
    }

    public Cinema(string nombreCine)
    {
        _nombreCine = nombreCine;
        _salas = new List<Sala>();
    }

    public void AgregarSala(Sala sala)
    {
        _salas.Add(sala);
    }
}

public class Entrada
{
    private Pelicula _pelicula;
    private Sala _sala;
    private Asiento _asientoE;
    private Formato _formatoE;

    // no entendi como poner el cine sin crearlo en el constructor pq no va a haber mas de un cine
    public Cinema Cine
    {
        get { return Cine; }
        private set { Cine = value; }
    }

    public Pelicula Pelicula
    {
        get { return _pelicula; }
        private set { _pelicula = value; }
    }

    public Sala Sala
    {
        get { return _sala; }
        private set { _sala = value; }
    }

    public Asiento AsientoE
    {
        get { return _asientoE; }
        private set { _asientoE = value; }
    }

    public Formato FormatoE
    {
        get { return _formatoE; }
        private set { _formatoE = value; }
    }

    public double Precio
    {
        get
        {
            if (_pelicula == null || _asientoE == null)
            {
                throw new InvalidOperationException("Película o asiento no están definidos.");
            }

            double basePrecio;

            
            switch (_pelicula.Formato)
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
            switch (_asientoE.Tipo)
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
        _pelicula = pelicula;
        _sala = sala;
        _asientoE = asientoE;
        _formatoE = pelicula.Formato; // Establecer formato basado en la película
    }
}
public class Boleteria
{
    public List<Entrada> EntradasVendidas { get; private set; }

    public Boleteria()
    {
        EntradasVendidas = new List<Entrada>();
    }

    public Entrada VenderEntrada(Sala sala, Asiento asiento, DateTime fecha)
    {
        if (asiento.Ocupado)
        {
            throw new InvalidOperationException("El asiento ya está ocupado.");
        }
        else
        {
            Console.WriteLine($"Tu asiento es el {asiento.Letra}{asiento.Numero}");
            asiento.Ocupado = true;
        }
        

        // Crear una nueva entrada
        var entrada = new Entrada(sala, asiento, fecha);

        // Añadir la entrada a la lista de entradas vendidas
        EntradasVendidas.Add(entrada);

        return entrada;
    }
}