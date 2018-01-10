using System;
using Timemicro.Bitcoin.RPCClient.Methods;

namespace TimemicroCore.Bitcoin.RPCClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(new GetBalanceParams() { Account = "mattf"});
        }
    }
}
