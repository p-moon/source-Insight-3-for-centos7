public class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>
{

	// Constructors
	public Version(int major, int minor, int build, int revision) {}
	public Version(int major, int minor, int build) {}
	public Version(int major, int minor) {}
	public Version(string version) {}
	public Version() {}

	// Methods
	public virtual object Clone() {}
	public virtual int CompareTo(object version) {}
	public virtual int CompareTo(Version value) {}
	public virtual bool Equals(object obj) {}
	public virtual bool Equals(Version obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public string ToString(int fieldCount) {}
	public static bool op_Equality(Version v1, Version v2) {}
	public static bool op_Inequality(Version v1, Version v2) {}
	public static bool op_LessThan(Version v1, Version v2) {}
	public static bool op_LessThanOrEqual(Version v1, Version v2) {}
	public static bool op_GreaterThan(Version v1, Version v2) {}
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) {}
	public Type GetType() {}

	// Properties
	public int Major { get{} }
	public int Minor { get{} }
	public int Build { get{} }
	public int Revision { get{} }
	public short MajorRevision { get{} }
	public short MinorRevision { get{} }
}

