public class TraceSwitch : Switch
{

	// Constructors
	public TraceSwitch(string displayName, string description) {}
	public TraceSwitch(string displayName, string description, string defaultSwitchValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TraceLevel Level { get{} set{} }
	public bool TraceError { get{} }
	public bool TraceWarning { get{} }
	public bool TraceInfo { get{} }
	public bool TraceVerbose { get{} }
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string DisplayName { get{} }
	public string Description { get{} }
}

