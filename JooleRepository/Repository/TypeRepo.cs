using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL;

namespace Joole.Repository
{
    public interface ITypeRepo : IRepository<tblType>
    {
    }
    public class TypeRepo : Repository<tblType>, ITypeRepo
    {
        public TypeRepo(DbContext context) : base(context)
        {
        }
    }
}