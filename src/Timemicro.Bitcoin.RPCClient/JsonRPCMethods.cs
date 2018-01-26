using System;

namespace Timemicro.Bitcoin.RPCClient
{
    public static class JsonRPCMethods
    {
        public static string DumpPrivKey = "dumpprivkey";

        public static string GetBalance = "getbalance";

        public static string GetBestBlockHash = "getbestblockhash";

        public static string GetBlock = "getblock";

        public static string GetBlockHash = "getblockhash";

        public static string GetChainTips = "getchaintips";

        public static string GetNewAddress = "getnewaddress";

        public static string GetRawTransaction = "getrawtransaction";

        public static string GetTransaction = "gettransaction";

        public static string GetWalletInfo = "getwalletinfo";

        public static string ListTransactions = "listtransactions";

        public static string ListUnspent = "listunspent";

        public static string SendMany = "sendmany";

        public static string SetTxFee = "settxfee";

        public static string WalletPassphrase = "walletpassphrase";
    }
}
