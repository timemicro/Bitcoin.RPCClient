using System;
using Newtonsoft.Json;

namespace Timemicro.Bitcoin.RPCClient
{
    public class JsonRPCResponse<R>
    {
        public JsonRPCResponse()
        {
        }

        [JsonProperty("result")]
        public R Result
        {
            get;
            set;
        }

        [JsonProperty("error")]
        public JsonRPCResponseError Error
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
