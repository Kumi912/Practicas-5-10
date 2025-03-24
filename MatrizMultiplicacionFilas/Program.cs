using System;
class Matriz1
{
    public int [,] matriz { get; set; }

    public Matriz1(int [,] Matriz) // Constructor
    {
        matriz = Matriz;
    }

    public void MultiplicaNumeroPorMatriz(int numero) //Método para multiplicar la matriz por un número
    {
        for (int fila = 0; fila < 3; fila++) //Recorremos la matriz
        {
            for (int columna = 0; columna < 3; columna++) //Recorremos la matriz
            {
                matriz[fila, columna] = matriz[fila, columna] * numero; //Multiplicamos la matriz por el número
            }
        }
    }

    public void NuevaMatriz() //Método para mostrar la nueva matriz
    {
        for (int fila = 0; fila < 3; fila++) //Recorremos la matriz para mostrarla en pantalla
        {
            for (int columna = 0; columna < 3; columna++) //Recorremos la matriz para mostrarla en pantalla
            {
                Console.Write(matriz[fila, columna] + " "); //Mostramos la matriz
            }
            Console.WriteLine(); //Saltamos una línea
        }
    }
}
class Program
{
    static void Main()
    {
        int [,] matriz = new int [3,3]; //Declaramos la matriz

        for (int fila = 0; fila < 3; fila++) //Recorremos la matriz para llenarla con los números ingresados por el usuario
        {
            for (int columna = 0; columna < 3; columna++) //Recorremos la matriz para llenarla con los números ingresados por el usuario
            {
                Console.WriteLine("Ingrese el número de la posición " + fila + "," + columna); //Pedimos al usuario que ingrese los números
                matriz[fila, columna] = int.Parse(Console.ReadLine()); //Guardamos los números en la matriz en la posición correspondiente
            }
        }

        Console.WriteLine("Ingrese el número a multiplicar"); //Pedimos al usuario que ingrese el número a multiplicar
        int numero = int.Parse(Console.ReadLine()); //Guardamos el número ingresado por el usuario en la variable numero

        Matriz1 matriz2 = new Matriz1(matriz); //Creamos un objeto de la clase Matriz1
        matriz2.MultiplicaNumeroPorMatriz(numero); //Llamamos al método MultiplicaNumeroPorMatriz

        Console.WriteLine("El resultado de la matriz multiplicación por el número es"); 
        matriz2.NuevaMatriz(); //Llamamos al método NuevaMatriz
    }
}