using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class SetTxFeeParams : JsonRPCRequestParams
    {
        public decimal TransactionFeePerKilobyte { get { return Get<decimal>(0); } set { Set(0, value); } }
    }
}
