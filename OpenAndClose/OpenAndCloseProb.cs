namespace Solid.OpenAndClose
{
    public class OpenAndCloseProb
    {
        public void SendPdfReport()
        {
            System.Console.WriteLine("Send Pdf Report");
        }

        public void SendExcelReport()
        {
            System.Console.WriteLine("Send excel report");
        }

        public void SendTextReport()
        {
            System.Console.WriteLine("Send text report");
        }

        // New requirement, to send csv report

        public void SendCsvReport()
        {
            System.Console.WriteLine("Send csv Report");
        }
    }
}