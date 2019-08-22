using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Repository;
using JooleDAL;

namespace JooleRepository.Repository
{
    public interface ITypeSpecRepo : IRepository<tblType>
    {
    }
    public class TypeSpecRepo : Repository<tblType>, ITypeSpecRepo
    {
        public TypeSpecRepo(DbContext context) : base(context)
        {
        }
    }
}
