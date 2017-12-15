using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hacer un algoritmo que calcule el total a pagar por la compra de CPU’S para ventas.

namespace ejercicio3
{
    class CPU
    {

        float precio;
        public void Ingresar()
        {
            Console.WriteLine("-----S&R COMPUTER CENTER-----");

            Console.WriteLine("INGRESE PRECIO DEL TOTAL DE TODOS CPU'S COMPRADOS");
            precio = float.Parse(Console.ReadLine());
        }
        public void Trabajo()
        {
            Console.WriteLine("-----S&R COMPUTER CENTER -----");
            if (precio >= 500000)
            {

                Console.WriteLine("la empresa tendrá la capacidad de invertir de su propio dinero un 55% del monto de la compra, pedir prestado al banco un 30% y el resto lo pagara solicitando un crédito al fabricante ");

            }
            else
            {

                Console.WriteLine("la empresa tendrá capacidad de invertir de su propio dinero un 70% y el restante 30% lo pagará solicitando crédito al fabricante.  ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            CPU sem = new CPU();

            sem.Ingresar();
            sem.Trabajo();

        }
    }
}
