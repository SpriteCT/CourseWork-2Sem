namespace CourseWorkLibrary
{
    public class University
    {
        public string Name { get; set; }

        public int[] AdditionalScores = new int[3];
        public List<Direction> Directions { set; get; }

        public University(string name, int[] additionalScores)
        {
            Name = name;
            Directions = new List<Direction>();
            AdditionalScores = additionalScores;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
