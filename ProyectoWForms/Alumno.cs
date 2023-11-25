using System;

public class Alumnos
{
	
    public string? Nombre { get; set; }
    public string? Apellido1 { get; set; }
    public int Edad { get; set; }
    public float Altura { get; set; }
    public int Dni { get; set; }
    public char Letra { get; set; }
    public bool EsNuevo { get; set; }
    public byte[] Foto { get; set; }



    public Alumnos()
    {

    }

    public Alumnos(string nombre, string apellido1, int edad, float altura, int dni, char letra, bool esNuevo, byte[] foto)
    {
        this.Nombre = nombre;
        this.Apellido1 = apellido1;
        this.Edad = edad;
        this.Altura = altura;
        this.Dni = dni;
        this.Letra = letra;
        this.EsNuevo = esNuevo;
        this.Foto = foto;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Apellido1: {Apellido1}, Edad: {Edad}, Altura: {Altura}, DNI: {Dni}, Esnuevo: {EsNuevo}, Letra: {Letra}";
    }

}


