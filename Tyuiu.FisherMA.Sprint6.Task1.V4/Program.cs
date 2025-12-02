using Tyuiu.FisherMA.Sprint6.Task1.V4;

namespace Tyuiu.FisherMA.Sprint6.Task1.V4
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