using System;
using System.IO;
class Venta
{
    public int cantidadVendido { get; set; }
    public double precioUnitario { get; set; }
    public string nombre { get; set; }

    public Venta(string Nombre, int CantidadVendido, double PrecioUnitario) //Constructor
    {
        nombre = Nombre;
        cantidadVendido = CantidadVendido;
        precioUnitario = PrecioUnitario;
    }

    public static Venta Productos() //Metodo para ingresar los productos
    {
        Console.WriteLine("Ingrese el nombre del producto"); //Pedimos al usuario el nombre del producto
        string nombre = Console.ReadLine(); //Guardamos el nombre del producto en la variable nombre
    
        Console.WriteLine("Ingrese la cantidad vendida"); //Pedimos al usuario la cantidad vendida
        int cantidadVendido = int.Parse(Console.ReadLine()); //Guardamos la cantidad vendida en la variable cantidadVendido

        Console.WriteLine("Ingrese el precio unitario"); //Pedimos al usuario el precio unitario
        double precioUnitario = Convert.ToDouble(Console.ReadLine()); //Guardamos el precio unitario en la variable precioUnitario
        
        return new Venta(nombre, cantidadVendido, precioUnitario); //Retornamos el objeto Venta  
    }

    public static double CalcularTotal(string Ventas) //Metodo para calcular el total de ventas
    {
        double totalVentas = 0; //Variable para guardar el total de ventas

        if (File.Exists(Ventas)) //Si el archivo existe
        {
            string [] lineas = File.ReadAllLines(Ventas); //Guardamos las lineas del archivo en un arreglo

            foreach (string linea in lineas) //Recorremos las lineas del archivo
            {
                string [] datos = linea.Split(','); //Separamos los datos de la linea por comas
            
                double total = Convert.ToDouble(datos[3]); //Guardamos el total de la venta en la variable total
                totalVentas += total; //Sumamos el total al total de ventas
            }
        }
        return totalVentas; //Retornamos el total de ventas
    }

}
class Program
{
    static void Main()
    {
        string Ventas = "ventas.csv"; //Nombre del archivo donde se guardaran las ventas

        bool continuar = true; //Variable para saber si el usuario quiere seguir ingresando productos
        while (continuar) //Mientras continuar sea verdadero
        {
            Venta venta = Venta.Productos(); //Creamos un objeto Venta y guardamos el objeto que retorna el metodo Productos

            double total = venta.cantidadVendido * venta.precioUnitario; //Calculamos el total de la venta

            File.AppendAllText(Ventas, venta.nombre + "," + venta.cantidadVendido + "," + venta.precioUnitario + "," + total + "\n"); //Creamos un archivo y guardamos los datos de la venta
            
            Console.WriteLine("¿Quiere ingresar otro producto? si o no"); //Preguntamos al usuario si quiere ingresar otro producto
            string respuesta = Console.ReadLine().ToLower(); //Guardamos la respuesta en la variable respuesta
            continuar = respuesta == "si"; //Si la respuesta es si continuar sera verdadero si no sera falso
        }

        double totalVentas = Venta.CalcularTotal(Ventas); //Guardamos el total de ventas en la variable totalVentas

        Console.WriteLine("El total de ventandido en el dia es " + totalVentas); //Mostramos el total vendido en el dia
    }
}