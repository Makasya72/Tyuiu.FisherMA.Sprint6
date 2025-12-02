using Tyuiu.FisherMA.Sprint6.Task6.V9.Lib;
namespace Tyuiu.FisherMA.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutFile.Text = groupBoxOutPutFile.Text + openFileDialogTask.FileName;
            buttonOK.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }

    internal class FormAbout
    {
        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}