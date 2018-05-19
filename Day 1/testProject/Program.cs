using System;

namespace testProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Alive);
            
            int status = 5;
            int[] statuses = new int[] {2,1,4,3};
            for (int counter=0; counter<statuses.Length;counter++)
            {
                status = statuses[counter];
                if (status == 1)
                { 
                    Console.WriteLine("Alive");
                }
                else if(status==2)
                {
                    Console.WriteLine("Zombie");
                }
                else if (status==3)
                {
                    Console.WriteLine("dead");
                }
                else
                {
                    Console.WriteLine("unknown");
                }
            }

            int myIntVariable;
            switch(4)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
