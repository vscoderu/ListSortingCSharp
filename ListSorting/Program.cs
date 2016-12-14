﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> people = new List<string[]>();

            people.Add(new string[] { "Иван", "1980" });
            people.Add(new string[] { "Яна", "1987" });
            people.Add(new string[] { "Михаил", "1979" });
            people.Add(new string[] { "Анна", "1992" });

            OutputList(people, "Список до сортировки");

            NameComparer nc = new NameComparer();

            people.Sort(nc);

            OutputList(people, "Список после сортировки по длине имён");

            YearComparer yc = new YearComparer();

            people.Sort(yc);

            OutputList(people, "Список после сортировки по году рождения");
        }

        static void OutputList(List<string[]> list, string label)
        {
            Console.WriteLine(label);
            Console.WriteLine();

            foreach (string[] item in list)
                Console.WriteLine(item[0] + ", дата рождения: " + item[1]);

            Console.WriteLine();
        }


    }
}
