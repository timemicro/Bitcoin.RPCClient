using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetRawTransactionResponse : JsonRPCResponse<GetRawTransactionResult>
    {
    }

    public class GetRawTransactionResult
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("vsize")]
        public int VSize { get; set; }

        [JsonProperty("locktime")]
        public int LockTime { get; set; }

        [JsonProperty("vin")]
        public List<VIn> VIn { get; set; }

        [JsonProperty("vout")]
        public List<VOut> VOut { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("blocktime")]
        public long BlockTime { get; set; }
    }

    public class VIn
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }

        [JsonProperty("scriptSig")]
        public ScriptSig ScriptSig { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }

    public class VOut
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("n")]
        public int N { get; set; }

        [JsonProperty("scriptPubKey")]
        public ScriptPubKey ScriptPubKey { get; set; }
    }

    public class ScriptSig
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }
    }

    public class ScriptPubKey
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("reqSigs")]
        public int ReqSigs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }
    }
}
