using CourseWorkLibrary;
namespace CourseWork
{
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
            this.Text = "Список абитуриентов";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeGrid()
        {
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
            column4.Name = "directions";
            column4.HeaderText = "Направления";

            dataGridView1.Columns.AddRange(column0, column1, column2, column3, column4);

        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            InitializeGrid();
            foreach (Student student in Globals.Students)
            {
                DataGridViewCell name = new DataGridViewTextBoxCell();
                DataGridViewCell surname = new DataGridViewTextBoxCell();
                DataGridViewCell otch = new DataGridViewTextBoxCell();
                DataGridViewCell score = new DataGridViewTextBoxCell();
                DataGridViewCell directions = new DataGridViewTextBoxCell();

                name.Value = student.Name;
                surname.Value = student.SurName;
                otch.Value = student.ThirdName;
                score.Value = student.CountScore();
                string dirText = "";
                foreach (Direction dir in student.Directions)
                {
                    dirText += $"{dir.University} - {dir.Name}\r\n";
                }
                directions.Value = dirText;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(name, surname, otch, score, directions);
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }
    }
}
