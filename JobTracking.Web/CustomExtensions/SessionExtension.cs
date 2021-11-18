using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Web.CustomExtensions
{
    public static class SessionExtension
    {
        //session nesnesi geliştirilerek object destekler 
        public static void SetObject(this ISession session,string key, object deger)
        {
            string gelenData = JsonConvert.SerializeObject(deger);
            session.SetString(key, gelenData);
        }
        public static object GetObject(this ISession session,string key)
        {
            var gelenData= session.GetString(key);
            if (gelenData != null)
            {
               return JsonConvert.DeserializeObject<object>(gelenData);
            }
            return null;
        }
    }
}
