using WeiTuo;
using System.Collections;
using System.Formats.Asn1;

namespace WeiTuo
{
    class Student
    {
        public Student(int id, int score, double height)
        {
            Id = id;
            Score = score;
            Height = height;
        }
        public int Id { get; set; }
        public int Score { get; set; }
        public double Height { get; set; }

        public void show()
        {
            Console.WriteLine($"ID:[{Id,-2}],Score:{Score},Height:{Height}");
        }
    }
    internal class Program
    {
        delegate bool NeedSwap(Student a, Student b);
        //返回true代表交换a和b
        static void Myshort(Student[] arr, NeedSwap Compare)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (Compare(arr[j], arr[j + 1]))
                    {
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static bool IdAsc(Student a, Student b)
        {
            return a.Id > b.Id;
        }
        static bool IdDesc(Student a, Student b)
        {
            return a.Id < b.Id;
        }
        static bool ScoreAsc(Student a, Student b)
        {
            return a.Score > b.Score;
        }
        static bool ScoreDesc(Student a, Student b)
        {
            return a.Score < b.Score;
        }
        static bool HeithtAsc(Student a, Student b)
        {
            return a.Height > b.Height;
        }
        static bool HeithtDesc(Student a, Student b)
        {
            return a.Height < b.Height;

        }
        static void Main(string[] args)
        {
            Student[] stus = {
                new(1,97,1.57),
                new(9,55,1.87),
                new(17,82,1.69),
                new(2,83,1.73),
                new(8,87,1.75),
                new(5,77,1.68),
                new(19,76,1.88),
                new(54,62,1.70)
            };
            Myshort(stus, IdAsc);
            foreach (Student a in stus)
            {
                a.show();
            }
        }
    }
}




