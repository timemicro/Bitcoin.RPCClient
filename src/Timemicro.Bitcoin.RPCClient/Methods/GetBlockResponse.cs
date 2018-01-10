using System;
using System.Collections.Generic;
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

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("strippedsize")]
        public int StrippedSize { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("versionHex")]
        public string VersionHex { get; set; }

        [JsonProperty("merkleroot")]
        public string MerkleRoot { get; set; }

        [JsonProperty("tx")]
        public List<string> Tx { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("mediantime")]
        public long MedianTime { get; set; }

        [JsonProperty("nonce")]
        public long Nonce { get; set; }

        [JsonProperty("bits")]
        public string Bits { get; set; }

        [JsonProperty("difficulty")]
        public double Difficulty { get; set; }

        [JsonProperty("chainwork")]
        public string ChainWork { get; set; }

        [JsonProperty("previousblockhash")]
        public string PreviousBlockHash { get; set; }

        [JsonProperty("nextblockhash")]
        public string NextBlockHash { get; set; }
    }
}
