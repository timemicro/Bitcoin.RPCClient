using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetBlockHashParams : JsonRPCRequestParams
    {
        public int BlockHeight { get { return Get<int>(0); } set { Set(0, value); } }
    }
}
