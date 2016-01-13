public class BooleanSwitch : Switch
{

	// Constructors
	public BooleanSwitch(string displayName, string description) {}
	public BooleanSwitch(string displayName, string description, string defaultSwitchValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Enabled { get{} set{} }
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string DisplayName { get{} }
	public string Description { get{} }
}

