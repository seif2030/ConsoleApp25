using System;

namespace ConsoleApp22
{
    class Program
    {
        class node
        {
            public int data;
            public node next;                                                                     //MAVRICK
        }
        class singeleLinkedlist
        {
            node head;

            public void printlist()
            {

                node node = head;
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
                Console.WriteLine();
            }
            public void createlist(int num, int min, int max)
            {
                Random ramdom = new Random();
                int val;
                for (int i = 0; i < num; i++)
                {
                    val = ramdom.Next(min, max);
                    insertatend(val);

                }
            }
            public int count()
            {
                int count = 0;
                node p = head;
                while (p != null)
                {
                    count++;
                    p = p.next;
                }
                return count;
            }
            public void search(int data)
            {
                node p = head;
                int pos = 1;
                while (p != null)
                {
                    if (p.data == data)
                    {
                        Console.WriteLine("Item{0} found at position {1} ", data, pos);
                        return;
                    }

                    pos++;
                    p = p.next;
                    Console.WriteLine("Item {0} not found ", data);
                }
            }
            public void insertatfront(int data)
            {
                node temp = new node();
                temp.data = data;
                temp.next = head;
                head = temp;

            }
            public void insertatend(int data)
            {
                node temp = new node();
                temp.data = data;
                if (head == null)
                {
                    head = temp;
                    return;
                }
                node p = head;
                while (p.next != null)
                    p = p.next;
                p.next = temp;
                temp.next = null;

            }
            public void insertafter(int data, int item)
            {
                node temp = new node();
                temp.data = data;
                node p = head;
                while (p != null)
                {
                    if (p.data == item)
                    {
                        temp.next = p.next;
                        p.next = temp;
                        return;
                    }
                    p = p.next;
                }
                Console.WriteLine("{0} Not Found in the list", item);
            }
            public void insertBefore(int data, int item)
            {
                node temp = new node();
                temp.data = data;
                if (head == null)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }
                node p = head;
                while (p != null)
                {
                    if (p.next.data == item)
                    {
                        temp.next = p.next;
                        p.next = temp;
                        return;
                    }
                }
                Console.WriteLine("{0} Not Found in the list", item);
            }
            public void insertAtPosition(int data, int pos)
            {
                node temp = new node();
                temp.data = data;
                if (pos == 1)
                {
                    temp.next = head;
                    head = temp;
                }
                node p = head;
                for (int i = 1; i < pos - 1 && p != null; i++)
                    p = p.next;
                if (p == null)
                    Console.WriteLine("There less than {0} elments", pos);
                else
                {
                    temp.next = p.next;
                    p.next = temp;

                }


            }
            public void DeleteNode(int data)
            {
                if (head == null)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }
                if (head.data == data)
                {
                    head = head.next;
                    return;
                }
                node p = head;
                while (p.next != null)
                {
                    if (p.next.data == data)
                    {
                        p.next = p.next.next;
                        return;
                    }
                    p = p.next;
                }
                Console.WriteLine("Element {0} not found", data);
            }
            public void Reverselist()
            {
                node prev, ptr, next;
                prev = null;
                ptr = head;
                while (ptr != null)
                {
                    next = ptr.next;
                    ptr.next = prev;
                    prev = ptr;
                    ptr = next;
                }
                head = prev;
            }
        }
        static void Main(string[] args)
        {
            singeleLinkedlist list = new singeleLinkedlist();
            while (true)
            {
                Console.WriteLine("1.Create list ");
                Console.WriteLine("2.print list");
                Console.WriteLine("3.count");
                Console.WriteLine("4.Search");
                Console.WriteLine("5.Add to empty list / Add At The beginning");
                Console.WriteLine("6.Add at end");
                Console.WriteLine("7.Add after ndoe ");
                Console.WriteLine("8.Add before node ");
                Console.WriteLine("9.Add At postion");
                Console.WriteLine("10.Delete");
                Console.WriteLine("11.Reverse");
                Console.WriteLine("12.Quit");
                Console.WriteLine("Enter your choise");
                int choise = int.Parse(Console.ReadLine());
                int data = 0;
                int item;
                int pos;
                switch (choise)
                {
                    case 1:
                        list.createlist(5, 1, 100);
                        break;

                    case 2:
                        list.printlist();
                        break;

                    case 3:
                        Console.WriteLine(list.count());
                        break;

                    case 4:
                        Console.WriteLine("Enter The elemnt to be searched :");
                        data = int.Parse(Console.ReadLine());
                        list.search(data);
                        break;

                    case 5:
                        Console.WriteLine("Enter the element to be inserted at front :");
                        data = int.Parse(Console.ReadLine());
                        list.insertatfront(data);
                        break;

                    case 6:
                        Console.WriteLine("Enter the elment to be inserted at end :");
                        data = int.Parse(Console.ReadLine());
                        list.insertatend(data);
                        break;

                    case 7:
                        Console.WriteLine("Enter the element to be inserted :");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the element after which will be inserted: ");
                        item = int.Parse(Console.ReadLine());
                        list.insertafter(data, item);
                        break;

                    case 8:
                        Console.WriteLine("Enter the element to be inserted :");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the element before which will be inserted: ");
                        item = int.Parse(Console.ReadLine());
                        list.insertBefore(data, item);
                        break;

                    case 9:
                        Console.WriteLine("Enter the element to be inserted :");
                        data = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the postion");
                        pos = int.Parse(Console.ReadLine());
                        list.insertAtPosition(data, pos);
                        break;

                    case 10:
                        Console.WriteLine("Enter the elment to be Deleted :");
                        data = int.Parse(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    case 11:
                        list.Reverselist();
                        break;

                    case 12:
                        return;







                }
            }
        }
    }
}
;
