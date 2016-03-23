using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetB
{
    class Shapes
    {

        public List<List<string>> squareList = new List<List<string>>();
        public List<List<string>> triangleList = new List<List<string>>();
        

        public Shapes ()
        {
            
        }

        public void MakeSquareList()
        {
        Console.WriteLine("Enter size of list to be squared");
        int listSize = int.Parse(Console.ReadLine());
       

            for (int squareListIndex = 0; squareListIndex < listSize; squareListIndex++)
            {
                squareList.Add(new List<string>());
                for (int innerSquareIndex = 0; innerSquareIndex < listSize; innerSquareIndex++)
                {
                    squareList[squareListIndex].Add("*");

                }
            }
        }

        public void PrintSquareList()
        {
            foreach (List<string> innerSquare in squareList)
            {
                Console.WriteLine();
                foreach (string square in innerSquare)
                {
                    Console.Write(square);
                }
            }
        }

        public void MakeTriangleList()
        {
            Console.WriteLine("Enter size of triangle");
            int listSize = int.Parse(Console.ReadLine());
            


            for (int triangleListIndex = 0; triangleListIndex <= listSize; triangleListIndex ++)
            {
                triangleList.Add(new List<string>());
                
                for (int innerTriangleIndex = 0; innerTriangleIndex < triangleListIndex; innerTriangleIndex++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        public void MakeUpsideDownTriangle()
        {
            Console.WriteLine("Enter size of triangle");
            int listSize = int.Parse(Console.ReadLine());

            for (int triangleListIndex = listSize; triangleListIndex >= 1; triangleListIndex--)
            {
                for (int innerTriangleIndex = 0; innerTriangleIndex<triangleListIndex; innerTriangleIndex ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void MakeBackwardTriangle()
        {
            Console.WriteLine("Enter size of triangle");
            int listSize = int.Parse(Console.ReadLine());

            for (
                int triangleListIndex =listSize; triangleListIndex >=0; triangleListIndex--)
            {
                for (int innerTriangleIndex = 0; innerTriangleIndex < listSize; innerTriangleIndex++)
                {
                    if (triangleListIndex>innerTriangleIndex)
                    {
                        Console.Write(" ");
                    }
                        
                    else 
                    {
                        Console.Write("*");
                    }
                        
                }
                Console.WriteLine();
            }
        }

    }
}

