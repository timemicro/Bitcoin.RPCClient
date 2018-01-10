using System;
using Timemicro.Bitcoin.RPCClient;
using Timemicro.Bitcoin.RPCClient.Methods;

namespace TimemicroCore.Bitcoin.RPCClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(new GetBalanceParams() { Account = "mattf"});

            JsonRPCClient client = new JsonRPCClient("http://127.0.0.1:8332", "bitcoinrpc", "123456");

            var resp0 = client.Call<GetNewAddressResponse>(JsonRPCMethods.GetNewAddress, new GetNewAddressParams());
            Console.WriteLine(resp0);

            var resp1 = client.Call<GetBalanceResponse>(JsonRPCMethods.GetBalance, new GetBalanceParams());
            Console.WriteLine(resp1);

            var resp2 = client.Call<GetBestBlockHashResponse>(JsonRPCMethods.GetBestBlockHash, new GetBestBlockHashParams() );
            Console.WriteLine(resp2);

            var resp3 = client.Call<GetBlockResponse>(JsonRPCMethods.GetBlock, new GetBlockParams() { HeaderHash = resp2.Result });
            Console.WriteLine(resp3);

        }
    }
}
