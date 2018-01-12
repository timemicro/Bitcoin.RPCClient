using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timemicro.Bitcoin.RPCClient.Methods;

namespace Timemicro.Bitcoin.RPCClient.MSUnitTests
{
    [TestClass]
    public class GetWalletInfoTest
    {
        static JsonRPCClient RPC = new JsonRPCClient("http://127.0.0.1:18332", "bitcoinrpc", "123456");

        [TestMethod]
        public void TestGetWalletInfo()
        {
            var resp = RPC.Call<GetWalletInfoResponse>(JsonRPCMethods.GetWalletInfo, new GetWalletInfoParams());

            Console.WriteLine(resp);
        }
    }
}
