using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LIMEWareClient.Controllers
{
    public class ParameterController : ApiController
    {
        // GET: api/Parameter
        public IEnumerable<externalBalanceUpdateResponseActiveDataListDataBalance> Get()
        {
            var retValue = new externalBalanceUpdateResponseActiveDataListDataBalance[]
            {
                new externalBalanceUpdateResponseActiveDataListDataBalance {dataExpiry="1",    dataValue= 1241234,dataValueSpecified=true,sapcRetCode=1,sapcRetCodeSpecified=true},
                new externalBalanceUpdateResponseActiveDataListDataBalance {dataExpiry="2",    dataValue= 121563456,dataValueSpecified=true,sapcRetCode=1,sapcRetCodeSpecified=true},
                new externalBalanceUpdateResponseActiveDataListDataBalance {dataExpiry="3",    dataValue= 567546,dataValueSpecified=true,sapcRetCode=1,sapcRetCodeSpecified=true},
                new externalBalanceUpdateResponseActiveDataListDataBalance {dataExpiry="4",    dataValue= 1295876841234,dataValueSpecified=true,sapcRetCode=1,sapcRetCodeSpecified=true},
            };
            return retValue;
        }

        // GET: api/Parameter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Parameter
        public FlexibleRewardingTestClient.Parameters Post(FlexibleRewardingTestClient.Parameters param)
        {
            FlexibleRewardingTestClient.Proxy p = new FlexibleRewardingTestClient.Proxy(@"http://10.235.3.47:5004/MobileWebSvc");
            var r = p.externalBalanceUpdate(param);

            return param;
        }

        // PUT: api/Parameter/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Parameter/5
        public void Delete(int id)
        {

        }
    }
}
