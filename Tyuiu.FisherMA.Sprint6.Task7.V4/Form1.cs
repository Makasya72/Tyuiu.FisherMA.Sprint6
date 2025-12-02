using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.FisherMA.Sprint6.Task7.V4.Lib;

namespace Tyuiu.FisherMA.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Çíà÷åíèÿ, ðàçäåëåíåíûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Çíà÷åíèÿ, ðàçäåëåíåíûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }
        static int rows = 10;
        static int columns = 10;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int colums = line[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] values = line[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(values[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;
            for (int w = 0; w < columns; w++)
            {
                dataGridViewIn.Columns[w].Width = 25;
                dataGridViewOut.Columns[w].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int colums = dataGridViewOut.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Îòêðûòü ôàéë";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Âûïîëíèòü";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Ñîõðàíèòü â ôàéë";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

    internal class FormAbout
    {
        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}