﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryMVCLab
{
    public class CountryView
    {
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public Country DisplayCountry { get; set; }
        public void Display()
        {
            string color = "";
            DisplayCountry.Colors.ForEach(x => color += x +", ");

            Console.WriteLine("\nName: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Color: " + color);
        }
    }
}
