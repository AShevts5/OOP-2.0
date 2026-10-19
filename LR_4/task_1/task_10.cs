using System;
using static System.Console;

namespace OOP_2
{
    class Task_10
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            string[] names = { "Шевцова А.В.", "Жуков Л.Н.", "Степачков Д.А." };

            try
            {
                // Первый способ
                Salary[] staff1 = new Salary[names.Length];
                for (int i = 0; i < names.Length; i++)
                {
                    double accrued = rnd.Next(40000, 150001);   
                    double other = rnd.Next(0, 5001);           

                    staff1[i] = new Salary(names[i], accrued);
                    staff1[i].Other = other;                    
                }

                WriteLine("\nПервый способ:");
                double total1 = 0;
                foreach (Salary s in staff1)
                {
                    WriteLine($"{s.Employee}: начислено {s.Accrued:F2}, налог {s.Tax:F2}, " +
                              $"прочие удержания {s.Other:F2}, выдается {s.NetSalary:F2} руб.");
                    total1 += s.NetSalary;
                }
                WriteLine($"Всего к выдаче: {total1:F2} руб.");

                // Второй способ 
                Salary2[] staff2 = new Salary2[names.Length];
                for (int i = 0; i < names.Length; i++)
                {
                    staff2[i] = new Salary2(names[i], staff1[i].Accrued);
                    staff2[i].SetOther(staff1[i].Other);
                }

                WriteLine("\nВторой способ:");
                double total2 = 0;
                foreach (Salary2 s in staff2)
                {
                    WriteLine($"{s.GetEmployee()}: начислено {s.GetAccrued():F2}, налог {s.GetTax():F2}, " +
                              $"прочие удержания {s.GetOther():F2}, на руки {s.GetNetSalary():F2} руб.");
                    total2 += s.GetNetSalary();
                }
                WriteLine($"Всего к выдаче: {total2:F2} руб.");
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в данных: {ex.Message}");
            }

        }
    }
}