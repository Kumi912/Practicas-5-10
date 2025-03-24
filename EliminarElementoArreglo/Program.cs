using System;
class Numero
{
    public int [] numeros { get; set; }

    public Numero(int [] Numeros) //Constructor
    {
        numeros = Numeros;
    }

    public void EliminarNumero() //Método para sumar los números
    {
        Console.WriteLine("Ingrese el número que desea eliminar"); //Pedimos al usuario que ingrese el número a eliminar
        int numero = int.Parse(Console.ReadLine()); //Guardamos el número a eliminar en la variable numero

        int eliminar = 0; //Variable para contar cuántas veces se repite el número a eliminar
        for (int i = 0; i < 10; i++) //Bucle para recorrer el arreglo
        {
            if (numeros[i] == numero) //Condición para saber si el número a eliminar se encuentra en el arreglo
            {
                eliminar++; //Aumentamos el contador
            }
        }

        int [] nuevoArreglo = new int [10 - eliminar]; //Creamos un nuevo arreglo con la longitud del arreglo original menos las veces que se repite el número a eliminar
        int nuevo = 0; //Variable para recorrer el nuevo arreglo

        for (int i = 0; i < 10; i++) //Bucle para recorrer el arreglo
        {
            if (numeros[i] != numero) //Condición para saber si el número a eliminar no se encuentra en el arreglo
            {
                nuevoArreglo[nuevo] = numeros[i]; //Guardamos los números diferentes al número a eliminar en el nuevo arreglo
                nuevo++; //Aumentamos el contador
            }
        }

        numeros = nuevoArreglo; //Guardamos el nuevo arreglo en el arreglo original
    }

    public void MostrarNuevoArreglo() //Método para mostrar el nuevo arreglo
    {
        Console.WriteLine("La nueva lista de números es " + string.Join(", ", numeros)); //Mostramos el nuevo arreglo
    }
}

class Program
{
    static void Main()
    {
        int [] numeros = new int [10]; //Creamos un arreglo para guardar 10 números

        Console.WriteLine("Ingrese 10 números"); //Pedimos al usuario que ingrese los números

        for (int i = 0; i < 10; i++) //Bucle para ingresar los números
        {
            numeros[i] = int.Parse(Console.ReadLine()); //Guardamos los números en el arreglo
        }

        Numero numero = new Numero(numeros); //Creamos un objeto de la clase Numero
        
        numero.EliminarNumero(); //Llamamos al método EliminarNumero
        numero.MostrarNuevoArreglo(); //Llamamos al método MostrarNuevoArreglo
    }
}