public class SourceSwitch : Switch
{

	// Constructors
	public SourceSwitch(string name) {}
	public SourceSwitch(string displayName, string defaultSwitchValue) {}

	// Methods
	public bool ShouldTrace(TraceEventType eventType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SourceLevels Level { get{} set{} }
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string DisplayName { get{} }
	public string Description { get{} }
}

