using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Notificator
{

    /// <summary>
    /// A wrapper class for a Http.StringContent, which serializes an input object on the fly.
    /// </summary>
    public class JsonContent : StringContent
    {
        public JsonContent(object obj) :
        base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
        { }
    }
}
