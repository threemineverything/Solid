using System.Collections.Generic;
namespace Solid.SingleResponsibility
{
    public class SingleRespProb
    {
        public void PrintPdfReport()
        {
            System.Console.WriteLine("Print Pdf Report");
        }

        public void PrintExcelReport()
        {
            System.Console.WriteLine("Print Excel Report");
        }

        public void PrintTextReport()
        {
            System.Console.WriteLine("Print Text Report");
        }


        public void CreateCustomer()
        {
            System.Console.WriteLine("Create Customer");
        }

        public void GetCustomer()
        {
            System.Console.WriteLine("GetCustomer");
        }
    }
}