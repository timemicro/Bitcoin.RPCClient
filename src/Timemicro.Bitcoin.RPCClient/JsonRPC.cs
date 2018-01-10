using System;
using Newtonsoft.Json;
using Timemicro.Bitcoin.RPCClient.Methods;

namespace Timemicro.Bitcoin.RPCClient
{
    public static class JsonRPC
    {
        public static Resp Call<Resp>(this JsonRPCClient client, string method, params object[] parameters)
        {
            string responseText = client.Call(method, parameters);

            return JsonConvert.DeserializeObject<Resp>(responseText);
        }
    }
}
