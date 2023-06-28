using CourseWorkLibrary;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Распределение абитуриентов";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form DirForm = new DirectionForm();
            DirForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AddStud = new AddStudent();
            AddStud.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                button5.Enabled = true;
                try { Globals.Universities = Program.ReadDirections(openFileDialog1.FileName); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form StudentsList = new StudentsList();
            StudentsList.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                button6.Enabled = true;
                button2.Enabled = true;
                try { Globals.Students = Program.ReadStudents(openFileDialog1.FileName); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool fl = true;
            while (fl)
            {
                foreach (Student student in Globals.Students)
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
                    foreach (Direction dir in Globals.Directions)
                    {
                        dir.RejectNonApplicants();
                        dir.TransferStudentsToNextDirection();
                    }
                }
            }
            label3.Visible = true;
        }
    }
}