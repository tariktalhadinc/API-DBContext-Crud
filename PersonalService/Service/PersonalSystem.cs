using System;
using PersonalService.Interfaces;

namespace PersonalService.Service
{
    public class PersonalSystem : IPersonalService
    {
        private static List<Personal> mockPersonal = new()
        {
           new Personal()
           {
               Id = 1,
               NationalId = "13595581052",
               Name = "Tarık Talha",
               Surname = "DİNÇ",
               Age = 20,
               Salary = 5500,
           },

           new Personal()
           {
               Id = 2,
               NationalId = "13595581054",
               Name = "Görkem",
               Surname = "Tekin",
               Age = 20,
               Salary = 7500,
           }
        };

        public List<Personal> Get()
        {
            return mockPersonal;
        }

        public Personal Search(string nationalId)
        {
            var PersonalList = mockPersonal;
            var Personal = PersonalList.Find(q => q.NationalId == nationalId);
            return Personal;
        }

        public bool Add(Personal personal)
        {
            var tempPersonel = personal;
            tempPersonel.Id = mockPersonal.Count() + 1;
            mockPersonal.Add(tempPersonel);
            return (true);
        }

        public Personal Update(Personal request)
        {
            var Personal = mockPersonal.Find(x => x.NationalId == request.NationalId);
            if (Personal == null)
                Personal.Id = request.Id;
            Personal.NationalId = request.NationalId;
            Personal.Name = request.Name;
            Personal.Surname = request.Surname;
            return (Personal);
        }

        public Personal Delete(Personal request)
        {
            var personalList = mockPersonal;
            var Personal = mockPersonal.Find(x => x.NationalId == request.NationalId);
            personalList.Remove(Personal);
            return (Personal);
        }
    }
}

