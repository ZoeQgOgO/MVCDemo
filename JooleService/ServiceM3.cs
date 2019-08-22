using JooleDAL;
using Joole.Repository;
using JooleRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace JooleService
{
        
    public partial class ServiceM3
    {
        public static readonly Joole_TeamEntities context = new Joole_TeamEntities();
        UnitOfWork uok = new UnitOfWork(context);
        protected readonly DbContext Context;
        public ServiceM3(DbContext context) {
            Context = context;
        }

        public ServiceM3()
        {
        }

        //search result
        //products list
        //get model year
        public List<tblProduct> GetModelyear()
        {
            List<tblProduct> model = new List<tblProduct>();
            var modelresult = uok.product.GetAll();
            foreach (var item in modelresult) {
                tblProduct mo = new tblProduct();
                mo.ProductID = item.ProductID;
                mo.ModelYear = item.ModelYear;
                model.Add(mo);
            }
            return model;
        }
        public List<tblType> GetProductType()
        {
            List<tblType> type = new List<tblType>();
            var typeresult = uok.type.GetAll();
            foreach (var item in typeresult)
            {      
                tblType tp = new tblType();
                tp.TypeID = item.TypeID;
                type.Add(tp);
    
            }
            return type;
        }
       
        
        //products technical specification for range slider value
        public List<tblTypeSpecValue> GetFilterValues()
        {
            List<tblTypeSpecValue> spec = new List<tblTypeSpecValue>();
            var specresult = uok.typespec.GetAll();
            foreach (var item in specresult)
            {
                tblTypeSpecValue sp = new tblTypeSpecValue();
                sp.TypeSpecID = item.TypeID;
                spec.Add(sp);
            }
            return spec;
        }

        public List<tblManufacturer> GetManuValue() {
            List<tblManufacturer> manu = new List<tblManufacturer>();
            var manuresult = uok.manufacturer.GetAll();
            foreach (var item in manuresult)
            {
                tblManufacturer m = new tblManufacturer();
                m.ManufacturerID = item.ManufacturerID;
                m.ManufacturerName = item.ManufacturerName;
                manu.Add(m);
            }
            return manu;
        }

        public List<tblProduct> GetProductValue() {
            List<tblProduct> pro = new List<tblProduct>();
            var proresult = uok.product.GetAll();
            foreach (var item in proresult)
            {
                tblProduct p = new tblProduct();
                p.ProductID = item.ProductID;
                p.ProductName = item.ProductName;
                pro.Add(p);

            }
            return pro;
        }


       

        public void Save()
        {
            throw new NotImplementedException();
        }

        //compare 
        public void Compare()
        {
            throw new NotImplementedException();
        }










    }
}
