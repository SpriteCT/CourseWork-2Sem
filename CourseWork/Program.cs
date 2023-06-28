using CourseWorkLibrary;

namespace CourseWork
{
    public static class Globals
    {
        public static List<University> Universities = new();
        public static List<Direction> Directions = new();
        public static List<Student> Students = new();
    }
    static class Program
    {
        public static List<University> ReadDirections(string filePath)
        {
            List<Direction> directions = new List<Direction>();
            List<University> universities = new List<University>();
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath))
                    {
                        for (int i = 2; i < 74; i++)
                        {
                            string name;
                            string university;
                            int id, minimalScore, numberOfPlaces;
                            int[] additionalScore = new int[3];
                            List<int> firstSubjects = new List<int>();
                            List<int> secondSubjects = new List<int>();
                            List<int> thirdSubjects = new List<int>();

                            id = int.Parse(helper.Read(i, 1));
                            university = helper.Read(i, 2);
                            name = helper.Read(i, 3);
                            numberOfPlaces = int.Parse(helper.Read(i, 4));
                            minimalScore = int.Parse(helper.Read(i, 5));
                            additionalScore[0] = int.Parse(helper.Read(i, 16));
                            additionalScore[1] = int.Parse(helper.Read(i, 17));
                            additionalScore[2] = int.Parse(helper.Read(i, 18));

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
                            newUni.AdditionalScores = additionalScore;
                            newUni.Directions.Add(newDir);
                            newDir.University = newUni;
                            directions.Add(newDir);
                            Globals.Directions.Add(newDir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return universities;
        }

        public static List<Student> ReadStudents(string filePath)
        {
            List<Student> students = new();
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    //if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "Directions")))
                    if (helper.Open(filePath))
                    {
                        for (int i = 1; i < 1000; i++)
                        {
                            string name, surname, thirdname;
                            int[] score = new int[10];
                            bool[] additionalScore = new bool[3];
                            name = helper.Read(i, 2);
                            surname = helper.Read(i, 1);
                            thirdname = helper.Read(i, 3);
                            for (int j = 4; j < 14; j++)
                            {
                                score[j - 4] = int.Parse(helper.Read(i, j));
                            }
                            for (int j = 14; j < 17; j++)
                            {
                                if (int.Parse(helper.Read(i, j)) == 1)
                                {
                                    additionalScore[j - 14] = true;
                                }
                                else
                                {
                                    additionalScore[j - 14] = false;
                                }
                            }
                            List<Direction> directions = new();
                            Random random = new Random();
                            for (int j = 0; j < 3; j++)
                                directions.Add(Globals.Directions[random.Next(Globals.Directions.Count)]);
                            Student newStudent = new Student(name, surname, thirdname, score, additionalScore);
                            newStudent.Directions = directions;
                            directions[0].Students.Add(newStudent);
                            newStudent.CountScore();
                            students.Add(newStudent);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return students;
        }
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Globals.Universities = ReadTable();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}