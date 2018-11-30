using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Daty
{
    class Program
    {
        static void Main(string[] args)
        {
            Wynik wynik = new Wynik();
            while (true)
            {
                try
                {
                    string text;
                    text = Console.ReadLine();
                    if (text == "Exit")
                        break;
                    AntlrInputStream inputStream = new AntlrInputStream(text);
                    DatyLexer lexer = new DatyLexer(inputStream);
                    CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                    DatyParser parser = new DatyParser(commonTokenStream);
                    DatyParser.ProgContext prog = parser.prog();

                    Visitor visitor = new Visitor();
                    visitor.Visit(prog);
                    wynik = visitor.ZwrocWynik();
                    wynik.Wypisz();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " +ex);
                }

            }
        }
    }
    

}
