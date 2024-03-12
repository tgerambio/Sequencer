namespace Sequencer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            
            ApplicationConfiguration.Initialize();
            new Thread(() => { Application.Run(new SequenceBlocks()); }).Start();
            Application.Run(new CircleOfFifthsUI());
            
        }
    }
}