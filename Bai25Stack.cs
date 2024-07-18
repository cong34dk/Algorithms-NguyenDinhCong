using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Recursive
{
    public class Bai25Stack<T>
    {
        private T[] items;
        private int top;

        //Phuong thuc khoi tao stack voi size co dinh
        public Bai25Stack(int size)
        {
            this.items = new T[size];
            this.top = -1;
        }

        //Phuong thuc day phan tu vao stack
        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[++top] = item;
        }

        //Phuong thuc de lay phan tu dau ra khoi ngan xep
        public T Get()
        {
            if (top == -1)
            {

                throw new InvalidOperationException("Stack is empty");
            }

            return items[top--];
        }

        //Phuong thuc de kiem tra stack co rong ko
        public bool IsEmpty()
        {
            return top == -1;
        }

        //Phuong thuc de kiem tra stack co day ko
        public bool IsFull()
        {
            return top == items.Length - 1;
        }

    }
}
