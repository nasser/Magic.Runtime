// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public class CallsiteConstructor12<T>
    {
        CallSiteCache12 cache;

        public CallsiteConstructor12()
        {
            cache = new CallSiteCache12();
        }

        public T Invoke(object arg0,object arg1,object arg2,object arg3,object arg4,object arg5,object arg6,object arg7,object arg8,object arg9,object arg10,object arg11)
        {
            if(cache.TryGet(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11, out var result))
                return (T)result(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11);

            var ctor = Dispatch.BindToConstructor(typeof(T), new [] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11 });
            if (ctor != null)
            {
                cache.CacheMethod(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11, DelegateHelpers.GetMethodDelegate12(ctor));
                var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10,arg11 };
                Binder.Shared.ConvertArguments(ctor, args);
                return (T)Dispatch.InvokeUnwrappingExceptions(ctor, null, args);
            }
            throw new ArgumentException($"Could not invoke constructor `{typeof(T)}` with types {arg0.GetType()}, {arg1.GetType()}, {arg2.GetType()}, {arg3.GetType()}, {arg4.GetType()}, {arg5.GetType()}, {arg6.GetType()}, {arg7.GetType()}, {arg8.GetType()}, {arg9.GetType()}, {arg10.GetType()}, {arg11.GetType()}.");
        }
    }
}