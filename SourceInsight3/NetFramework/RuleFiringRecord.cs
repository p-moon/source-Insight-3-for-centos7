public class RuleFiringRecord
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime LastFired { get{} }
	public int TimesRaised { get{} }
}

