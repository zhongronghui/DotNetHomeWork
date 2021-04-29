using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                Node<T> n = this.head;
                while(n != null)
                {
                    action(n.Data);
                    n = n.Next;
                }  
            }
            
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(random.Next(2,100));
            }
           

            int sum = 0;
            int max = intlist.Head.Data;
            int min = intlist.Head.Data;

            intlist.ForEach(n => Console.WriteLine(n));
            intlist.ForEach(m => { max = max > m ? max : m; });
            intlist.ForEach(m => { max = max < m ? max : m; });
            intlist.ForEach(m => sum = sum + m);
          
            Console.WriteLine($"总和:{sum}");
            Console.WriteLine($"最大值:{max}");
            Console.WriteLine($"最小值:{min}");

        }
    }
}
