using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Recursive
{
    public class Bai24Queue<T>
    {
        private T[] items;
        private int count;
        private int front;
        private int back;

        //Khoi tao hang doi voi kich thuoc co dinh
        public Bai24Queue(int size)
        {
            items = new T[size];
            count = 0;
            front = 0;
            back = -1;
        }

        //Phuong thuc de day mot phan tu vao hang doi
        public void Push(T item)
        {
            if(count == items.Length)
            {
                throw new InvalidOperationException("Queue is full");
            }

            back = (back + 1) % items.Length;
            items[back] = item;
            count++;
        }

        //Phuong thuc de lay phan tu dau tien ra khoi hang doi va tra ve no
        public T Get()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = items[front];
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        //Phuong thuc de kiem tra hang doi co rong khong
        public bool IsEmpty()
        {
            return count == 0;
        }

        //Phuong thuc kiem tra hang doi co day khong
        public bool IsFull()
        {
            return count == items.Length;   
        }
    }
}
