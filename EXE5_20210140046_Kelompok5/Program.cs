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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
