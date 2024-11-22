using Bogus;
using MODEL.Entities;

namespace DAL.Data.FakeData
{
    public static class TeacherFakeData
    {
        public static List<Teacher> GetFakeTeachers(int count = 10)
        {
            var faker = new Faker<Teacher>()
                .RuleFor(t => t.ID, f => f.IndexFaker + 1)
                .RuleFor(t => t.Name, f => f.Name.FirstName())
                .RuleFor(t => t.Surname, f => f.Name.LastName())
                .RuleFor(t => t.Tckn, f => f.Random.String2(11, "0123456789"))
                .RuleFor(t => t.BirthDate, f => f.Date.Past(30, DateTime.Now.AddYears(-25)));

            return faker.Generate(count);
        }
    }
}
