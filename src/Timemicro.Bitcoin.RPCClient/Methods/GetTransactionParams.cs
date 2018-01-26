using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetTransactionParams : JsonRPCRequestParams
    {
        public string TxId { get { return Get<string>(0); } set { Set(0, value); } }
    }
}
