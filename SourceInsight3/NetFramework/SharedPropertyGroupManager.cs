public class SharedPropertyGroupManager : System.Collections.IEnumerable
{

	// Constructors
	public SharedPropertyGroupManager() {}

	// Methods
	public SharedPropertyGroup CreatePropertyGroup(string name, PropertyLockMode& dwIsoMode, PropertyReleaseMode& dwRelModeout , System.Boolean& fExist) {}
	public SharedPropertyGroup Group(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

