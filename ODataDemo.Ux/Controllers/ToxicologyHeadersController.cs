using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using ODataServiceDemo.Entities;

namespace ODataDemo.Ux.Controllers
{
    public class ToxicologyHeadersController : EntitySetController<tbluaresult, int>
    {
        ODataTestEntities db = new ODataTestEntities();

        [Queryable]
        public override IQueryable<tbluaresult> Get()
        {
            return db.tbluaresults;
        }

        protected override tbluaresult GetEntityByKey(int key)
        {
            return db.tbluaresults.SingleOrDefault(u => u.uarID == key);
        }

        protected override int GetKey(tbluaresult entity)
        {
            return entity.uarID;
        }

        [Queryable]
        public IQueryable<tbluaresultdetail> Gettbluaresultdetails([FromODataUri] int key)
        {
            tbluaresult header = db.tbluaresults.FirstOrDefault(p => p.uarID == key);

            if (header == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return db.tbluaresultdetails.Where(a=> a.uardRecID == key);
        }
    }
}
