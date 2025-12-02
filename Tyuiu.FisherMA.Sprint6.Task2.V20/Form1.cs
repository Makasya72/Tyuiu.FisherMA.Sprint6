using Tyuiu.FisherMA.Sprint6.Task2.V20.Lib;
namespace Tyuiu.FisherMA.Sprint6.Task2.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetChartFunction());
        }

        DataService ds = new DataService();

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Chartreuse;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.DarkRed;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int Startstep = Convert.ToInt32(textBoxVarStart.Text);
                int StopStep = Convert.ToInt32(textBoxVarStop.Text);

                int len = ds.GetMassFunction(Startstep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(Startstep, StopStep);




            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarStart_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStop_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}