public class InstanceDescriptor
{

	// Constructors
	public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments) {}
	public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete) {}

	// Methods
	public object Invoke() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection Arguments { get{} }
	public bool IsComplete { get{} }
	public System.Reflection.MemberInfo MemberInfo { get{} }
}

