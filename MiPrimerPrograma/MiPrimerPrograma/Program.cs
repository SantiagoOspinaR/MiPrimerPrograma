/* Enunciado
* Ingresar por pantalla dos números y calcular las 4 operaciones aritméticas con dichos números.
* Imprimir en pantalla el resultado de cada operación*/

//Definir el nombre de mi programa con su respectivo método Main
public class MiPrimerPrograma
{
    static void Main(string[] args)
    {
        // Definir las variables
        int num1, num2, suma, resta, producto, cociente;

        //Pedir los datos por pantalla (Consola)
        Console.WriteLine("Ingrese su primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        Console.Write("La suma de sus dos numeros es:" + suma);
        Console.WriteLine("");
        Console.Write("La resta de sus dos numeros es:" + resta);
        Console.WriteLine("");
        Console.Write("El Producto de sus dos numeros es:" + producto);
        Console.WriteLine("");
        Console.Write("El cociente de sus dos numeros es:" + cociente);


    }






}