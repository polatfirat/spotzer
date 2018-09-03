using log4net;
using Newtonsoft.Json;
using SpotzerAPI.Utilities;
using SpotzerBusiness;
using SpotzerException;
using SpotzerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpotzerAPI.Controllers
{
    public class ApplyOrderController : ApiController
    {

        private static readonly ILog logInterface = new SpotzerLogging.Logger().LoggerInitializer(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private SpotzerLogging.Logger log = new SpotzerLogging.Logger();
        [HttpPost]
        public HttpResponseMessage Post([FromBody] PartnerOrderModel partnerOrder)
        {
            try
            {
                log.RequestLog(logInterface, Newtonsoft.Json.JsonConvert.SerializeObject(partnerOrder));

                if (ModelState.IsValid == false)
                {
                    log.ValidationErrorLog(logInterface, Utils.ModelStateToString(ModelState));
                    return Request.CreateResponse(HttpStatusCode.BadRequest, Utils.ModelStateToString(ModelState));
                }
                else
                {
                    SpotzerBusiness.ApplyOrderFactory orderFactory = new SpotzerBusiness.ApplyOrderFactory();
                    IApplyOrder order = orderFactory.ApplyOrder(partnerOrder.Partner);

                    SpotzerOrderCheckError checkResult = order.CheckOrder(partnerOrder);
                    if (checkResult == null)
                    {
                        object orderResult = order.ApplyOrder(partnerOrder);
                        log.ResponseLog(logInterface, Newtonsoft.Json.JsonConvert.SerializeObject(orderResult));
                        return Request.CreateResponse(HttpStatusCode.OK, orderResult);
                    }
                    else
                    {
                        log.ResponseLog(logInterface, Newtonsoft.Json.JsonConvert.SerializeObject(checkResult));
                        return Request.CreateResponse(HttpStatusCode.BadRequest, checkResult);
                    }
                }


            }

            catch (System.Exception ex)
            {
                log.ErrorLog(logInterface, "API Method Error : ", ex);
                throw new SpotzerException.SpotzerEx("API Method Error : ", ex);
            }

        }
    }
}
