using System;
using Newtonsoft.Json;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetBlockResponse : JsonRPCResponse<GetBlockResponseResult>
    {
        public GetBlockResponse()
        {
        }
    }

    public class GetBlockResponseResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
