using System;
using System.IO;
class Texto
{
    public string [] texto {get; set;}

    public Texto(string [] Texto1) //Constructor
    {
        texto = Texto1;
    }

    public void IngresaTexto() // Método para ingresar los nombres
    {
        Console.WriteLine("Ingrese el texto que desea contar las palabras que tiene"); //Pedimos al usuario que ingrese los nombres
        string palabras = Console.ReadLine(); //Guardamos los nombres en la variable nombres
        texto = palabras.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Separamos los nombres por espacio, eliminando los espacios en blanco y guardamos en el arreglo nombres
    }

    public void GuardarTextoEnArchivo() //Método para guardar los nombres en un archivo
    {
        string Guardar = "texto.txt"; //Nombre del archivo
        using (StreamWriter archivoTexto = new StreamWriter(Guardar)) //Creamos el archivo
        {
            archivoTexto.WriteLine(string.Join(" ", texto)); //Guardamos el texto en el archivo
        }
    }

    public int ContarPalabras() //Método para contar las palabras
    {
        return texto.Length; //Retornamos la cantidad de palabras
    }
}
class Program
{
    static void Main()
    {
        Texto texto = new Texto(new string[0]); //Creamos un objeto de la clase Texto
        texto.IngresaTexto(); //Llamamos al método para ingresar los nombres

        int cantidadPalabras = texto.ContarPalabras(); //Llamamos al método para contar las palabras
        Console.WriteLine("El texto tiene " + cantidadPalabras + " palabras"); //Mostramos la cantidad de palabras
        
        texto.GuardarTextoEnArchivo(); //Llamamos al método para guardar los nombres en un archivo
    }
}