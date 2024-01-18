namespace CourseWorkLibrary
{
    public class Direction
    {
        public int Id { get; set; }

        public List<Student> Students = new();
        public int NumberOfPlaces { private set; get; }
        public string Name { private set; get; }
        public int MinimalScore { private set; get; }
        public University? University { set; get; }

        public List<List<int>> Subjects = new();

        public Direction(int id, string name, int numberOfPlaces, int minimalScore, List<List<int>> subjects)
        {
            Name = name;
            Id = id;
            NumberOfPlaces = numberOfPlaces;
            MinimalScore = minimalScore;
            Subjects = subjects;
        }

        public void RejectNonApplicants()
        {
            Students.Sort();
            Students.Reverse();
            for (int i = 0; i < Students.Count; i++)
            {
                if (i < NumberOfPlaces && Students[i].Score >= MinimalScore)
                {
                    Students[i].Entered = true;
                }
                else
                {
                    Students[i].Entered = false;
                }
            }
        }
        public void TransferStudentsToNextDirection()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Entered == false)
                {
                    Students[i].TransferToNextDirection();
                }
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}