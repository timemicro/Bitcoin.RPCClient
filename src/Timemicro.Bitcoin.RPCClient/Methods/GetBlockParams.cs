using System;
namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetBlockParams : JsonRPCRequestParams
    {
        public GetBlockParams()
        {
        }

        public string HeaderHash { get { return Get<string>(0); } set { Set(0, value); } }

        public int Format { get { return Get<int>(1); } set { Set(1, value); } }
    }
}
