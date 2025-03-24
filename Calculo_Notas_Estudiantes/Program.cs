using System;
using System.IO;
class Alumno
{
    public int [] calificacion { get; set; }
    public string nombres {get; set;}

    public Alumno(int [] Calificacion, string Nombres) //Constructor
    {
        calificacion = Calificacion;
        nombres = Nombres;
    }

    public int SumaCalificaciones() //Método para sumar los números
    {
        int suma = 0; //Variable para guardar la suma de los números

        for (int i = 0; i < calificacion.Length; i++) //Bucle para recorrer el arreglo
        {
            suma += calificacion[i]; //Sumamos los números
        }

        return suma; //Retornamos la suma
    }

    public double PromedioAlumno() //Método para calcular el promedio de los números
    {
        return (double) SumaCalificaciones() / 3; //Retornamos el promedio llamndo al metodo SumaTotal y dividiendo entre 10
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de alumnos"); //Pedimos al usuario que ingrese la cantidad de alumnos
        int AlumnosCantidad = int.Parse(Console.ReadLine()); //Guardamos la cantidad de alumnos en la variable AlumnosCantidad

        Alumno [] alumnos = new Alumno[AlumnosCantidad]; //Creamos un arreglo para el nombre de los alumnos
        
        for (int i = 0; i < AlumnosCantidad; i++)
        {
            Console.WriteLine("Ingrese el nombre del alumno");
            string nombre = Console.ReadLine();

            int [] calificacion = new int [3]; //Creamos un arreglo para guardar 3 calificaciones de cada alumno
            Console.WriteLine("Ingrese las calificaciones del alumno " + nombre); //Pedimos al usuario que ingrese los números
        
            for (int Calificaciones = 0; Calificaciones < 3; Calificaciones++) //Bucle para ingresar las calificaciones
            {
                calificacion[Calificaciones] = int.Parse(Console.ReadLine()); //Guardamos los números en el arreglo
            }

            alumnos[i] = new Alumno(calificacion, nombre); //Creamos un objeto de la clase Numero
        }

        string Guardar = "notas.txt"; //Nombre del archivo donde se guardarán los datos
        using (StreamWriter Calificaciones = new StreamWriter(Guardar)) //Creamos un archivo de texto
        {
            foreach (Alumno alumno in alumnos) //Bucle para recorrer el arreglo de objetos
            {
                Calificaciones.WriteLine(alumno.nombres); //Escribimos en el archivo el nombre del alumno
                Calificaciones.WriteLine("Las calificaciones del alumno son " + string.Join(", ", alumno.calificacion)); //Escribimos en el archivo las calificaciones del alumno
                Calificaciones.WriteLine("El promedio del alumno es " + alumno.PromedioAlumno()); //Escribimos en el archivo el promedio del alumno
            }
        }

        foreach (Alumno alumno in alumnos) //Bucle para recorrer el arreglo de objetos
        {
            Console.WriteLine(alumno.nombres); //Mostramos el nombre del alumno
            Console.WriteLine("Las calificaciones del alumno son " + string.Join(", ", alumno.calificacion)); //Mostramos las calificaciones del alumno
            Console.WriteLine("El promedio del alumno es " + alumno.PromedioAlumno()); //Mostramos el promedio del alumno
        }
    }
}