public class ResourceType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public ResourceType Unknown;
	public ResourceType FileObject;
	public ResourceType Service;
	public ResourceType Printer;
	public ResourceType RegistryKey;
	public ResourceType LMShare;
	public ResourceType KernelObject;
	public ResourceType WindowObject;
	public ResourceType DSObject;
	public ResourceType DSObjectAll;
	public ResourceType ProviderDefined;
	public ResourceType WmiGuidObject;
	public ResourceType RegistryWow6432Key;
}

