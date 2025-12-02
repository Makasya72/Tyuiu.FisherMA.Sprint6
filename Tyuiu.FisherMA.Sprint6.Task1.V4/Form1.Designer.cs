
namespace Tyuiu.FisherMA.Sprint6.Task1.V4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            groupBoxviv_srv = new GroupBox();
            textBoxResult = new TextBox();
            groupBox_hate = new GroupBox();
            textBoxtwosrv = new TextBox();
            textBoxone_srv = new TextBox();
            textBoxcon_srv = new TextBox();
            textBoxshaga_srv = new TextBox();
            buttonHelpClick_srv = new Button();
            buttonStrt_click_srv = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxviv_srv.SuspendLayout();
            groupBox_hate.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(853, 367);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            groupBoxTask.Enter += textBox1_TextChanged;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(3, 19);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(643, 213);
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // groupBoxviv_srv
            // 
            groupBoxviv_srv.Controls.Add(textBoxResult);
            groupBoxviv_srv.Location = new Point(824, 12);
            groupBoxviv_srv.Name = "groupBoxviv_srv";
            groupBoxviv_srv.Size = new Size(382, 586);
            groupBoxviv_srv.TabIndex = 2;
            groupBoxviv_srv.TabStop = false;
            groupBoxviv_srv.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(29, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(315, 544);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // groupBox_hate
            // 
            groupBox_hate.Controls.Add(textBoxtwosrv);
            groupBox_hate.Controls.Add(textBoxone_srv);
            groupBox_hate.Controls.Add(textBoxcon_srv);
            groupBox_hate.Controls.Add(textBoxshaga_srv);
            groupBox_hate.Location = new Point(15, 458);
            groupBox_hate.Name = "groupBox_hate";
            groupBox_hate.Size = new Size(503, 120);
            groupBox_hate.TabIndex = 3;
            groupBox_hate.TabStop = false;
            groupBox_hate.Text = "Ввод данных";
            // 
            // textBoxtwosrv
            // 
            textBoxtwosrv.Location = new Point(165, 75);
            textBoxtwosrv.Name = "textBoxtwosrv";
            textBoxtwosrv.Size = new Size(119, 23);
            textBoxtwosrv.TabIndex = 3;
            textBoxtwosrv.TextChanged += textBoxtwosrv_TextChanged;
            // 
            // textBoxone_srv
            // 
            textBoxone_srv.Location = new Point(6, 75);
            textBoxone_srv.Name = "textBoxone_srv";
            textBoxone_srv.Size = new Size(119, 23);
            textBoxone_srv.TabIndex = 2;
            // 
            // textBoxcon_srv
            // 
            textBoxcon_srv.BackColor = SystemColors.Control;
            textBoxcon_srv.Location = new Point(165, 46);
            textBoxcon_srv.Name = "textBoxcon_srv";
            textBoxcon_srv.ReadOnly = true;
            textBoxcon_srv.Size = new Size(119, 23);
            textBoxcon_srv.TabIndex = 1;
            textBoxcon_srv.Text = "Конец шага";
            // 
            // textBoxshaga_srv
            // 
            textBoxshaga_srv.BackColor = SystemColors.Control;
            textBoxshaga_srv.Location = new Point(6, 46);
            textBoxshaga_srv.Name = "textBoxshaga_srv";
            textBoxshaga_srv.ReadOnly = true;
            textBoxshaga_srv.Size = new Size(119, 23);
            textBoxshaga_srv.TabIndex = 0;
            textBoxshaga_srv.Text = "Начало шага";
            // 
            // buttonHelpClick_srv
            // 
            buttonHelpClick_srv.BackColor = SystemColors.Highlight;
            buttonHelpClick_srv.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_srv.ForeColor = SystemColors.ControlText;
            buttonHelpClick_srv.Location = new Point(554, 526);
            buttonHelpClick_srv.Name = "buttonHelpClick_srv";
            buttonHelpClick_srv.Size = new Size(91, 59);
            buttonHelpClick_srv.TabIndex = 4;
            buttonHelpClick_srv.Text = "Справка";
            buttonHelpClick_srv.UseVisualStyleBackColor = false;
            buttonHelpClick_srv.Click += buttonHelpClick_srv_Click;
            // 
            // buttonStrt_click_srv
            // 
            buttonStrt_click_srv.BackColor = Color.Lime;
            buttonStrt_click_srv.Location = new Point(688, 526);
            buttonStrt_click_srv.Name = "buttonStrt_click_srv";
            buttonStrt_click_srv.Size = new Size(102, 59);
            buttonStrt_click_srv.TabIndex = 5;
            buttonStrt_click_srv.Text = "Выполнить";
            buttonStrt_click_srv.UseVisualStyleBackColor = false;
            buttonStrt_click_srv.Click += buttonStrt_click_srv_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 626);
            Controls.Add(buttonStrt_click_srv);
            Controls.Add(buttonHelpClick_srv);
            Controls.Add(groupBox_hate);
            Controls.Add(groupBoxviv_srv);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 I Таск 1 I Вариант 4 I Фишер М. А.";
            Enter += textBox1_TextChanged;
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxviv_srv.ResumeLayout(false);
            groupBoxviv_srv.PerformLayout();
            groupBox_hate.ResumeLayout(false);
            groupBox_hate.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxtwosrv_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private GroupBox groupBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxviv_srv;
        private TextBox textBoxResult;
        private GroupBox groupBox_hate;
        private TextBox textBoxtwosrv;
        private TextBox textBoxone_srv;
        private TextBox textBoxcon_srv;
        private TextBox textBoxshaga_srv;
        private Button buttonHelpClick_srv;
        private Button buttonStrt_click_srv;
    }
}