public class BuildMessage : IBuildMessage
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public BuildMessageSeverity Severity { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public int HelpId { get{} }
}

