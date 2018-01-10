using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetChainTipsResponse : JsonRPCResponse<List<ChainTip>>
    {
        public GetChainTipsResponse()
        {
        }
    }

    public class ChainTip
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("branchlen")]
        public int BranchLen { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public static class ChainTipStatus
    {
        public static string Active = "active";

        public static string Invalid = "invalid";

        public static string HeadersOnly = "headers-only";

        public static string ValidHeaders = "valid-headers";

        public static string ValidFork = "valid-fork";

        public static string Unknown = "unknown";

    }
}
