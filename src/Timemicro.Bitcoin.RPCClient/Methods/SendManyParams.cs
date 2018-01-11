using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class SendManyParams : JsonRPCRequestParams
    {
        public string FromAccount { get { return Get<string>(0); } set { Set(0, value); } }

        public Dictionary<string, decimal> Outputs { get { return Get<Dictionary<string, decimal>>(1); } set { Set(1, value); } }

        public int Confirmations { get { return Get<int>(2); } set { Set(2, value); } }

        public string Comment { get { return Get<string>(3); } set { Set(3, value); } }

        public List<string> SubtractFeeFromAmount { get { return Get<List<string>>(4); } set { Set(4, value); } }
    }
}
