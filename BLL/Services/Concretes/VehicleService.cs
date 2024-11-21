using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class VehicleService : ServiceManager<Vehicle>, IVehicleService
    {
        public VehicleService(IRepository<Vehicle> repository) : base(repository)
        {
        }
    }
}
