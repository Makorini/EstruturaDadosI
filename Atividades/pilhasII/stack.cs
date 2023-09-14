using System;

namespace StackClass
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top = -1;
        int[] stack = new int[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            stack[top] = data;
            return true;
        }

        public int pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            int valor = stack[top];
            top--;
            return valor;
        }

        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}");
        }

        public void printstack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine("Itens da pilha:");
            for (int i = top; i >= 0; i--)
            {
                string texto = $"stack[{i}] = {(char)(stack[i] + 'A')}";
                Console.WriteLine(texto);
            }
        }
    }
}
