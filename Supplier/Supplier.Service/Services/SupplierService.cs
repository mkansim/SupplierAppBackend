using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supplier.Data;

namespace Supplier.Service.Services
{
    public class SupplierService : ISupplierService
    {
        private SupplierDBEntities1 database = new SupplierDBEntities1();
        public supplier GetSupplier(string name)
        {
            return database.suppliers.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

        public List<supplier> GetSuppliers()
        {
            return database.suppliers.ToList();
        }

        public void AddSupplier(supplier supplierEntity)
        {
            database.suppliers.Add(supplierEntity);
            database.SaveChanges();
        }
    }
}