using CourseWorkLibrary;

namespace CourseWork
{
    public partial class DirectionForm : Form
    {
        public DirectionForm()
        {
            InitializeComponent();
            this.Text = "Список направлений";
        }

        private void DirectionForm_Load(object sender, EventArgs e)
        {
            if (Globals.Universities.Count != 0)
            {
                comboBox1.Items.AddRange(Globals.Universities.ToArray());
                InitializeGrid();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedUniversity = comboBox1.SelectedIndex;
            if (comboBox2.Items.Count != 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
            }
            comboBox2.Items.AddRange(Globals.Universities[selectedUniversity].Directions.ToArray());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Student student in Globals.Students)
            {
                student.CountScore();
            }
            dataGridView1.Rows.Clear();
            int selectedUniversity = comboBox1.SelectedIndex;
            int selectedDirection = comboBox2.SelectedIndex;
            Globals.Universities[selectedUniversity].Directions[selectedDirection].RejectNonApplicants();
            foreach (Student student in Globals.Universities[selectedUniversity].Directions[selectedDirection].Students)
            {
                if (student.Directions[student.CurrentDirection] == Globals.Universities[selectedUniversity].Directions[selectedDirection])
                {
                    DataGridViewCell apply = new DataGridViewTextBoxCell();
                    DataGridViewCell name = new DataGridViewTextBoxCell();
                    DataGridViewCell surname = new DataGridViewTextBoxCell();
                    DataGridViewCell otch = new DataGridViewTextBoxCell();
                    DataGridViewCell score = new DataGridViewTextBoxCell();
                    DataGridViewCell firstSubject = new DataGridViewTextBoxCell();
                    DataGridViewCell secondSubject = new DataGridViewTextBoxCell();
                    DataGridViewCell thirdSubject = new DataGridViewTextBoxCell();
                    DataGridViewCell additionalScore = new DataGridViewTextBoxCell();
                    apply.Value = student.Entered.ToString();
                    name.Value = student.Name;
                    surname.Value = student.SurName;
                    otch.Value = student.ThirdName;
                    score.Value = student.CountScore();
                    firstSubject.Value = student.MaxScoreOnSubjectsGroup(0);
                    secondSubject.Value = student.MaxScoreOnSubjectsGroup(1);
                    thirdSubject.Value = student.MaxScoreOnSubjectsGroup(2);
                    additionalScore.Value = student.CountAdditionalScore();
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.AddRange(apply, name, surname, otch, score, firstSubject, secondSubject, thirdSubject, additionalScore);
                    dataGridView1.Rows.Add(row);
                }
            }
            label3.Visible = true;
            label3.Text = $"Кол-во бюджетных мест: {Globals.Universities[selectedUniversity].Directions[selectedDirection].NumberOfPlaces}";



        }
        void InitializeGrid()
        {
            DataGridViewTextBoxColumn column00 = new DataGridViewTextBoxColumn();
            column00.Name = "apply";
            column00.HeaderText = "Статус";

            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "name";
            column0.HeaderText = "Имя";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "surName";
            column1.HeaderText = "Фамилия";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "otch";
            column2.HeaderText = "Отчество";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "score";
            column3.HeaderText = "Кол-во баллов";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "firstSubject";
            column4.HeaderText = "Первый предмет";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "secondSubject";
            column5.HeaderText = "Второй предмет";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "thirdSubject";
            column6.HeaderText = "Третий предмет";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "additionalScore";
            column7.HeaderText = "Дополнительные баллы";

            dataGridView1.Columns.AddRange(column00, column0, column1, column2, column3, column4, column5, column6, column7);
        }
    }
}
