// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteInstanceMethod01
    {
        string MemberName;
        CallSiteCache02 cache;

        public CallsiteInstanceMethod01(string memberName)
        {
            MemberName = memberName;
            cache = new CallSiteCache02();
        }

        public object Invoke(object target, object arg0)
        {
            if(cache.TryGet(target, arg0, out var result))
                return result(target, arg0);

            var method = Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, target.GetType(), MemberName, new [] { arg0 });
            if (method != null)
            {
                var f = DelegateHelpers.GetMethodDelegate02(method);
                cache.CacheMethod(target, arg0, f);
                return f(target, arg0);
            }
            throw new ArgumentException($"Could not invoke instance member method `{MemberName}` on target {target.ToString()} ({target.GetType()}) with argument types {arg0.GetType()}.");
        }

    }
}