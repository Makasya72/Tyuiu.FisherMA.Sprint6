

namespace Task4Var26
{
    public partial class Form1 : Form
    {
        private const double StartX = -5;
        private const double EndX = 5;
        private const double Step = 1;
        private const string FileName = "OutPutFileTask4V26.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_SAV_Click(object sender, EventArgs e)
        {
            textBoxOutput_SAV.Clear();

            double x = StartX;

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                sw.WriteLine("Ðåçóëüòàòû òàáóëèðîâàíèÿ ôóíêöèè âàðèàíò ¹26:");
                sw.WriteLine("------------------------------------------------");

                while (x <= EndX)
                {
                    double denom = 2 * x - 0.5;
                    double y;

                    if (Math.Abs(denom) < 0.000001) // Ïðîâåðêà äåëåíèÿ íà íîëü
                        y = 0;
                    else
                        y = 5 - 3 * x + (1 + Math.Sin(x)) / denom;

                    y = Math.Round(y, 2);

                    // Âûâîä íà ýêðàí
                    string line = $"X = {x};   F(X) = {y}";
                    textBoxOutput_SAV.AppendText(line + Environment.NewLine);

                    // Çàïèñü â ôàéë
                    sw.WriteLine(line);

                    // Ãðàôèê

                    x += Step;
                }
            }

            MessageBox.Show("Òàáëèöà ñîçäàíà è ñîõðàíåíà â ôàéë!", "Ãîòîâî", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)
        {
            if (textBoxOutput_SAV.TextLength == 0)
            {
                MessageBox.Show("Íåò äàííûõ äëÿ ñîõðàíåíèÿ!");
                return;
            }

            File.WriteAllText(FileName, textBoxOutput_SAV.Text);
            MessageBox.Show("Ôàéë óñïåøíî ñîõðàí¸í!", "Ñîõðàíåíî");
        }
    }
}