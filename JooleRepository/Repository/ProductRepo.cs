using JooleDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repository
{
    public interface IProductRepo : IRepository<tblProduct>
    {
        
    }
    public class ProductRepo : Repository<tblProduct>, IProductRepo
    {
        public ProductRepo(DbContext context) : base(context)
        {
        }
    }
}