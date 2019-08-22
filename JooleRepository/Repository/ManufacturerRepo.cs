using Joole.Repository;
using JooleDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleRepository.Repository
{
    public interface IManufacturerRepo : IRepository<tblManufacturer>
    {
    }
    public class ManufacturerRepo : Repository<tblManufacturer>, IManufacturerRepo
    {
        public ManufacturerRepo(DbContext context) : base(context)
        {
        }
    }
}
