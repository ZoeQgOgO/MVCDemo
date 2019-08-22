using Joole.Repository;
using JooleRepository.Repository;
using System;
using System.Data.Entity;

namespace JooleRepository
{
    public class UnitOfWork : IDisposable
    {
        DbContext Context;
     
        public IProductRepo product;
        public ITypeRepo type;
        public ITypeOptValueRepo typeopt;
        public ITypeSpecRepo typespec;
        public IManufacturerRepo manufacturer;


        public UnitOfWork(DbContext context)
        {
            this.Context = context;
           
            product = new ProductRepo(context);
            type = new TypeRepo(context);
            typeopt = new TypeOptRepo(context);
            typespec = new TypeSpecRepo(context);
            manufacturer = new ManufacturerRepo(context);

        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DisposeTest() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion

    }
}
