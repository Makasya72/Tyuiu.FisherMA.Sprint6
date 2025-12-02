using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FisherMA.Sprint6.Task0.V2.Lib;
namespace Tyuiu.FisherMA.Sprint6.Task0.V2
{
    public partial class FormMain_LMV : Form
    {
        public FormMain_LMV()
        {
            InitializeComponent();
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÈÑÒÍá-24-1 Òîäèêîâ Äàíèèë Ýäóàðäîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut_LMV.Text)));
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInPut_LMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInPut_LMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}