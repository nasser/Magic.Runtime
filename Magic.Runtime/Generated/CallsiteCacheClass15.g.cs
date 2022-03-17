// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;

namespace Magic
{
    public class CallSiteCache15
    {
        struct Signature
        {
            Type type0;
            Type type1;
            Type type2;
            Type type3;
            Type type4;
            Type type5;
            Type type6;
            Type type7;
            Type type8;
            Type type9;
            Type type10;
            Type type11;
            Type type12;
            Type type13;
            Type type14;
            
            public Signature(object arg0,object arg1,object arg2,object arg3,object arg4,object arg5,object arg6,object arg7,object arg8,object arg9,object arg10,object arg11,object arg12,object arg13,object arg14)
            {
                type0 = arg0.GetType();
                type1 = arg1.GetType();
                type2 = arg2.GetType();
                type3 = arg3.GetType();
                type4 = arg4.GetType();
                type5 = arg5.GetType();
                type6 = arg6.GetType();
                type7 = arg7.GetType();
                type8 = arg8.GetType();
                type9 = arg9.GetType();
                type10 = arg10.GetType();
                type11 = arg11.GetType();
                type12 = arg12.GetType();
                type13 = arg13.GetType();
                type14 = arg14.GetType();
            }

            public bool Match(object arg0,object arg1,object arg2,object arg3,object arg4,object arg5,object arg6,object arg7,object arg8,object arg9,object arg10,object arg11,object arg12,object arg13,object arg14)
            {
                return type0 == arg0.GetType() && type1 == arg1.GetType() && type2 == arg2.GetType() && type3 == arg3.GetType() && type4 == arg4.GetType() && type5 == arg5.GetType() && type6 == arg6.GetType() && type7 == arg7.GetType() && type8 == arg8.GetType() && type9 == arg9.GetType() && type10 == arg10.GetType() && type11 == arg11.GetType() && type12 == arg12.GetType() && type13 == arg13.GetType() && type14 == arg14.GetType();
            }
        }

        struct Entry
        {
            public Signature Signature;
            public CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> Function;
        }
        int cacheSize;
        int count = 0;

        // l0l1Cache[0] is l0 cache, first entry checked
        // l0l1Cache[1..cacheSize] is l1 cache, looped through to find best match
        Entry[] l0l1Cache;

        public CallSiteCache15(int cacheSize)
        {
            this.cacheSize = cacheSize;
            l0l1Cache = new Entry[cacheSize];
        }

        public CallSiteCache15()
        {
            this.cacheSize = 9;
            l0l1Cache = new Entry[cacheSize];
        }

        public void CacheMethod(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> func)
        {
            var c = count < cacheSize ? count++ : count - 1;
            l0l1Cache[c] = new Entry { Signature = new Signature(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11,arg12,arg13,arg14), Function = func };
            // CacheSwap(0, c);
            var temp = l0l1Cache[c];
            l0l1Cache[c] = l0l1Cache[0];
            l0l1Cache[0] = temp;
        }

        public bool TryGet(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, out CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> result)
        {
            for (var i = 0; i < count; i++)
            {
                var sig = l0l1Cache[i].Signature;
                var func = l0l1Cache[i].Function;
                if (sig.Match(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11,arg12,arg13,arg14))
                {
                    // CacheSwap(0, i);
                    var temp = l0l1Cache[i];
                    l0l1Cache[i] = l0l1Cache[0];
                    l0l1Cache[0] = temp;
                    result = func;
                    return true;
                }
            }
            result = default;
            return false;
        }
    }
}