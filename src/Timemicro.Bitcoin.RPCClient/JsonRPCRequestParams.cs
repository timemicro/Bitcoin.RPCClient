using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Timemicro.Bitcoin.RPCClient
{
    public class JsonRPCRequestParams : List<object>
    {
        public JsonRPCRequestParams()
        {
        }

        protected T Get<T>(int index)
        {
            if (Count < index + 1)
            {
                return default(T);
            }
            return (T)this[index];
        }

        protected object Get(int index)
        {
            if (Count < index + 1)
            {
                return null;
            }
            return this[index];
        }

        protected void Set(int index, object val)
        {
            if (Count < index + 1)
            {
                for (int i = 0; i < (index + 1); i++)
                {
                    Add(null);
                }
            }
            this[index] = val;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
