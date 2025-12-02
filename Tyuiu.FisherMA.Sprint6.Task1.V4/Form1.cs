
using Tyuiu.FisherMA.Sprint6.Task1.V4.Lib;

namespace Tyuiu.FisherMA.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelpClick_srv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Òàñê 1 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-25-1 Ôèøåð Ìàêñèì Àëåêñååâè÷",
                "Ñîîáùåíèå",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonStrt_click_srv_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startStep = Convert.ToInt32(textBoxone_srv.Text);
                int stopStep = Convert.ToInt32(textBoxtwosrv.Text);

                double[] values = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+------------+\n");
                textBoxResult.AppendText("|    X     |    f(x)    |\n");
                textBoxResult.AppendText("+----------+------------+\n");

                int x = startStep;

                foreach (double v in values)
                {
                    string line = String.Format("|{0,8:d}|{1,10:f2}|\n", x, v);
                    textBoxResult.AppendText(line);
                    x++;
                }

                textBoxResult.AppendText("+----------+------------+\n");
            }
            catch
            {
                MessageBox.Show(
                    "Ââåäåíû íåâåðíûå äàííûå",
                    "Îøèáêà",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}