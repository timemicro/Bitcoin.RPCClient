using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class GetRawTransactionParams : JsonRPCRequestParams
    {
        public GetRawTransactionParams()
        {
            Format = 1;
        }

        public string TxId { get { return Get<string>(0); } set { Set(0, value); } }

        public int Format { get { return Get<int>(1); } set { Set(1, value); } }
    }
}
