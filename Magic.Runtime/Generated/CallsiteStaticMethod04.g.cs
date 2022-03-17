// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteStaticMethod04
    {
        Type Target;
        string MemberName;
        CallSiteCache04 cache;

        public CallsiteStaticMethod04(Type target, string memberName)
        {
            Target = target;
            MemberName = memberName;
            cache = new CallSiteCache04();
        }

        public object Invoke(object arg0,object arg1,object arg2,object arg3)
        {
            if(cache.TryGet(arg0,arg1,arg2,arg3, out var result))
                return result(arg0,arg1,arg2,arg3);

            var method = (MethodInfo)Dispatch.BindToMethod(BindingFlags.Public | BindingFlags.Instance, Target, MemberName, new [] { arg0,arg1,arg2,arg3 });
            if (method != null)
            {
                cache.CacheMethod(arg0,arg1,arg2,arg3, DelegateHelpers.GetMethodDelegate04(method));
                var args = new[] { arg0,arg1,arg2,arg3 };
                Binder.Shared.ConvertArguments(method, args);
                return Dispatch.InvokeUnwrappingExceptions(method, null, args);
            }
            throw new ArgumentException($"Could not invoke static method `{MemberName}` on type {Target} with argument types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}.");
        }
    }
}