public class TypeAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TypeAttributes VisibilityMask;
	public TypeAttributes NotPublic;
	public TypeAttributes Public;
	public TypeAttributes NestedPublic;
	public TypeAttributes NestedPrivate;
	public TypeAttributes NestedFamily;
	public TypeAttributes NestedAssembly;
	public TypeAttributes NestedFamANDAssem;
	public TypeAttributes NestedFamORAssem;
	public TypeAttributes LayoutMask;
	public TypeAttributes AutoLayout;
	public TypeAttributes SequentialLayout;
	public TypeAttributes ExplicitLayout;
	public TypeAttributes ClassSemanticsMask;
	public TypeAttributes Class;
	public TypeAttributes Interface;
	public TypeAttributes Abstract;
	public TypeAttributes Sealed;
	public TypeAttributes SpecialName;
	public TypeAttributes Import;
	public TypeAttributes Serializable;
	public TypeAttributes StringFormatMask;
	public TypeAttributes AnsiClass;
	public TypeAttributes UnicodeClass;
	public TypeAttributes AutoClass;
	public TypeAttributes CustomFormatClass;
	public TypeAttributes CustomFormatMask;
	public TypeAttributes BeforeFieldInit;
	public TypeAttributes ReservedMask;
	public TypeAttributes RTSpecialName;
	public TypeAttributes HasSecurity;
}

