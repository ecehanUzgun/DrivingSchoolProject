using Bogus;
using MODEL.Entities;
using MODEL.Enums;

namespace DAL.Data.FakeData
{
    public static class StudentFakeData
    {
        public static List<Student> GetFakeStudents(int count = 20)
        {
            var faker = new Faker<Student>()
                .RuleFor(s => s.ID, f => f.IndexFaker + 1)
                .RuleFor(s => s.Name, f => f.Name.FirstName())
                .RuleFor(s => s.Surname, f => f.Name.LastName())
                .RuleFor(s => s.Tckn, f => f.Random.String2(11, "0123456789"))
                .RuleFor(s => s.BirthDate, f => f.Date.Past(20, DateTime.Now.AddYears(-18)))
                .RuleFor(s => s.CourseHours, f => 6) // Varsayılan ders hakkı
                .RuleFor(s => s.Status, f => MODEL.Enums.DataStatus.Active)
                .RuleFor(s => s.BranchId, f => f.Random.Number(1, 5)); // BranchId 1 ile 5 arasında olmalı

            return faker.Generate(count);
        }
    }
}
