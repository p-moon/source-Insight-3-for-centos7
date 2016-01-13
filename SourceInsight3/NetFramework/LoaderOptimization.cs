public class LoaderOptimization : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public LoaderOptimization NotSpecified;
	public LoaderOptimization SingleDomain;
	public LoaderOptimization MultiDomain;
	public LoaderOptimization MultiDomainHost;
	public LoaderOptimization DomainMask;
	public LoaderOptimization DisallowBindings;
}

