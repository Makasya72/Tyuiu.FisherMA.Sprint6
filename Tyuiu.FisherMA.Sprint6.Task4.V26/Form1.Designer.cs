namespace Task4Var26
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonRun_SAV = new System.Windows.Forms.Button();
            this.textBoxOutput_SAV = new System.Windows.Forms.TextBox();
            this.chartDiagram_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_SAV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_SAV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun_SAV
            // 
            this.buttonRun_SAV.Location = new System.Drawing.Point(15, 15);
            this.buttonRun_SAV.Name = "buttonRun_SAV";
            this.buttonRun_SAV.Size = new System.Drawing.Size(150, 35);
            this.buttonRun_SAV.Text = "Выполнить";
            this.buttonRun_SAV.UseVisualStyleBackColor = true;
            this.buttonRun_SAV.Click += new System.EventHandler(this.buttonRun_SAV_Click);
            // 
            // textBoxOutput_SAV
            // 
            this.textBoxOutput_SAV.Location = new System.Drawing.Point(15, 65);
            this.textBoxOutput_SAV.Multiline = true;
            this.textBoxOutput_SAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SAV.Size = new System.Drawing.Size(220, 300);
            // 
            // chartDiagram_SAV

            // buttonSave_SAV
            // 
            this.buttonSave_SAV.Location = new System.Drawing.Point(15, 380);
            this.buttonSave_SAV.Name = "buttonSave_SAV";
            this.buttonSave_SAV.Size = new System.Drawing.Size(150, 35);
            this.buttonSave_SAV.Text = "Сохранить в файл";
            this.buttonSave_SAV.UseVisualStyleBackColor = true;
            this.buttonSave_SAV.Click += new System.EventHandler(this.buttonSave_SAV_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave_SAV);
            this.Controls.Add(this.textBoxOutput_SAV);
            this.Controls.Add(this.buttonRun_SAV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вариант №26 — Табулирование";
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_SAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonRun_SAV;
        private System.Windows.Forms.Button buttonSave_SAV;
        private System.Windows.Forms.TextBox textBoxOutput_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_SAV;
    }
}