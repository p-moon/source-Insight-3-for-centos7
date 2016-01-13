public interface IBuildMessage
{

	// Properties
	public BuildMessageSeverity Severity { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public int HelpId { get{} }
}

