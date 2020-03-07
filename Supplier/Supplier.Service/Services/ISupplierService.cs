using Supplier.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplier.Service.Services
{
    public interface ISupplierService
    {
        List<supplier> GetSuppliers();
        supplier GetSupplier(string name);
        void AddSupplier(supplier supplierEntity);
    }
}
