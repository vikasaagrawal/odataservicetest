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
    public class ToxicologyDetailsController : EntitySetController<tbluaresultdetail, int>
    {
        ODataTestEntities db = new ODataTestEntities();

        [Queryable]
        public override IQueryable<tbluaresultdetail> Get()
        {
            return db.tbluaresultdetails;
        }

        protected override int GetKey(tbluaresultdetail entity)
        {
            return entity.uardID;
        }

        protected override tbluaresultdetail GetEntityByKey(int key)
        {
            return db.tbluaresultdetails.SingleOrDefault(u => u.uardID == key);
        }

       
    }
}
