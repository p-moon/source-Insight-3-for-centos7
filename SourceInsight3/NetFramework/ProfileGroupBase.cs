public class ProfileGroupBase
{

	// Constructors
	public ProfileGroupBase() {}

	// Methods
	public object GetPropertyValue(string propertyName) {}
	public void SetPropertyValue(string propertyName, object propertyValue) {}
	public void Init(ProfileBase parent, string myName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
}

