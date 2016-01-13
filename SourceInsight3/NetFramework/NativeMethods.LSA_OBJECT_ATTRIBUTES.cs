public class LSA_OBJECT_ATTRIBUTES
{

	// Constructors
	public LSA_OBJECT_ATTRIBUTES() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int length;
	public System.IntPtr rootDirectory;
	public System.IntPtr pointerLsaString;
	public int attributes;
	public System.IntPtr pointerSecurityDescriptor;
	public System.IntPtr pointerSecurityQualityOfService;
}

