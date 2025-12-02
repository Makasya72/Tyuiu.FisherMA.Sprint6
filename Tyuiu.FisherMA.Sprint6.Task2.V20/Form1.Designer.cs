namespace Tyuiu.FisherMA.Sprint6.Task2.V20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private DataVisualization.Charting.Chart GetChartFunction()
        {
            return chartFunction;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(DataVisualization.Charting.Chart chartFunction)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBoxVarStop = new TextBox();
            textBox5 = new TextBox();
            textBoxVarStart = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonHelp = new Button();
            groupBox3 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(318, 304);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(145, 41);
            buttonDone.TabIndex = 17;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBoxVarStop);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxVarStart);
            groupBox2.Location = new Point(12, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 84);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(162, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 16);
            textBox3.TabIndex = 5;
            textBox3.Text = "Конец шага:";
            // 
            // textBoxVarStop
            // 
            textBoxVarStop.BackColor = SystemColors.Window;
            textBoxVarStop.Location = new Point(162, 48);
            textBoxVarStop.Name = "textBoxVarStop";
            textBoxVarStop.Size = new Size(109, 23);
            textBoxVarStop.TabIndex = 4;
            textBoxVarStop.KeyPress += textBoxVarStop_KeyPress;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(23, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(109, 16);
            textBox5.TabIndex = 3;
            textBox5.Text = "Начало шага:";
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.BackColor = SystemColors.Window;
            textBoxVarStart.Location = new Point(23, 48);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(109, 23);
            textBoxVarStart.TabIndex = 0;
            textBoxVarStart.KeyPress += textBoxVarStart_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 244);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DeepSkyBlue;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(318, 272);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(145, 29);
            buttonHelp.TabIndex = 16;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // groupBox3

            // chartFunction

            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction.Location = new Point(4, 27);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(103, 301);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 362);
            Controls.Add(groupBox3);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBoxVarStop;
        private TextBox textBox5;
        private TextBox textBoxVarStart;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonHelp;
        private GroupBox groupBox3;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}