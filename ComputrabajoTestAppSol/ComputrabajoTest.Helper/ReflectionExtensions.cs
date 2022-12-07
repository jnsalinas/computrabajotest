using System;
using System.Reflection;

namespace ComputrabajoTest.Helper
{
    public static class ReflectionExtensions
    {
        public static bool IsInterface(this Type type)
        {
            return type.GetTypeInfo().IsInterface;
        }

        public static bool IsGenericType(this Type type)
        {
            return type.GetTypeInfo().IsGenericType;
        }

        public static MethodInfo[] GetMethod(this Type type)
        {
            return type.GetRuntimeMethods()
                .Where(m => m.IsPublic && !m.IsStatic)
                .ToArray();
        }

        public static Attribute[] GetCustomAttributes(this Type type, bool inherit)
        {
            return (Attribute[])type.GetTypeInfo().GetCustomAttributes(inherit).ToArray();

        }

        public static T GetCustomAttributeCurrentMethod<T>(this Type type, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "", bool inherit = false, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance) where T : Attribute
        {
            var m = type.GetMethod(MethodName, bindingFlags);
            return m.GetCustomAttribute<T>();
        }
        public static IEnumerable<T> GetCustomAttributesCurrentMethod<T>(this Type type, string MethodName, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance) where T : Attribute
        {
            var m = type.GetMethod(MethodName, bindingFlags);
            return m.GetCustomAttributes<T>();
        }

        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingFlags)
        {
            var isPublic = !bindingFlags.HasFlag(BindingFlags.NonPublic);
            var isStatic = bindingFlags.HasFlag(BindingFlags.Static);
            return type.GetRuntimeMethods()
                .Where(m => m.IsPublic == isPublic && m.IsStatic == isStatic)
                .FirstOrDefault(m => m.Name == name);
        }

        public static Type[] GetGenericArguments(this Type type)
        {
            return type.GetTypeInfo()
                .GenericTypeArguments;
        }

        public static PropertyInfo[] GetProperties(this Type type)
        {
            return type.GetRuntimeProperties()
                .Where(p => !p.GetMethod.IsStatic)
                .Where(p => p.GetMethod.IsPublic || p.SetMethod.IsPublic)
                .ToArray();
        }
    }

    [Flags]
    public enum BindingFlags
    {
        Instance = 0x4,
        Static = 0x8,
        Public = 0x10,
        NonPublic = 0x20
    }
}

