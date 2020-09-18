using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturerApp.Models
{
    public interface IManufacturerRepository
    {
        Task<Manufacturer> AddManufacturer(Manufacturer manufacturer);
        Task<List<Manufacturer>> GetManufacturers();
        Task<Manufacturer> GetManufacturer(int id);
        Task<Manufacturer> EditManufacturer(Manufacturer manufacturer);
        Task DeleteManufacturer(int id);
    }

}
