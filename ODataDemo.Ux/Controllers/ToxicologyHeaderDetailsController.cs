using ODataDemo.Ux.Models;
using ODataServiceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Mvc;

namespace ODataDemo.Ux.Controllers
{
    public class ToxicologyHeaderDetailsController : EntitySetController<ToxicologyHeaderDetails, int>
    {

        ODataTestEntities db = new ODataTestEntities();

        private IQueryable<ToxicologyHeaderDetails> GetHeaderWithDetails()
        {
            return from header in db.tbluaresults
                      join detail in db.tbluaresultdetails on header.uarID equals detail.uardRecID
                      select new ToxicologyHeaderDetails()
                      {
                          uarID = header.uarID,
                          uarLngCltID = header.uarLngCltID,
                          uarSchedID = header.uarSchedID,
                          uarDropDt = header.uarDropDt,
                          uarResultDt = header.uarResultDt,
                          uarCreatedBy = header.uarCreatedBy,
                          uarCreatedDt = header.uarCreatedDt,
                          uardID = detail.uardID,
                          uardRecID = detail.uardRecID,
                          uardResult = detail.uardResult,
                          uardRX = detail.uardRX,
                          uaDetail = detail.uaDetail
                      };
                   
        }

        [Queryable]
        public override IQueryable<ToxicologyHeaderDetails> Get()
        {
            return GetHeaderWithDetails();
        }
    }
}
