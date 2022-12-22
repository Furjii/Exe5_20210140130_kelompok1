using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Node
    {
        public int FUR, JI, max;
        public string user;
        public Node next;
    }
    class Queues
    {
        int FUR, JI, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        { 
            FUR = -1;
            JI = -1;
        }
        public void insert(int element)
        {
            
            if ((FUR == 0 && JI == max - 1) || (FUR == JI + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
           
            if (FUR == -1)
            {
                FUR = 0;
                JI = 0;
            }
            else
            {
                
                if (JI == max - 1)
                    JI = 0;
                else
           
                    JI = JI + 1;
            }
           
            queue_array[JI] = element;
        }
        public void remove()
        {
            
            if (FUR == -1)
            {
                Console.WriteLine("Queue underflow\n");
                
            }
            Console.WriteLine("\nThe element deleted from the queue is: " +
                queue_array[FUR] + "\n");
           
            if (FUR == JI)
            {
                FUR = -1;
                JI = -1;
            }
            else
            {
                if (FUR == max - 1)
                    FUR = 0;
                else
                    
                    FUR = FUR + 1;

            }
        }
        
        public void Display()
        {
            int FRONT_position = FUR;
            int REAR_position = JI;
            /*Checks if the queue is empty. */
            if (FUR == -1)
            {
                Console.WriteLine("Queue tidak ada\n");
                return;
            }
            Console.WriteLine("\nElement in the queue are..................\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverse the queue till the last element present in an array.
                 */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* traverse the queue till the last position of the array. */
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                /* set the FRONT position to the first element array.*/
                FRONT_position = 0;
                /* traverse the array till the last element present in the
                 * queue. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
    
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Value");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a user : ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.Display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Pilihan Salah!!");
                            }
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the value entered. ");
                }
            }
        }
    }
}