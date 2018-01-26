using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetTransactionResponse : JsonRPCResponse<GetTransactionResult>
    {

    }


    public class GetTransactionResult
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("generated")]
        public bool Generated { get; set; }

        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        [JsonProperty("blockindex")]
        public int BlockIndex { get; set; }

        [JsonProperty("blocktime")]
        public long BlockTime { get; set; }

        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("walletconflicts")]
        public List<string> WalletConflicts { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("timereceived")]
        public long Timereceived { get; set; }

        [JsonProperty("bip125-replaceable")]
        public string Bip125Replaceable { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("details")]
        public List<GetTransactionResultDetails> Details { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }
    }

    public class GetTransactionResultDetails
    {
        [JsonProperty("involvesWatchonly")]
        public bool? InvolvesWatchonly { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("vout")]
        public int VOut { get; set; }

        [JsonProperty("fee")]
        public decimal? Fee { get; set; }

        [JsonProperty("abandoned")]
        public bool Abandoned { get; set; }
    }
}
