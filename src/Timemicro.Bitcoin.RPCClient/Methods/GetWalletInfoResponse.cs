using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetWalletInfoResponse : JsonRPCResponse<GetWalletInfoResult>
    {

    }

    public class GetWalletInfoResult
    {
        [JsonProperty("walletname")]
        public string WalletName { get; set; }

        [JsonProperty("walletversion")]
        public int WalletVersion { get; set; }

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public decimal Unconfirmed_Balance { get; set; }

        [JsonProperty("immature_balance")]
        public decimal Immature_Balance { get; set; }

        [JsonProperty("txcount")]
        public int TxCount { get; set; }

        [JsonProperty("keypoololdest")]
        public long KeyPoolOldest { get; set; }

        [JsonProperty("keypoolsize")]
        public int KeyPoolSize { get; set; }

        [JsonProperty("keypoolsize_hd_internal")]
        public int KeyPoolSize_HD_Internal { get; set; }

        [JsonProperty("unlocked_until")]
        public int Unlocked_Until { get; set; }

        [JsonProperty("paytxfee")]
        public decimal PayTxFee { get; set; }

        [JsonProperty("hdmasterkeyid")]
        public string HDMasterKeyId { get; set; }
    }
}
