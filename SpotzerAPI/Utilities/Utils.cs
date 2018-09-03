using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace SpotzerAPI.Utilities
{
    public static class Utils
    {
        private static readonly ILog logInterface = new SpotzerLogging.Logger().LoggerInitializer(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static string ModelStateToString(ModelStateDictionary modelState)
        {
            try
            {
                var errors = new List<string>();
                foreach (var modelStateVal in modelState.Values.Select(d => d.Errors))
                {
                    errors.AddRange(modelStateVal.Select(error => error.ErrorMessage));
                }
                return string.Join(",", errors);
            }
            catch (System.Exception ex)
            {
                new SpotzerLogging.Logger().ErrorLog(logInterface, "ModelStateToString Error : ", ex);
                throw new SpotzerException.SpotzerEx("ModelStateToString Error : ", ex);
            }
            
        }
    }
}