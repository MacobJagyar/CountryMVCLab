using System;
namespace CountryMVCLab
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        public List<Country> Countries { get; set; }

        public void Display()
        {
            for (int i=0; i< Countries.Count(); i++)
            {
                Console.WriteLine($"{i+1} :  {Countries[i].Name}");
            }
        }
    }
}

