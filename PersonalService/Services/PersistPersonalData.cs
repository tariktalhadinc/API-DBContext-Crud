namespace PersonalService.Services;

public static class PersistPersonalData
{
    public static List<Personal> personals = new()
    {
        new Personal
        {
            Id = 1,
            NationalId = "13595581052",
            Name = "Tarık Talha",
            Surname = "DİNÇ",
            Age = 20,
            Salary = 5500,
        },

        new Personal
        {
            Id = 2,
            NationalId = "13595581054",
            Name = "Görkem",
            Surname = "Tekin",
            Age = 20,
            Salary = 7500,
        }
    };
}