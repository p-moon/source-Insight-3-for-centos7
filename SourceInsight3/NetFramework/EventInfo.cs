public class EventInfo : MemberInfo, ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._EventInfo
{

	// Methods
	public virtual MethodInfo[] GetOtherMethods(bool nonPublic) {}
	public abstract virtual MethodInfo GetAddMethod(bool nonPublic) {}
	public abstract virtual MethodInfo GetRemoveMethod(bool nonPublic) {}
	public abstract virtual MethodInfo GetRaiseMethod(bool nonPublic) {}
	public MethodInfo[] GetOtherMethods() {}
	public virtual MethodInfo GetAddMethod() {}
	public virtual MethodInfo GetRemoveMethod() {}
	public virtual MethodInfo GetRaiseMethod() {}
	public virtual void AddEventHandler(object target, System.Delegate handler) {}
	public virtual void RemoveEventHandler(object target, System.Delegate handler) {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MemberTypes MemberType { get{} }
	public EventAttributes Attributes { get{} }
	public Type EventHandlerType { get{} }
	public bool IsSpecialName { get{} }
	public bool IsMulticast { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public int MetadataToken { get{} }
	public Module Module { get{} }
}

