public class TypeLibImporterFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TypeLibImporterFlags None;
	public TypeLibImporterFlags PrimaryInteropAssembly;
	public TypeLibImporterFlags UnsafeInterfaces;
	public TypeLibImporterFlags SafeArrayAsSystemArray;
	public TypeLibImporterFlags TransformDispRetVals;
	public TypeLibImporterFlags PreventClassMembers;
	public TypeLibImporterFlags SerializableValueClasses;
	public TypeLibImporterFlags ImportAsX86;
	public TypeLibImporterFlags ImportAsX64;
	public TypeLibImporterFlags ImportAsItanium;
	public TypeLibImporterFlags ImportAsAgnostic;
	public TypeLibImporterFlags ReflectionOnlyLoading;
}

