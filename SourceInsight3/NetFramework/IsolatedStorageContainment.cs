public class IsolatedStorageContainment : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public IsolatedStorageContainment None;
	public IsolatedStorageContainment DomainIsolationByUser;
	public IsolatedStorageContainment ApplicationIsolationByUser;
	public IsolatedStorageContainment AssemblyIsolationByUser;
	public IsolatedStorageContainment DomainIsolationByMachine;
	public IsolatedStorageContainment AssemblyIsolationByMachine;
	public IsolatedStorageContainment ApplicationIsolationByMachine;
	public IsolatedStorageContainment DomainIsolationByRoamingUser;
	public IsolatedStorageContainment AssemblyIsolationByRoamingUser;
	public IsolatedStorageContainment ApplicationIsolationByRoamingUser;
	public IsolatedStorageContainment AdministerIsolatedStorageByUser;
	public IsolatedStorageContainment UnrestrictedIsolatedStorage;
}

