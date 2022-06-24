using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractise
{
    internal class Program
    {
        class StackItem
        {
            public int value { get; set; }

            public StackItem next { get; set; }
        }
        class MyStack
        {
            public StackItem Item { get; set; }

            public MyStack()
            {
                Item = null;//Stack is empty
            }

            public void DisplayStack()
            {
                if (Item==null)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    Console.WriteLine("{0} (Top of the stack)", Item.value);

                    StackItem stackIterator = Item.next;

                    while (stackIterator!=null)
                    {
                        if (stackIterator.next==null)//Bottom of the stack!
                            Console.WriteLine("{0} (Bottom of the stack)", stackIterator.value);
                        else
                            Console.WriteLine(stackIterator.value.ToString());

                        stackIterator = stackIterator.next;
                    }//End of while
                }//End of else


                Console.WriteLine();
                Console.WriteLine();

                Console.ReadKey();

            }//Display stack
            
            public void Push(int value)
            {
                StackItem item = new StackItem { value = value, next = null };

                if (Item==null)
                    Item = item;
                else
                {
                    item.next = Item;
                    Item = item;
                }                

            }

            public void Pop()
            {
                StackItem temp = Item.next;
                Item = temp;
            }
        }

        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            stack.DisplayStack();
            
            stack.Push(1);
            stack.DisplayStack();

            stack.Push(5);           

            stack.Push(9);            

            stack.Push(10);            

            stack.Push(7);
            stack.DisplayStack();

            stack.Push(23);
            stack.DisplayStack();

            stack.Push(72);
            stack.DisplayStack();

            stack.Push(82);
            stack.DisplayStack();

            stack.Push(88);
            stack.DisplayStack();

            stack.Push(100);
            stack.DisplayStack();

            stack.Pop();
            stack.DisplayStack();

            stack.Pop();
            stack.Pop();
            stack.DisplayStack();

        }
    }
}
