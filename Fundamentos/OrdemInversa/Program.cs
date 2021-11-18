using System;
using System.Collections;
using System.Collections.Generic;

namespace OrdemInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o Array
            Console.WriteLine("Gerando array de números");            
            int[] numeros = { 16, 15, 3, 4, 8, 11, 23 };

            Console.WriteLine("Array");
            for (int i = 0; i < numeros.Length; i++)
            {                
                Console.WriteLine(numeros[i]);
            }

            //Criando
            Stack<int> pilha = new Stack<int>();
            for (int i = 0; i < numeros.Length; i++)
            {
                pilha.Push(numeros[i]);
            }

            Console.WriteLine("Pilha");
            foreach (var item in pilha)
            {                
                Console.WriteLine(item);
            }

            Queue<int> fila = new Queue<int>();
            for (int i = 0; i < pilha.Count; i++)
            {
                fila.Enqueue(pilha.Pop());
            }
            Console.WriteLine("Fila");
            for (int i = 0; i < fila.Count; i++)
            {                
                Console.WriteLine(fila.Dequeue());
            }
        }
    }
}
