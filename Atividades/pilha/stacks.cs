using System;

namespace StackClass
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top = -1;
        int[] stack = new int [MAX];//ver se a pilha esta cheia ou nao

        public bool IsEmpty()// boleano  verdadeiro ou falso
                {
            return (top < 0);// quero que me retorne um boleano = ISEmpty
        }

        public bool push(int data)// empurrar a onde eu vol guardar pilha
        {
            if(top >= MAX)
            {
                Console.WriteLine("stack Qverflow");
                return false;
            }
            top += 1;// -1+1=0
            stack[top] = data;
            return true;
        }

        public int pop()// devolver aquilo que tirou
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Overflow");
                return 0;
            }

            int valor = stack[top];
            top --;
            return valor;
        }

        public void peek()// vasio
        {
            if(top < 0)
            {
                Console.WriteLine(" Stack Underflow");
                return;
            }

            Console.WriteLine($" o topo da pilha é: {stack[top]}");//string que tipo de dado eu estou pasando para o metado writeline
        }

        public void printstack()
        {
            if(top > 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine("Itens da pilha:");
                for(int i = top; i > 0; i-- ) //i comessa no topo top
                {
                    string texto = $"stack[{ stack[i]}]";
                    Console.WriteLine (texto);
                }

        }
    }
}