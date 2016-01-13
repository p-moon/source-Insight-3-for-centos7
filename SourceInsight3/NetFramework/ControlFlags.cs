public class ControlFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ControlFlags None;
	public ControlFlags OwnerDefaulted;
	public ControlFlags GroupDefaulted;
	public ControlFlags DiscretionaryAclPresent;
	public ControlFlags DiscretionaryAclDefaulted;
	public ControlFlags SystemAclPresent;
	public ControlFlags SystemAclDefaulted;
	public ControlFlags DiscretionaryAclUntrusted;
	public ControlFlags ServerSecurity;
	public ControlFlags DiscretionaryAclAutoInheritRequired;
	public ControlFlags SystemAclAutoInheritRequired;
	public ControlFlags DiscretionaryAclAutoInherited;
	public ControlFlags SystemAclAutoInherited;
	public ControlFlags DiscretionaryAclProtected;
	public ControlFlags SystemAclProtected;
	public ControlFlags RMControlValid;
	public ControlFlags SelfRelative;
}

