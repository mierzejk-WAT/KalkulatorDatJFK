using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

using static Daty.DatyParser;

namespace Daty
{
    class Visitor : DatyBaseVisitor<object>
    {

        Wynik wynik = new Wynik();
        bool flaga = true;
        
        public override object VisitDzialanie([NotNull] DzialanieContext context)
        {
            TimeSpan tspan;
            DateTime data;
            Wynik w1= new Wynik();
            Wynik w2 = new Wynik();
            if ((string)Visit(context.children[1]) != "koniec")
            {
                flaga = false;
                switch (context.op.Type)
                {
                    case MINUS:
                        if (wynik.typ == -1) w1 = (Wynik)Visit(context.children[0]);
                        else w1 = wynik;
                        w2 = (Wynik)Visit(context.wyrazenie().GetChild(0));
                        switch (RodzajDzialania(w1.typ, w2.typ))
                        {
                            case 1:
                                tspan = w1.data.Subtract(w2.data);
                                wynik.typ = 5;
                                wynik.span = tspan;
                                break;
                            case 2:
                                tspan = w1.span - w2.span;
                                wynik.typ = 5;
                                wynik.span = tspan;
                                break;
                            case 3:
                                data = w1.data - w2.span;
                                wynik.typ = w1.typ;
                                wynik.data = data;
                                break;
                            case 4:
                                wynik = new Wynik();
                                Console.WriteLine("Dzialanie Timespan - Data nie istnieje");
                                break;
                            default:
                                break;
                        }
                        break;
                    case PLUS:
                        if (wynik.typ == -1) w1 = (Wynik)Visit(context.children[0]);
                        else w1 = wynik;
                        w2 = (Wynik)Visit(context.wyrazenie().GetChild(0));
                        switch (RodzajDzialania(w1.typ, w2.typ))
                        {
                            case 1:
                                wynik = new Wynik();
                                Console.WriteLine("Dzialanie Data + Data nie istnieje");
                                break;
                            case 2:
                                tspan = w1.span + w2.span;
                                wynik.typ = 5;
                                wynik.span = tspan;
                                break;
                            case 3:
                                data = w1.data + w2.span;
                                wynik.typ = w1.typ;
                                wynik.data = data;
                                break;
                            case 4:
                                data = w2.data + w1.span;
                                wynik.typ = w2.typ;
                                wynik.data = data;
                                break;
                            default:
                                break;
                        }
                        break;

                }
            }else
            {
                if (flaga) wynik = (Wynik)Visit(context.children[0]);
            }
            return base.VisitDzialanie(context);
        }


        public override object VisitKoniec([NotNull] KoniecContext context)
        {
            string koniec = "koniec";
            return koniec;
        }
        public override object VisitDdmmrrrr([NotNull] DdmmrrrrContext context)
        {
            DateTime data;
            string d = context.GetText();
            string format = "dd.MM.yyyyhh:mm:ss";
            if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                format = "dd.MM.yyyy";
                if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data)) 
                {
                    format = "dd.MMM.yyyyhh:mm:ss";
                    if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                    {
                        format = "dd.MMM.yyyy";
                        if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                        {
                            Console.WriteLine("Data " +d +" nie istnieje");
                        }

                    }
                }
            }
            Wynik w = new Wynik();
            w.data = data;
            w.typ = 1;
            return w;
        }

        public override object VisitMmddrrrr([NotNull] MmddrrrrContext context)
        {

            DateTime data;
            string d = context.GetText();
            string format = "MM-dd-yyyyhh:mm:ss";
            if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                format = "MM-dd-yyyy";
                if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    format = "MMM-dd-yyyyhh:mm:ss";
                    if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                    {
                        format = "MMM-dd-yyyy";
                        if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                        {
                            Console.WriteLine("Data " + d + " nie istnieje");
                        }
                    }
                }
            }
            Wynik w = new Wynik();
            w.data = data;
            w.typ = 2;
            return w;
        }

        public override object VisitRrrrddmm([NotNull] RrrrddmmContext context)
        {
            DateTime data;
            string d = context.GetText();
            string format = "yyyy,dd,MMhh:mm:ss";
            if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                format = "yyyy,dd,MM";
                if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    format = "yyyy,dd,MMMhh:mm:ss";
                    if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                    {
                        format = "yyyy,dd,MMM";
                        if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                        {
                            Console.WriteLine("Data " + d + " nie istnieje");
                        }
                    }
                }
            }
            Wynik w = new Wynik();
            w.data = data;
            w.typ = 4;
            return w;
        }

        public override object VisitRrrrmmdd([NotNull] RrrrmmddContext context)
        {
            DateTime data;
            string d = context.GetText();
            string format = "yyyy/MM/ddhh:mm:ss";
            if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                format = "yyyy/MM/dd";
                if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    format = "yyyy/MMM/ddhh:mm:ss";
                    if (!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                    {
                        format = "yyyy/MMM/dd";
                        if(!DateTime.TryParseExact(d, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                        {
                            Console.WriteLine("Data " + d + " nie istnieje");
                        }
                    }
                }
            }
            Wynik w = new Wynik();
            w.data = data;
            w.typ = 3;
            return w;
        }


        public override object VisitTimespan([NotNull] TimespanContext context)
        {
            TimeSpan tspan;
            string t = context.GetText();
            t = t.Substring(1, t.Length - 2);
            if (!TimeSpan.TryParse(t, out tspan))
                Console.WriteLine("Bledny format timespan " +t);
            Wynik w = new Wynik();
            w.span = tspan;
            w.typ = 5;
            return w;
        }

        public Wynik ZwrocWynik()
        {
            return wynik;
        }

        private int RodzajDzialania(int a,int b)
        {
            if (a != 5 && b != 5) return 1;
            else if (a == 5 && b == 5) return 2;
            else if (a != 5 && b == 5) return 3;
            else if (a == 5 && b != 5) return 4;
            else return -1;
        }
    }
}