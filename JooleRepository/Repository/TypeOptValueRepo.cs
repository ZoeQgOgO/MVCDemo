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
    public interface ITypeOptValueRepo : IRepository<tblType>
    {
    }
    public class TypeOptRepo : Repository<tblType>, ITypeOptValueRepo
    {
        public TypeOptRepo(DbContext context) : base(context)
        {
        }
    }
}
