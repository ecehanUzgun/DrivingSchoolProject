using Bogus;
using MODEL.Entities;

namespace DAL.Data.FakeData
{
    public static class BranchFakeData
    {
        public static List<Branch> GetFakeBranches(int count = 5)
        {
            var faker = new Faker<Branch>()
                .RuleFor(b => b.ID, f => f.IndexFaker + 1)
                .RuleFor(b => b.Name, f => f.Company.CompanyName())
                .RuleFor(b => b.Address, f => f.Address.FullAddress())
                .RuleFor(b => b.PhoneNumber, f => f.Phone.PhoneNumber("##########")); // 10 haneli telefon numarası

            return faker.Generate(count);
        }
    }
}
