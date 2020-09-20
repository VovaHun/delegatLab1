using System;

namespace Lab1
{
    class Program
    {
      
        static void SM (Func<double,double> del, double summ,double mess)
        {
            Console.Write("Введите процентную ставку ->");
            double proc = Convert.ToDouble(Console.ReadLine());

            double coef = del(proc);

            double v = coef * Math.Pow(1 + coef, mess) / (Math.Pow(1 + coef, mess) - 1);

            double mes_pay = v * summ;

            Console.WriteLine("Ежемесячный платеж =" + Math.Round(mes_pay, 2));
        }
        
        static void Main(string[] args)
        {

            Console.Write("Введите сумму кредита ->");
            double summ = Convert.ToDouble(Console.ReadLine());


            Console.Write("Введите срок кредита (мес.) ->");
            double mes = Convert.ToDouble(Console.ReadLine());

           


            Func<double, double> del1 = x => {
                x = x / 12;
                x = x / 100;
                return x;
            };


            Action<Func<double, double>, double, double> del2 = SM;
            del2(del1, summ, mes);
                  
        }
    }
}
