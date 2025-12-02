namespace Tyuiu.FisherMA.Sprint6.Task7.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 88);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(784, 88);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(778, 69);
            this.textBoxTask.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 171);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 240);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 240);
            this.panel3.TabIndex = 2;
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.dataGridViewIn);
            this.groupBoxInPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(383, 240);
            this.groupBoxInPut.TabIndex = 0;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.ReadOnly = true;
            this.dataGridViewIn.Size = new System.Drawing.Size(377, 221);
            this.dataGridViewIn.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutPut);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(386, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 240);
            this.panel4.TabIndex = 3;
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewOut);
            this.groupBoxOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(398, 240);
            this.groupBoxOutPut.TabIndex = 0;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.ReadOnly = true;
            this.dataGridViewOut.Size = new System.Drawing.Size(392, 221);
            this.dataGridViewOut.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(386, 171);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 240);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 

            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 4 | Фишер М. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxInPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}