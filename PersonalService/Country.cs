using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace PersonalService
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }



        private static List<Country> mockCountries = new List<Country>()
            {
                new Country()
                {
                    Id = 1,
                    City = "Istanbul",
                    Name = "Turkiye"
                },

                new Country()
                {
                    Id = 2,
                    City = "Paris",
                    Name = "Fransa"
                }
            };
    }
}
