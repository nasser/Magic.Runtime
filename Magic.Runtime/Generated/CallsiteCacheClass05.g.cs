// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;

namespace Magic
{
    public class CallSiteCache05
    {
        struct Signature
        {
            Type type0;
            Type type1;
            Type type2;
            Type type3;
            Type type4;
            
            public Signature(object arg0,object arg1,object arg2,object arg3,object arg4)
            {
                type0 = arg0.GetType();
                type1 = arg1.GetType();
                type2 = arg2.GetType();
                type3 = arg3.GetType();
                type4 = arg4.GetType();
            }

            public bool Match(Type arg0,Type arg1,Type arg2,Type arg3,Type arg4)
            {
                return object.ReferenceEquals(type0, arg0) && object.ReferenceEquals(type1, arg1) && object.ReferenceEquals(type2, arg2) && object.ReferenceEquals(type3, arg3) && object.ReferenceEquals(type4, arg4);
            }
        }

        struct Entry
        {
            public Signature Signature;
            public CallsiteFunc<object, object, object, object, object, object> Function;
        }
        int cacheSize;
        int count = 0;

        // l0l1Cache[0] is l0 cache, first entry checked
        // l0l1Cache[1..cacheSize] is l1 cache, looped through to find best match
        Entry[] l0l1Cache;

        public CallSiteCache05(int cacheSize)
        {
            this.cacheSize = cacheSize;
            l0l1Cache = new Entry[cacheSize];
        }

        public CallSiteCache05()
        {
            this.cacheSize = 9;
            l0l1Cache = new Entry[cacheSize];
        }

        public void CacheMethod(object arg0, object arg1, object arg2, object arg3, object arg4, CallsiteFunc<object, object, object, object, object, object> func)
        {
            var c = count < cacheSize ? count++ : count - 1;
            l0l1Cache[c] = new Entry { Signature = new Signature(arg0,arg1,arg2,arg3,arg4), Function = func };
            // CacheSwap(0, c);
            var temp = l0l1Cache[c];
            l0l1Cache[c] = l0l1Cache[0];
            l0l1Cache[0] = temp;
        }

        public bool TryGet(object arg0, object arg1, object arg2, object arg3, object arg4, out CallsiteFunc<object, object, object, object, object, object> result)
        {
            return TryGetInner(l0l1Cache, arg0.GetType(),arg1.GetType(),arg2.GetType(),arg3.GetType(),arg4.GetType(),out result);
        }

        bool TryGetInner(Entry[] l0l1Cache, Type arg0, Type arg1, Type arg2, Type arg3, Type arg4, out CallsiteFunc<object, object, object, object, object, object> result)
        {
            for (var i = 0; i < l0l1Cache.Length; i++)
            {
                if (i >= count) break;
                var entry = l0l1Cache[i];
                if (entry.Signature.Match(arg0,arg1,arg2,arg3,arg4))
                {
                    result = entry.Function;
                    if(i > 0)
                    {
                        // CacheSwap(0, i);
                        var temp = l0l1Cache[i];
                        l0l1Cache[i] = l0l1Cache[0];
                        l0l1Cache[0] = temp;
                    }
                    return true;
                }
            }
            result = default;
            return false;
        }
    }
}