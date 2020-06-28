using System;
using Solid.OpenAndClose;
using Solid.OpenAndClose.OpenAndCloseSol;
using Solid.SingleResponsibility;
using Solid.SingleResponsibility.SingleRespSol;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // SingleRespProb();
            // SingleRespSol();


            // OpenAndCloseProd();
            OpenAndCloseSol();
        }

        static void OpenAndCloseSol()
        {
            new PdfReport().SendReport();
            // Any new requirement comes, then create new class and its own implementation
            new CSVReport().SendReport();
        }

        static void OpenAndCloseProd()
        {
            new OpenAndCloseProb().SendPdfReport();
            // Problem when new requirment comes to implement CSV report
            new OpenAndCloseProb().SendCsvReport();
        }

        static void SingleRespProb()
        {
            new SingleRespProb().PrintPdfReport();
            new SingleRespProb().CreateCustomer();
        }

        static void SingleRespSol()
        {
            new PrintReport().PrintPdfReport();
            new Customer().CreateCustomer();
        }
    }
}
