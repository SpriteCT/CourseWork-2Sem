namespace CourseWorkLibrary
{
    public class Student : IComparable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ThirdName { get; set; }
        public int[] Subjects { get; set; }
        public int Score { get; set; }
        public bool Entered { get; set; }

        public bool[] Additionals = new bool[3];
        public int CurrentDirection
        {
            get { return currentDirection; }
            set
            {
                currentDirection = value;
                Score = CountScore();
            }
        }

        public List<Direction> Directions = new();
        private int currentDirection;

        public Student(string name, string surName, string thirdName, int[] subjects, bool[] additionals)
        {
            Name = name;
            SurName = surName;
            ThirdName = thirdName;
            Subjects = subjects;
            Additionals = additionals;
            currentDirection = 0;
            Entered = true;
        }
        public Student(string name, int[] subjects) : this(name, "", "", subjects, new bool[] { false, false, false })
        {
        }
        public int CompareTo(object obj)
        {
            if (obj is Student student)
            {
                if (student.Score == Score)
                {
                    for (int i = 0; i < Directions[CurrentDirection].Subjects.Count; i++)
                    {
                        if (MaxScoreOnSubjectsGroup(i) != student.MaxScoreOnSubjectsGroup(i))
                        {
                            return MaxScoreOnSubjectsGroup(i).CompareTo(student.MaxScoreOnSubjectsGroup(i));
                        }
                    }
                }
                return Score.CompareTo(student.Score);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }

        public void TransferToNextDirection()
        {
            if (CurrentDirection + 1 < Directions.Count)
            {
                Directions[CurrentDirection].Students.Remove(this);

                Directions[CurrentDirection + 1].Students.Add(this);
                CurrentDirection++;
            }
        }
        public int CountScore()
        {
            int score = 0;
            foreach (List<int> subjList in Directions[CurrentDirection].Subjects)
            {
                int max = 0;
                foreach (int subj in subjList)
                {
                    if (Subjects[subj] > max)
                    {
                        max = Subjects[subj];
                    }
                }
                score += max;
            }
            score += CountAdditionalScore();
            return score;
        }

        public int CountAdditionalScore()
        {
            int score = 0;
            for (int i = 0; i < Additionals.Length; i++)
            {
                if (Additionals[i])
                {
                    score += Directions[currentDirection].University.AdditionalScores[i];
                }
            }
            if (score > 10) score = 10;
            return score;
        }
        public int MaxScoreOnSubjectsGroup(int subjectsGroup)
        {
            int max = 0;
            foreach (int subj in Directions[CurrentDirection].Subjects[subjectsGroup])
            {
                if (Subjects[subj] > max)
                {
                    max = Subjects[subj];
                }
            }
            return max;
        }
    }
}
