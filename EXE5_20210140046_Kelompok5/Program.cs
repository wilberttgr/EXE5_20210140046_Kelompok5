using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140046_Kelompok5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node wilbert, tegar;
        public queue()
        {
            wilbert = null;
            tegar = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (wilbert == null)
            {
                wilbert = newnode;
                tegar = newnode;
                return;
            }
            tegar.next = newnode;
            tegar = newnode;
        }
        public void delete()
        {
            if (wilbert == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            wilbert = wilbert.next;
            if (wilbert == null)
                tegar = null;
        }
        public void display()
        {
            if (wilbert == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = wilbert; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                    }
                }
        }
    }
}
