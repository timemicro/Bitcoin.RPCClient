using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class ListTransactionsResponse : JsonRPCResponse<List<Payment>>
    {

    }

    public class Payment
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("vout", NullValueHandling = NullValueHandling.Ignore)]
        public int VOut { get; set; }

        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Fee { get; set; }

        [JsonProperty("confirmations", NullValueHandling = NullValueHandling.Ignore)]
        public int Confirmations { get; set; }

        [JsonProperty("trusted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trusted { get; set; }

        [JsonProperty("generated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Generated { get; set; }

        [JsonProperty("blockhash", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockHash { get; set; }

        [JsonProperty("blockindex", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockIndex { get; set; }

        [JsonProperty("blocktime", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockTime { get; set; }

        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string TxId { get; set; }

        [JsonProperty("walletconflicts", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> WalletConflicts { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("timereceived", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeReceived { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        [JsonProperty("otheraccount", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherAccount { get; set; }

        [JsonProperty("bip125-replaceable")]
        public string BIP125Replaceable { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("abandoned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Abandoned { get; set; }
    }
}
