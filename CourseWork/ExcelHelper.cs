using Excel = Microsoft.Office.Interop.Excel;

namespace CourseWork
{
    public class ExcelHelper : IDisposable
    {
        private Excel.Application _excel;
        private Excel.Workbook _workbook;
        private string _filePath;
        public ExcelHelper()
        {
            _excel = new Excel.Application();
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add(filePath);
                    _filePath = filePath;
                }

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }
        public string Read(int row, int column)
        {
            try
            {
                if (((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].value != null)
                {
                    return ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].value.ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }
    }
}