using System;

namespace Timemicro.Bitcoin.RPCClient
{
    public static class JsonRPCMethods
    {
        public static string GetBalance = "getbalance";

        public static string GetBestBlockHash = "getbestblockhash";

        public static string GetBlock = "getblock";

        public static string GetChainTips = "getchaintips";

        public static string GetNewAddress = "getnewaddress";

        public static string GetRawTransaction = "getrawtransaction";

        public static string SendMany = "sendmany";

        public static string SetTxFee = "settxfee";

        public static string WalletPassphrase = "walletpassphrase";
    }
}
