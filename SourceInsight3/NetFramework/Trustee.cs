public class Trustee
{

	// Constructors
	public Trustee() {}
	public Trustee(string name) {}
	public Trustee(string name, string systemName) {}
	public Trustee(string name, string systemName, TrusteeType trusteeType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public string SystemName { get{} set{} }
	public TrusteeType TrusteeType { get{} set{} }
}

