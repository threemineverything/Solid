using System;
using Solid.SingleResponsibility;
using Solid.SingleResponsibility.SingleRespSol;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // SingleRespProb();
            SingleRespSol();
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
