public class Delegate : ICloneable, System.Runtime.Serialization.ISerializable
{

	// Methods
	public object DynamicInvoke(object[] args) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public static Delegate Combine(Delegate a, Delegate b) {}
	public static Delegate Combine(Delegate[] delegates) {}
	public virtual Delegate[] GetInvocationList() {}
	public static Delegate Remove(Delegate source, Delegate value) {}
	public static Delegate RemoveAll(Delegate source, Delegate value) {}
	public virtual object Clone() {}
	public static Delegate CreateDelegate(Type type, object target, string method) {}
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) {}
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) {}
	public static Delegate CreateDelegate(Type type, Type target, string method) {}
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) {}
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) {}
	public static Delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) {}
	public static Delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) {}
	public static Delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) {}
	public static Delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) {}
	public static bool op_Equality(Delegate d1, Delegate d2) {}
	public static bool op_Inequality(Delegate d1, Delegate d2) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

