using Supplier.Data;
using Supplier.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Supplier.WebApi.Controllers
{
    public class SupplierController : ApiController
    {
        private ISupplierService supplierService = new SupplierService();
        public IEnumerable<supplier> Get()
        {
            return supplierService.GetSuppliers();
        }

        /*
        public IHttpActionResult Get(string id)
        {
            var supplierFound =  supplierService.GetSupplier(id);
            if (supplierFound == null)
            {
                return NotFound();
            }
            return Ok(supplierFound);
        }*/

        public IHttpActionResult GetByName(string name)
        {
            var supplierFound = supplierService.GetSupplier(name);
            if (supplierFound == null)
            {
                return NotFound();
            }
            return Ok(supplierFound);
        }


        public HttpResponseMessage Post([FromBody] supplier supplierEntity)
        {
            try
            {
                supplierService.AddSupplier(supplierEntity);
                var message = Request.CreateResponse(HttpStatusCode.Created, supplierEntity);
                return message;
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            

        }
    }
}
