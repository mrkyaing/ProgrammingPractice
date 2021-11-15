using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class MyStack<T>
    {
        public T[] stackArray=new T[5];
        private int top=0;

        public void Push(T element)
        {
            if (IsFull()) { Console.WriteLine("Stack is full"); }
            else
            {
                stackArray[top++] = element;
            }
        }
        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                top--;
            }
        }
        public void Display()
        {
            if (!IsEmpty())
            {
                for(int i = stackArray.Length - 1; i >= 0; i--)
                {
                    if(null!=stackArray[i])
                    Console.WriteLine(stackArray[i].ToString());//user1,user2
                }
            }
        }
        private bool IsEmpty()
        {
            if (top == 0) return true;
            return false;
        }

        private bool IsFull()
        {
            if (top == 5) return true;
            return false;
        }
    }
}
