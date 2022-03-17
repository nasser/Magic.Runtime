// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteInstanceMethod12
    {
        string MemberName;
        CallSiteCache13 cache;

        public CallsiteInstanceMethod12(string memberName)
        {
            MemberName = memberName;
            cache = new CallSiteCache13();
        }

        public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11)
        {
            if(cache.TryGet(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, out var result))
                return result(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

            var method = Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, target.GetType(), MemberName, new [] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11 });
            if (method != null)
            {
                cache.CacheMethod(target, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, DelegateHelpers.GetMethodDelegate13(method));
                var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11 };
                Binder.Shared.ConvertArguments(method, args);
                return Dispatch.InvokeUnwrappingExceptions(method, target, args);
            }
            throw new ArgumentException($"Could not invoke instance member method `{MemberName}` on target {target.ToString()} ({target.GetType()}) with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}, {arg4.GetType()}, {arg5.GetType()}, {arg6.GetType()}, {arg7.GetType()}, {arg8.GetType()}, {arg9.GetType()}, {arg10.GetType()}, {arg11.GetType()}.");
        }

    }
}