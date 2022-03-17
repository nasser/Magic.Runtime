// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System.Reflection;

namespace Magic
{
    public static partial class DelegateHelpers
    {
        public static CallsiteFunc<object, object, object, object, object, object, object, object> GetMethodDelegate07(MethodInfo method)
        {
            CallsiteFunc<object, object, object, object, object, object, object, object> ret;
            if(method.IsStatic)
                ret = (arg0,arg1,arg2,arg3,arg4,arg5,arg6) => 
                {
                    var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6 };
                    Binder.Shared.ConvertArguments(method, args);
                    return method.Invoke(null, args);
                };
            else
                ret = (target, arg1, arg2, arg3, arg4, arg5, arg6) => 
                {
                    var args = new [] { arg1,arg2,arg3,arg4,arg5,arg6 };
                    Binder.Shared.ConvertArguments(method, args);
                    return method.Invoke(target, args);
                };
            return ret;
        }

    }
}