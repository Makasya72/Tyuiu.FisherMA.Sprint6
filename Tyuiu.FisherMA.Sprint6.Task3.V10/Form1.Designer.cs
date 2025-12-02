namespace Tyuiu.FisherMA.Sprint6.Task3.V10
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxOne_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            dataGridViewOne_SNM = new DataGridView();
            groupBoxTwo_SNM = new GroupBox();
            textBoxResult_SNM = new TextBox();
            buttonReference_SNM = new Button();
            buttonDone_SNM = new Button();
            labelOne_SNM = new Label();
            groupBoxOne_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).BeginInit();
            groupBoxTwo_SNM.SuspendLayout();
            SuspendLayout();

            // groupBoxOne_SNM
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Controls.Add(dataGridViewOne_SNM);
            groupBoxOne_SNM.Location = new Point(12, 12);
            groupBoxOne_SNM.Size = new Size(570, 426);
            groupBoxOne_SNM.Text = "Условие";

            textBoxTask_SNM.BorderStyle = BorderStyle.None;
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Location = new Point(6, 22);
            textBoxTask_SNM.Size = new Size(297, 398);
            textBoxTask_SNM.Text =
                "Дан массив 5×5.\r\n" +
                "Заменить чётные значения в 5-й строке на 0.";

            dataGridViewOne_SNM.Location = new Point(309, 100);
            dataGridViewOne_SNM.Size = new Size(250, 250);
            dataGridViewOne_SNM.RowHeadersVisible = false;

            // groupBoxTwo_SNM
            groupBoxTwo_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxTwo_SNM.Controls.Add(buttonReference_SNM);
            groupBoxTwo_SNM.Controls.Add(buttonDone_SNM);
            groupBoxTwo_SNM.Controls.Add(labelOne_SNM);
            groupBoxTwo_SNM.Location = new Point(588, 12);
            groupBoxTwo_SNM.Size = new Size(200, 426);
            groupBoxTwo_SNM.Text = "Вывод данных";

            labelOne_SNM.Text = "Результат:";
            labelOne_SNM.Location = new Point(6, 30);

            textBoxResult_SNM.ReadOnly = true;
            textBoxResult_SNM.Location = new Point(6, 48);
            textBoxResult_SNM.Size = new Size(175, 33);

            buttonReference_SNM.Text = "?";
            buttonReference_SNM.Location = new Point(29, 397);
            buttonReference_SNM.Click += buttonReference_Click;

            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.Location = new Point(94, 397);
            buttonDone_SNM.Click += buttonDone_Click;

            Controls.Add(groupBoxOne_SNM);
            Controls.Add(groupBoxTwo_SNM);
            Text = "Спринт 6 | Таск 3 | Вариант 10 | Фишер М. А.";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMain_Load;
            ClientSize = new Size(800, 450);

            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).EndInit();
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SNM;
        private TextBox textBoxTask_SNM;
        private DataGridView dataGridViewOne_SNM;
        private GroupBox groupBoxTwo_SNM;
        private Button buttonReference_SNM;
        private Button buttonDone_SNM;
        private Label labelOne_SNM;
        private TextBox textBoxResult_SNM;
    }
}