using System;
using System.Windows.Forms;
using Tyuiu.FisherMA.Sprint6.Task3.V10.Lib;

namespace Tyuiu.FisherMA.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5]
        {
            { -17, 6, -19, 6, -13 },
            { -19, 3, 12, -11, 19 },
            { -20, 11, 9, 19, -19 },
            { -20, 10, -9, 17, 9 },
            { -4, 9, -8, 13, -8 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewOne_SNM.ColumnCount = columns;
            dataGridViewOne_SNM.RowCount = rows;

            for (int i = 0; i < columns; i++)
                dataGridViewOne_SNM.Columns[i].Width = 40;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    dataGridViewOne_SNM.Rows[i].Cells[j].Value = mtrx[i, j];
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    dataGridViewOne_SNM.Rows[i].Cells[j].Value = result[i, j];

            textBoxResult_SNM.Text = "Готово";
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 3 выполнил студент группы ИИПб-25-1 Фишер Максим Алексеевич",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}