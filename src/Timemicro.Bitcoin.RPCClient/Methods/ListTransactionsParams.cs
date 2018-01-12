using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timemicro.Bitcoin.RPCClient.Methods
{
    public class ListTransactionsParams : JsonRPCRequestParams
    {
        public ListTransactionsParams()
        {
            Account = "*";
            TakeCount = 10;
            Skip = 0;
            IncludeWatchOnly = false;
        }

        public string Account { get { return Get<string>(0); } set { Set(0, value); } }

        public int TakeCount { get { return Get<int>(1); } set { Set(1, value); } }

        public int Skip { get { return Get<int>(2); } set { Set(2, value); } }

        public bool IncludeWatchOnly { get { return Get<bool>(3); } set { Set(3, value); } }
    }
}
