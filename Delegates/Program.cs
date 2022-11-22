using System;

namespace Delegates
{
    public class Program
    {

        private static void Main()
        {
            Action<string> strOp; //Variavel do delegate

            Joiner joiner = new Joiner("String In StrConcat");

            strOp = PrintUpper;
            strOp += PrintLower;
            strOp += joiner.JoinAndPrint;

            strOp("This String Was Passed In tHe vAriAble");
        }
       private static void PrintUpper (string str)
       {
            Console.WriteLine(str.ToUpper());
       }

       private static void PrintLower (string str)
       {
            Console.WriteLine(str.ToLower());
       }
    }
}
