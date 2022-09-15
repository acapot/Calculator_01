using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_01
{
    internal class Calculator
    {
        bool anotherCalculation=true;
        string? theOperator;
        double num1;
        double num2;

        public void runCalculator()
        {
            while (anotherCalculation)
            {
                showMenu();
                chooseOperator();
                insertNumber("first");
                insertNumber("second");
                mathOperation();
                ifContinue();
            }
            
        }

        public void showMenu()
        {
            Console.WriteLine("||=========================================||");
            Console.WriteLine("|| Select one of those operators---        ||");
            Console.WriteLine("|| Choose \"+\"   For Addision               ||");
            Console.WriteLine("|| Choose \"-\"   For Substraction           ||");
            Console.WriteLine("|| Choose \"*\"   For Multiplication         ||");
            Console.WriteLine("|| Choose \"/\"   For Division               ||");
            Console.WriteLine("||=========================================||");
        }

        public void chooseOperator()
        {
            bool isValidOperator=false;
            theOperator = Console.ReadLine();
            Console.WriteLine();
            while (!isValidOperator)
            {
                switch (theOperator)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        isValidOperator = true;
                        break;
                    default:
                        Console.WriteLine("this operator doesn't exist, try again !!");
                        Console.WriteLine("------------------------------------------");

                        //showMenu();

                        theOperator = Console.ReadLine();
                        isValidOperator = false;
                        break;

                }
            }
        }
        public void insertNumber (string whichNumber)
        {
            double numberInserted = 0;
            Console.Write("Enter the " + whichNumber + " number: ");
            bool isNumber = double.TryParse(Console.ReadLine(), out numberInserted);

            while (!isNumber)
            {
                Console.Beep();
                Console.WriteLine();
                Console.Write("Enter the "+ whichNumber + " correctly... ");
                isNumber = double.TryParse(Console.ReadLine(), out numberInserted);

            }

            if (whichNumber == "first")
            {
               num1 = numberInserted;
            }
            else if (whichNumber == "second")
            {
                num2 = numberInserted;
            }
            else
            {
                Console.Write("wrong whichNumber");
            }

        }

        public void mathOperation() {

            switch (theOperator)
            {

                case "+":
                    addision();
                    break;

                case "-":
                    substraction();
                    break;

                case "*":
                    multiplication();
                    break;

                case "/":
                    division();
                    break;


                default:
                    Console.WriteLine("Wrong operator....!");
                    break;

            }


        }

        public bool ifContinue()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Do you want continue (y / n)");
            char answerForContinue = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (answerForContinue != 'n' && answerForContinue != 'y')
            {
                Console.WriteLine("the possible answer are y or n");
                answerForContinue = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }


            switch (answerForContinue)
            {
                case 'y':
                    anotherCalculation = true;
                    break;

                case 'n':
                    anotherCalculation = false;
                    Console.WriteLine("Thank you for using our system !!");
                    break;
                default:
                    anotherCalculation = false;
                    Console.WriteLine("Thank you for using our system!!");
                    break;
            }

            return anotherCalculation;


        }

        public void addision()
        {
            Console.WriteLine("you choose addition and the result is: " + (num1 + num2));
        }

        public void substraction()
        {
            Console.WriteLine("you choose substraction and the result is: " + (num1 - num2));
        }

        public void multiplication()
        {
            Console.WriteLine("you choose multiplication and the result is: " + (num1 * num2));
        }

        public void division()
        {
            Console.WriteLine("you choose division and the result is: " + (num1 / num2));
        }


    }
}
