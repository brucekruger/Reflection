using System.Reflection;

namespace Reflection
{
    internal static class ReflectionExtensions
    {
        // Helper extension method to simplify syntax to create a delegate
        public static TDelegate CreateDelegate<TDelegate>(this MethodInfo mi, object target = null)
            => (TDelegate)(object)mi.CreateDelegate(typeof(TDelegate), target);
    }
}
