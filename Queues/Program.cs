using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Queue<T>
    {
        private int front;
        private int rear;
        private int length;
        private T[] myqueue;
        public Queue()
        {
            myqueue = new T[10];
            length = 0;
            front = 0;
            rear = -1;
        }
        public void Equeue(T item)
        {
            if (myqueue.Length == length) throw new Exception("queue is full");
            else
            {
                rear++;
                if (rear == myqueue.Length) rear = 0;
                myqueue[rear] = item;
                length++;
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            
        }
    }
}
