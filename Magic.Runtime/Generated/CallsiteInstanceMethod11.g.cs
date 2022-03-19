// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteInstanceMethod11
    {
        string MemberName;
        CallSiteCache12 cache;

        public CallsiteInstanceMethod11(string memberName)
        {
            MemberName = memberName;
            cache = new CallSiteCache12();
        }

        public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10)
        {
            if(cache.TryGet(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, out var result))
                return result(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

            var method = Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, target.GetType(), MemberName, new [] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10 });
            if (method != null)
            {
                var f = DelegateHelpers.GetMethodDelegate12(method);
                cache.CacheMethod(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, f);
                return f(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
            throw new ArgumentException($"Could not invoke instance member method `{MemberName}` on target {target.ToString()} ({target.GetType()}) with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}, {arg4.GetType()}, {arg5.GetType()}, {arg6.GetType()}, {arg7.GetType()}, {arg8.GetType()}, {arg9.GetType()}, {arg10.GetType()}.");
        }

    }
}