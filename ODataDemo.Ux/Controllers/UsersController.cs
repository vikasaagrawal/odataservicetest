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
    public class UsersController : EntitySetController<tbluser, int>
    {
        ODataTestEntities db = new ODataTestEntities();

        [Queryable]
        public override IQueryable<tbluser> Get()
        {
            return db.tblusers;
        }

        protected override tbluser GetEntityByKey(int key)
        {
            return db.tblusers.SingleOrDefault(u => u.Uskey == key);
        }
    }
}
