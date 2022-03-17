// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteInstanceMethod06
    {
        string MemberName;
        CallSiteCache07 cache;

        public CallsiteInstanceMethod06(string memberName)
        {
            MemberName = memberName;
            cache = new CallSiteCache07();
        }

        public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            if(cache.TryGet(target, arg0, arg1, arg2, arg3, arg4, arg5, out var result))
                return result(target, arg0, arg1, arg2, arg3, arg4, arg5);

            var method = Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, target.GetType(), MemberName, new [] { arg0,arg1,arg2,arg3,arg4,arg5 });
            if (method != null)
            {
                cache.CacheMethod(target, arg0, arg1, arg2, arg3, arg4, arg5, DelegateHelpers.GetMethodDelegate07(method));
                var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5 };
                Binder.Shared.ConvertArguments(method, args);
                return Dispatch.InvokeUnwrappingExceptions(method, target, args);
            }
            throw new ArgumentException($"Could not invoke instance member method `{MemberName}` on target {target.ToString()} ({target.GetType()}) with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}, {arg4.GetType()}, {arg5.GetType()}.");
        }

    }
}