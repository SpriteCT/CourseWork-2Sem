using CourseWorkLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace TestProgramm
{
    enum SubjectsNumbers
    {
        Russian = 0,
        Mathematics = 1,
        Informatics = 2,
        Physics = 3,
        Chemical = 4,
        Geography = 5,
        Social = 6,
        History = 7,
        English = 8,
        Biology = 9
    }
    internal class Program
    {

        public static void PrintAllShit(List<Direction> directions)
        {
            foreach (Direction dir in directions)
            {
                Console.WriteLine(dir.Name);
                foreach (Student student in dir.Students)
                {
                    Console.WriteLine($"{student.Name}  {student.Score}  {student.Entered}");
                }
            }
            Console.WriteLine();
        }
        public static void DoSomeShit()
        {
            University university1 = new University("МГУ", new int[] { 10, 10, 10 });
            List<Direction> directions = new List<Direction>();
            List<int> Mathematical = new List<int>();
            Mathematical.Add(1);
            List<int> Russian = new List<int>();
            Russian.Add(0);
            List<int> Physics = new List<int>();
            Physics.AddRange(new int[] { 2, 3 });
            List<List<int>> shit = new List<List<int>>() { Mathematical, Russian, Physics };
            Direction Math = new Direction(1, "Математика", 1, 50, shit);
            Direction Phis = new Direction(2, "Физика", 1, 50, shit);
            Direction Ra = new Direction(3, "Физра", 2, 50, shit);
            Direction Xyeta = new Direction(4, "Другая хуйня", 3, 50, shit);

            directions.AddRange(new Direction[] { Math, Phis, Ra, Xyeta });

            Student a = new Student("a", new int[10] { 50, 40, 60, 0, 0, 0, 0, 0, 0, 0 });
            Student b = new Student("b", new int[10] { 50, 50, 50, 0, 0, 0, 0, 0, 0, 0 });
            Student c = new Student("c", new int[10] { 50, 50, 50, 0, 0, 0, 0, 0, 0, 0 });
            Student d = new Student("d", new int[10] { 50, 60, 40, 0, 0, 0, 0, 0, 0, 0 });
            Student e = new Student("e", new int[10] { 30, 60, 50, 0, 0, 0, 0, 0, 0, 0 });
            Student f = new Student("f", new int[10] { 30, 30, 30, 0, 0, 0, 0, 0, 0, 0 });
            Student g = new Student("g", new int[10] { 30, 40, 50, 0, 0, 0, 0, 0, 0, 0 });
            Student s = new Student("s", new int[10] { 40, 50, 60, 0, 0, 0, 0, 0, 0, 0 });

            List<Student> students = new List<Student>();
            students.AddRange(new Student[] { a, b, c, d, e, f, g, s });

            a.Directions.AddRange(new Direction[] { Math, Phis, Ra, Xyeta });
            b.Directions.AddRange(new Direction[] { Phis, Ra, Xyeta, Math });
            c.Directions.AddRange(new Direction[] { Math, Phis, Ra, Xyeta });
            d.Directions.AddRange(new Direction[] { Phis, Math, Ra, Xyeta });
            e.Directions.AddRange(new Direction[] { Ra, Phis, Phis, Xyeta });
            f.Directions.AddRange(new Direction[] { Xyeta, Phis, Ra, Xyeta });
            g.Directions.AddRange(new Direction[] { Ra, Phis, Math, Xyeta });
            s.Directions.AddRange(new Direction[] { Math, Ra, Phis, Xyeta });

            foreach (Student student in students)
            {
                student.Directions[0].Students.Add(student);
                student.CurrentDirection = 0;
                student.Entered = true;
            }

            bool fl = true;
            foreach (Direction dir in directions)
            {
                dir.RejectNonApplicants();
            }
            PrintAllShit(directions);

            while (fl)
            {
                foreach (Student student in students)
                {
                    if (student.CurrentDirection >= student.Directions.Count - 1 || student.Entered == true)
                    {
                        fl = false;
                    }
                    else
                    {
                        fl = true;
                        break;
                    }
                }
                if (fl)
                {
                    foreach (Direction dir in directions)
                    {
                        dir.RejectNonApplicants();
                        dir.TransferStudentsToNextDirection();
                    }
                }
                PrintAllShit(directions);
            }
            Console.ReadKey();
        }
        public static void DoSomeExcelShit()
        {
            List<Direction> directions = new List<Direction>();
            List<University> universities = new List<University>();
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "Directions")))
                    {
                        for (int i = 2; i < 30; i++)
                        {
                            string name;
                            string university;
                            int id, minimalScore, numberOfPlaces;
                            List<int> firstSubjects = new List<int>();
                            List<int> secondSubjects = new List<int>();
                            List<int> thirdSubjects = new List<int>();

                            id = int.Parse(helper.Read(i, 1));
                            university = helper.Read(i, 2);
                            name = helper.Read(i, 3);
                            numberOfPlaces = int.Parse(helper.Read(i, 4));
                            minimalScore = int.Parse(helper.Read(i, 5));

                            for (int j = 6; j <= 15; j++)
                            {
                                if (helper.Read(i, j) == "1")
                                {
                                    firstSubjects.Add(j - 6);
                                }
                                if (helper.Read(i, j) == "2")
                                {
                                    secondSubjects.Add(j - 6);
                                }
                                if (helper.Read(i, j) == "3")
                                {
                                    thirdSubjects.Add(j - 6);
                                }
                            }

                            if (!universities.Exists(item => item.Name == university))
                            {
                                universities.Add(new University(university, new int[] { 10, 10, 10 }));
                            }
                            Direction newDir = new Direction(id, name, numberOfPlaces, minimalScore, new List<List<int>> { firstSubjects, secondSubjects, thirdSubjects });
                            University newUni = universities.Find(item => item.Name == university);
                            newUni.Directions.Add(newDir);
                            newDir.University = newUni;
                            directions.Add(newDir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //foreach (Direction dir in directions)
            //{
            //    Console.WriteLine($"{dir.Name} {(Subjects)dir.FirstSubjects[0]}");
            //}
            foreach (University uni in universities)
            {
                foreach (Direction dir in uni.Directions)
                {
                    Console.WriteLine($"{uni.Name} - {dir.Name}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            DoSomeShit();
        }
    }
}
