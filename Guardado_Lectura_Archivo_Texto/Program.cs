using System;
using System.IO;
public class Nombre
{
    public string [] nombres {get; set;}

    public Nombre(string [] Nombres) //Constructor
    {
        nombres = Nombres;
    }

    public void IngresarNombres() //Método para ingresar los nombres
    {
        for (int i = 0; i < 5; i++) //Bucle que recorre el arreglo de nombres
        {
            nombres[i] = Console.ReadLine(); //Guardamos los nombres en el arreglo
        }
    }

    public void GuardarNombresEnArchivo(string Guardar) //Método para guardar los nombres en un archivo
    {
        using (StreamWriter texto = new StreamWriter(Guardar)) //Abrimos el archivo para escritura
        {
            foreach (string nombre in nombres) //Recorremos el arreglo de nombres
            {
                texto.WriteLine(nombre); //Escribimos cada nombre en una línea del archivo
            }
        }
        
        string mostrar = File.ReadAllText(Guardar); //Leemos el archivo
        Console.WriteLine($"Los nombres guardados en el archivo en el archivo son \n{mostrar}"); //Mostramos los nombres guardados en el archivo
    }
}

class Program
{
    static void Main()
    {
        string [] nombres = new string [5]; //Creamos un arreglo de 5 nombres

        Nombre nombre = new Nombre(nombres); //Creamos un objeto de la clase Nombre
        
        Console.WriteLine("Ingrese 5 nombres"); //Pedimos al usuario que ingrese los nombres
        nombre.IngresarNombres(); //Llamamos al método IngresarNombres
        
        string Guardar = "nombres.txt"; //Nombre del archivo donde se guardarán los nombres
        nombre.GuardarNombresEnArchivo(Guardar); //Llamamos al método para guardar los nombres en el archivo
    }
}