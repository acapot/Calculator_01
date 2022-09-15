using System.Security.Cryptography.X509Certificates;

namespace Calculator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.runCalculator();
        }
    }
}