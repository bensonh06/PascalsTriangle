using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 0;

            Console.Write("Input the number of rows you would like in the Pascal's Triangle: ");
            rows = int.Parse(Console.ReadLine());

            Console.Clear();

            List<int> previousList = new List<int>();

            for (int i = 0; i < rows; i++)
            {
                List<int> currentList = new List<int>();

                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        currentList.Add(1);
                        break;
                    default:
                        currentList.Add(1);

                        for (int j = 1; j < (previousList.Count - 1); j++)
                        {
                            currentList.Add(previousList[j] + previousList[j-1]);
                        }

                        break;
                }

                currentList.Add(1);

                for (int j = 0; j < currentList.Count; j++)
                {
                    Console.Write(currentList[j] + " ");
                }

                Console.Write('\n');

                previousList = currentList;
            }

            Console.ReadLine();
        }
    }
}
