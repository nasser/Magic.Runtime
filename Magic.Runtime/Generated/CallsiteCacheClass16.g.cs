// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;

namespace Magic
{
    public class CallSiteCache16
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
            Type type15;
            
            public Signature(object arg0,object arg1,object arg2,object arg3,object arg4,object arg5,object arg6,object arg7,object arg8,object arg9,object arg10,object arg11,object arg12,object arg13,object arg14,object arg15)
            {
                type0 = arg0 == null ? typeof(object) : arg0.GetType();
                type1 = arg1 == null ? typeof(object) : arg1.GetType();
                type2 = arg2 == null ? typeof(object) : arg2.GetType();
                type3 = arg3 == null ? typeof(object) : arg3.GetType();
                type4 = arg4 == null ? typeof(object) : arg4.GetType();
                type5 = arg5 == null ? typeof(object) : arg5.GetType();
                type6 = arg6 == null ? typeof(object) : arg6.GetType();
                type7 = arg7 == null ? typeof(object) : arg7.GetType();
                type8 = arg8 == null ? typeof(object) : arg8.GetType();
                type9 = arg9 == null ? typeof(object) : arg9.GetType();
                type10 = arg10 == null ? typeof(object) : arg10.GetType();
                type11 = arg11 == null ? typeof(object) : arg11.GetType();
                type12 = arg12 == null ? typeof(object) : arg12.GetType();
                type13 = arg13 == null ? typeof(object) : arg13.GetType();
                type14 = arg14 == null ? typeof(object) : arg14.GetType();
                type15 = arg15 == null ? typeof(object) : arg15.GetType();
            }

            public bool Match(Type arg0,Type arg1,Type arg2,Type arg3,Type arg4,Type arg5,Type arg6,Type arg7,Type arg8,Type arg9,Type arg10,Type arg11,Type arg12,Type arg13,Type arg14,Type arg15)
            {
                return object.ReferenceEquals(type0, arg0) && object.ReferenceEquals(type1, arg1) && object.ReferenceEquals(type2, arg2) && object.ReferenceEquals(type3, arg3) && object.ReferenceEquals(type4, arg4) && object.ReferenceEquals(type5, arg5) && object.ReferenceEquals(type6, arg6) && object.ReferenceEquals(type7, arg7) && object.ReferenceEquals(type8, arg8) && object.ReferenceEquals(type9, arg9) && object.ReferenceEquals(type10, arg10) && object.ReferenceEquals(type11, arg11) && object.ReferenceEquals(type12, arg12) && object.ReferenceEquals(type13, arg13) && object.ReferenceEquals(type14, arg14) && object.ReferenceEquals(type15, arg15);
            }
        }

        struct Entry
        {
            public Signature Signature;
            public CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> Function;
        }
        int cacheSize;
        int count = 0;

        // l0l1Cache[0] is l0 cache, first entry checked
        // l0l1Cache[1..cacheSize] is l1 cache, looped through to find best match
        Entry[] l0l1Cache;

        public CallSiteCache16(int cacheSize)
        {
            this.cacheSize = cacheSize;
            l0l1Cache = new Entry[cacheSize];
        }

        public CallSiteCache16()
        {
            this.cacheSize = 9;
            l0l1Cache = new Entry[cacheSize];
        }

        public void CacheMethod(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> func)
        {
            var c = count < cacheSize ? count++ : count - 1;
            l0l1Cache[c] = new Entry { Signature = new Signature(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11,arg12,arg13,arg14,arg15), Function = func };
            // CacheSwap(0, c);
            var temp = l0l1Cache[c];
            l0l1Cache[c] = l0l1Cache[0];
            l0l1Cache[0] = temp;
        }

        public bool TryGet(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, out CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> result)
        {
            return TryGetInner(l0l1Cache, arg0 == null ? typeof(object) : arg0.GetType(),arg1 == null ? typeof(object) : arg1.GetType(),arg2 == null ? typeof(object) : arg2.GetType(),arg3 == null ? typeof(object) : arg3.GetType(),arg4 == null ? typeof(object) : arg4.GetType(),arg5 == null ? typeof(object) : arg5.GetType(),arg6 == null ? typeof(object) : arg6.GetType(),arg7 == null ? typeof(object) : arg7.GetType(),arg8 == null ? typeof(object) : arg8.GetType(),arg9 == null ? typeof(object) : arg9.GetType(),arg10 == null ? typeof(object) : arg10.GetType(),arg11 == null ? typeof(object) : arg11.GetType(),arg12 == null ? typeof(object) : arg12.GetType(),arg13 == null ? typeof(object) : arg13.GetType(),arg14 == null ? typeof(object) : arg14.GetType(),arg15 == null ? typeof(object) : arg15.GetType(),out result);
        }

        bool TryGetInner(Entry[] l0l1Cache, Type arg0, Type arg1, Type arg2, Type arg3, Type arg4, Type arg5, Type arg6, Type arg7, Type arg8, Type arg9, Type arg10, Type arg11, Type arg12, Type arg13, Type arg14, Type arg15, out CallsiteFunc<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> result)
        {
            for (var i = 0; i < l0l1Cache.Length; i++)
            {
                if (i >= count) break;
                var entry = l0l1Cache[i];
                if (entry.Signature.Match(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11,arg12,arg13,arg14,arg15))
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