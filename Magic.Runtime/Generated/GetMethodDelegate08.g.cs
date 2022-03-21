// this file was generated by Magic.Runtime.Callsites -- do not edit it by hand!
using System;
using System.Reflection;

namespace Magic
{
    public static partial class DelegateHelpers
    {
        public static CallsiteFunc<object, object, object, object, object, object, object, object, object> GetMethodDelegate08(MethodBase method)
        {
            var returnType = ((MethodInfo)method).ReturnType;
            if(returnType == typeof(void))
                returnType = typeof(object);
            var getDelegateOpenGenerics = typeof(DelegateHelpers).GetMethod(nameof(GetMethodDelegateFast08), BindingFlags.Public | BindingFlags.Static);
            MethodInfo getDelegateClosedGenerics = null;
            if (method.IsStatic)
            {
                getDelegateClosedGenerics = getDelegateOpenGenerics.MakeGenericMethod(method.GetParameters()[0].ParameterType,method.GetParameters()[1].ParameterType,method.GetParameters()[2].ParameterType,method.GetParameters()[3].ParameterType,method.GetParameters()[4].ParameterType,method.GetParameters()[5].ParameterType,method.GetParameters()[6].ParameterType,method.GetParameters()[7].ParameterType,returnType);
            }
            else
            {
                getDelegateClosedGenerics = getDelegateOpenGenerics.MakeGenericMethod(method.DeclaringType, method.GetParameters()[0].ParameterType,method.GetParameters()[1].ParameterType,method.GetParameters()[2].ParameterType,method.GetParameters()[3].ParameterType,method.GetParameters()[4].ParameterType,method.GetParameters()[5].ParameterType,method.GetParameters()[6].ParameterType,returnType);
            }
            return (CallsiteFunc<object, object, object, object, object, object, object, object, object>)getDelegateClosedGenerics.Invoke(null, new object[] { method });
        }

        public static CallsiteFunc<object, object, object, object, object, object, object, object, object> GetMethodDelegateFast08<T0,T1,T2,T3,T4,T5,T6,T7,T8>(MethodInfo method)
        {
            if(!method.IsStatic && method.DeclaringType.IsValueType)
            {
                if(method.ReturnType == typeof(void))
                {
                    var f = (CallsiteActionRef<T0,T1,T2,T3,T4,T5,T6,T7>)Delegate.CreateDelegate(typeof(CallsiteActionRef<T0,T1,T2,T3,T4,T5,T6,T7>), method);
                    return (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => {
                        var target = (T0)arg0;
                        f(ref target,(T1)arg1,(T2)arg2,(T3)arg3,(T4)arg4,(T5)arg5,(T6)arg6,(T7)arg7);
                        return null;
                    };
                }
                else
                {
                    var f = (CallsiteFuncRef<T0,T1,T2,T3,T4,T5,T6,T7,T8>)Delegate.CreateDelegate(typeof(CallsiteFuncRef<T0,T1,T2,T3,T4,T5,T6,T7,T8>), method);
                    return (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => {
                        var target = (T0)arg0;
                        return f(ref target,(T1)arg1,(T2)arg2,(T3)arg3,(T4)arg4,(T5)arg5,(T6)arg6,(T7)arg7);
                    };
                }
            }
            else
            {
                if(method.ReturnType == typeof(void))
                {
                    var f = (CallsiteAction<T0,T1,T2,T3,T4,T5,T6,T7>)Delegate.CreateDelegate(typeof(CallsiteAction<T0,T1,T2,T3,T4,T5,T6,T7>), method);
                    return (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => {
                        f((T0)arg0,(T1)arg1,(T2)arg2,(T3)arg3,(T4)arg4,(T5)arg5,(T6)arg6,(T7)arg7);
                        return null;
                    };
                }
                else
                {
                    var f = (CallsiteFunc<T0,T1,T2,T3,T4,T5,T6,T7,T8>)Delegate.CreateDelegate(typeof(CallsiteFunc<T0,T1,T2,T3,T4,T5,T6,T7,T8>), method);
                    return (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => f((T0)arg0,(T1)arg1,(T2)arg2,(T3)arg3,(T4)arg4,(T5)arg5,(T6)arg6,(T7)arg7);
                }
            }
        }

        public static CallsiteFunc<object, object, object, object, object, object, object, object, object> GetMethodDelegateSlow08(MethodBase method)
        {
            CallsiteFunc<object, object, object, object, object, object, object, object, object> ret;
            if(method.IsStatic)
                ret = (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => 
                {
                    var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7 };
                    Binder.Shared.ConvertArguments(method, args);
                    return method.Invoke(null, args);
                };
            else if(method.IsConstructor)
                ret = (arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7) => 
                {
                    var ctor = method as ConstructorInfo;
                    var args = new[] { arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7 };
                    Binder.Shared.ConvertArguments(ctor, args);
                    return ctor.Invoke(args);
                };
            else
                ret = (target, arg1, arg2, arg3, arg4, arg5, arg6, arg7) => 
                {
                    var args = new [] { arg1,arg2,arg3,arg4,arg5,arg6,arg7 };
                    Binder.Shared.ConvertArguments(method, args);
                    return method.Invoke(target, args);
                };
            return ret;
        }

    }
}