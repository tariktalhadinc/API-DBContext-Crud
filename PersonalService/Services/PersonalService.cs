using PersonalService.Interfaces;

namespace PersonalService.Services;

public class PersonalService : IPersonalService
{
    public List<Personal> Get()
    {
        return PersistPersonalData.personals;
    }

    public Personal Search(string nationalId)
    {
        var personalList = PersistPersonalData.personals;

        var personal = personalList.Find(q => q.NationalId == nationalId);

        return personal;
    }

    public void Update(string nationalId)
    {
        var personalList = PersistPersonalData.personals;

        var personal = personalList.Find(q => q.NationalId == nationalId);

        personal.NationalId = nationalId;
    }

    public void Delete(int personalId)
    {
        var personalList = PersistPersonalData.personals;
        var personal = personalList.Find(q => q.Id == personalId);

        personalList.Remove(personal);
    }

    public void Add(Personal personal)
    {
        var personel = new Personal()
        {
            Age = 25,
            Name = "Tarik",
            Surname = "Talha",
            NationalId = "123123123123"
        };
        
        var tempPersonel = personal;
        
        var existingPersonal = PersistPersonalData.personals;
        tempPersonel.Id = existingPersonal.Count() + 1;
        existingPersonal.Add(tempPersonel);
    }
}