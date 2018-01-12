using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class ListUnspentParams : JsonRPCRequestParams
    {
        public ListUnspentParams()
        {
            MinimumConfirmations = 1;
            MaximumConfirmations = 9999999;
        }

        public int MinimumConfirmations { get { return Get<int>(0); } set { Set(0, value); } }

        public int MaximumConfirmations { get { return Get<int>(1); } set { Set(1, value); } }

        public List<string> Addresses { get { return Get<List<string>>(2); } set { Set(2, value); } }
    }
}
