namespace Tyuiu.FisherMA.Sprint6.Task6.V9
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            groupBoxValue = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            groupBoxOutPutFile = new GroupBox();
            textBoxResult = new TextBox();
            buttonFile = new Button();
            buttonOK = new Button();
            buttonHelp = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBoxTask.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxOutPutFile.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(1, 83);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1052, 110);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1034, 85);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(textBoxLoadFromFile);
            groupBoxValue.Location = new Point(12, 199);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(460, 324);
            groupBoxValue.TabIndex = 0;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(3, 22);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.Size = new Size(451, 296);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // groupBoxOutPutFile
            // 
            groupBoxOutPutFile.Controls.Add(textBoxResult);
            groupBoxOutPutFile.Location = new Point(478, 210);
            groupBoxOutPutFile.Name = "groupBoxOutPutFile";
            groupBoxOutPutFile.Size = new Size(566, 313);
            groupBoxOutPutFile.TabIndex = 0;
            groupBoxOutPutFile.TabStop = false;
            groupBoxOutPutFile.Text = "Вывод ";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 36);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(610, 271);
            textBoxResult.TabIndex = 0;
            // 
            // buttonFile
            // 
            buttonFile.Image = (Image)resources.GetObject("buttonFile.Image");
            buttonFile.Location = new Point(12, 12);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(64, 51);
            buttonFile.TabIndex = 1;
            toolTip.SetToolTip(buttonFile, "\r\nВыберите нужный файл для обработки");
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonOK
            // 
            buttonOK.Image = (Image)resources.GetObject("buttonOK.Image");
            buttonOK.Location = new Point(96, 12);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(46, 51);
            buttonOK.TabIndex = 2;
            toolTip.SetToolTip(buttonOK, "Выводит последнее слово каждой\r\n строки в результирующею строку.");
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(981, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(57, 51);
            buttonHelp.TabIndex = 3;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 535);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOK);
            Controls.Add(buttonFile);
            Controls.Add(groupBoxOutPutFile);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 9 | Фишер М. А.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxOutPutFile.ResumeLayout(false);
            groupBoxOutPutFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxValue;
        private TextBox textBoxLoadFromFile;
        private GroupBox groupBoxOutPutFile;
        private TextBox textBoxResult;
        private TextBox textBox1;
        private Button buttonFile;
        private Button buttonOK;
        private Button buttonHelp;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}