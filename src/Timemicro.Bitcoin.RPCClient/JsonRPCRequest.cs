using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Timemicro.Bitcoin.RPCClient
{
    public class JsonRPCRequest
    {
        public JsonRPCRequest()
        {
            JsonRPC = "1.0";
            Id = Guid.NewGuid().ToString("N");
            Params = new object[]{};
        }

        public JsonRPCRequest(string method, List<object> parameters)
        {
            Method = method;
            Params = parameters.ToArray();
        }

        [JsonProperty("jsonrpc")]
        public string JsonRPC
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

        [JsonProperty("method")]
        public string Method
        {
            get;
            set;
        }

        [JsonProperty("params")]
        public object[] Params
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
