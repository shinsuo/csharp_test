using System;

namespace test1
{
    public class Student
    {
        public int Age{get;set;}
        public string Name{get;set;} 
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = {0,1,2,4,113,55,3,66,557,124,2,1};

            int[] sizes = new int[3];
            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number%3;
                sizes[remainder]++;

                Console.Write(number+" ");
            }

            Console.WriteLine("");

            int[][] numbersByRemainder = new int[3][]{
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            foreach (var number in numbers)
            {
                int remainder = number%3;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }

            foreach (var item in numbersByRemainder)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Console.WriteLine("aaHello World!,{0},{1}",numbersByRemainder.Rank,numbersByRemainder.Length);


            int hashCode = numbers.GetHashCode();
            Console.WriteLine("hashcode:{0},{1}",hashCode,numbers.ToString());
            
            int bins = System.Array.BinarySearch(numbers,3,8,3);

            Console.WriteLine(bins);


            Student[] students = new Student[4];
            int i = 0;
            int j = 1;
            for (int index = 0; index < students.Length; index++)
            {
                Student item = new Student();
                item.Name = i.ToString()+"abc";
                item.Age = i*5*j;
                students[index] = item;

                i++;
                j = -j;
            }
            foreach (var item in students)
            {
                item.Name = (i*j).ToString()+"abc";
                item.Age = i*5*j;
                i++;
                j = -j;
            }

            foreach (var item in students)
            {
                Console.WriteLine("age:{0},name:{1}",item.Age,item.Name);
            }
            Array.Sort(students, (x,y)=>x.Age.CompareTo(y.Age));

            foreach (var item in students)
            {
                Console.WriteLine("age:{0},name:{1}",item.Age,item.Name);
            }

        }
    }
}
