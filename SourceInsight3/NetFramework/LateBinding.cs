public class LateBinding
{

	// Constructors
	public LateBinding(string name) {}
	public LateBinding(string name, object obj) {}

	// Methods
	public object Call(object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) {}
	public static object CallValue(object thisob, object val, object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) {}
	public static object CallValue2(object val, object thisob, object[] arguments, bool construct, bool brackets, Microsoft.JScript.Vsa.VsaEngine engine) {}
	public bool Delete() {}
	public static bool DeleteMember(object obj, string name) {}
	public object GetNonMissingValue() {}
	public object GetValue2() {}
	public static void SetIndexedPropertyValueStatic(object obj, object[] arguments, object value) {}
	public void SetValue(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public object obj;
}

