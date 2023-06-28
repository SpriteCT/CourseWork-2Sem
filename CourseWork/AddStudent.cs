using CourseWorkLibrary;
namespace CourseWork
{
    public partial class AddStudent : Form
    {
        int[] score = new int[10];
        List<Direction> directions = new List<Direction>();
        int previousSubject;
        public AddStudent()
        {
            InitializeComponent();
            this.Text = "Добавить абитуриента";
        }

        private void University_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedUniversity = UniversitysBox.SelectedIndex;
            if (DirectionsBox.Items.Count != 0)
            {
                DirectionsBox.Items.Clear();
                DirectionsBox.Text = "";
            }
            DirectionsBox.Items.AddRange(Globals.Universities[selectedUniversity].Directions.ToArray());
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            UniversitysBox.Items.AddRange(Globals.Universities.ToArray());
            BoxSubjects.Items.AddRange(new string[] { "Русский язык", "Математика", "Информатика", "Физика", "Химия", "География", "Обществознание", "История", "Английский язык", "Биология" });

        }

        private void BoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number;
            if (SubjectScore.Enabled)
            {
                if (int.TryParse(SubjectScore.Text, out number))
                {
                    if (number > 100) number = 100;
                    score[previousSubject] = number;
                }
            }
            else
            {
                SubjectScore.Enabled = true;
            }
            SubjectScore.Text = score[BoxSubjects.SelectedIndex].ToString();
            previousSubject = BoxSubjects.SelectedIndex;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int number;
            if (SubjectScore.Enabled)
            {
                if (int.TryParse(SubjectScore.Text, out number))
                {
                    if (number > 100) number = 100;
                    score[BoxSubjects.SelectedIndex] = number;
                }
            }
            if (StudentName.Text == "" || StudentSurName.Text == "" || directions.Count == 0)
            {
                IncorrectInput.Visible = true;
            }
            else
            {
                Student newStudent = new Student(StudentName.Text, StudentSurName.Text, StudentThirdName.Text, score, new bool[] { GoldMedal.Checked, Volunteering.Checked, GTO.Checked });
                newStudent.Directions = directions;
                directions[0].Students.Add(newStudent);
                newStudent.CountScore();
                Globals.Students.Add(newStudent);
                IncorrectInput.Visible = false;
            }
            StudentName.Text = "";
            StudentSurName.Text = "";
            StudentThirdName.Text = "";
            score = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SubjectScore.Text = "";
            SubjectScore.Enabled = false;
            GoldMedal.Checked = false;
            GTO.Checked = false;
            Volunteering.Checked = false;
            directions = new List<Direction>();
            FirstDirection.Visible = false;
            SecondDirection.Visible = false;
            ThirdDirection.Visible = false;
        }

        private void AddDirection_Click(object sender, EventArgs e)
        {
            if (DirectionsBox.SelectedIndex >= 0 && UniversitysBox.SelectedIndex >= 0 && directions.Count < 4)
            {
                if (!directions.Contains(Globals.Universities[UniversitysBox.SelectedIndex].Directions[DirectionsBox.SelectedIndex]))
                {
                    directions.Add(Globals.Universities[UniversitysBox.SelectedIndex].Directions[DirectionsBox.SelectedIndex]);

                    switch (directions.Count)
                    {
                        case 1:
                            FirstDirection.Visible = true;
                            FirstDirection.Text = "Первое направление: " + directions[0].University.Name + " - " + directions[0].Name;
                            break;
                        case 2:
                            SecondDirection.Visible = true;
                            SecondDirection.Text = "Второе направление: " + directions[1].University.Name + " - " + directions[1].Name;
                            break;
                        case 3:
                            ThirdDirection.Visible = true;
                            ThirdDirection.Text = "Третье направление: " + directions[2].University.Name + " - " + directions[2].Name;
                            break;
                    }
                }
            }
        }
    }
}
