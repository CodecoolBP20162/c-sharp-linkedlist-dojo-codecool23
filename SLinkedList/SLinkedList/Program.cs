using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLinkedList
{
    //Single Linked List
    public class SLinkList
    {
        private int data;
        private SLinkList next;

        public SLinkList()
        {
            data = 0;
            next = null;
        }

        public SLinkList(int value)
        {
            data = value;
            next = null;
        }
        public SLinkList InsertNext(int value)
        {
            SLinkList node = new SLinkList(value);
            if (this.next == null)
            {
                
                node.next = null; 
                this.next = node;
            }
            else
            {
                
                SLinkList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if (next == null)
                return 0;

            SLinkList node = this.next;
            this.next = this.next.next;  
            node = null;
            return 1;
        }
        public void Write(SLinkList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nMoving Froward Direction\n\n");

            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
        //Double Linked List

    }

    class Program
    {
        static void Main(string[] args)
        {
            SLinkList node1 = new SLinkList(1);
            SLinkList node2 = node1.InsertNext(2);
            SLinkList node3 = node2.InsertNext(3);
            SLinkList node4 = node3.InsertNext(4);
            SLinkList node5 = node4.InsertNext(5);

            node1.Write(null);
            node3.DeleteNext(); // delete the node "4"
            node2.Write(null);
            Console.ReadLine();
        }
    }
}
