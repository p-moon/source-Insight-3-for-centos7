public class EventBuilder : System.Runtime.InteropServices._EventBuilder
{

	// Methods
	public EventToken GetEventToken() {}
	public void SetAddOnMethod(MethodBuilder mdBuilder) {}
	public void SetRemoveOnMethod(MethodBuilder mdBuilder) {}
	public void SetRaiseMethod(MethodBuilder mdBuilder) {}
	public void AddOtherMethod(MethodBuilder mdBuilder) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

