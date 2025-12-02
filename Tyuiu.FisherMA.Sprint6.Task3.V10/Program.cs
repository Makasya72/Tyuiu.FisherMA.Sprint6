namespace Tyuiu.FisherMA.Sprint6.Task3.V10
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}