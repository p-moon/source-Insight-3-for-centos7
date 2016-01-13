public class CommandLineBuilder
{

	// Constructors
	public CommandLineBuilder() {}

	// Methods
	public virtual string ToString() {}
	public void AppendFileNameIfNotNull(string fileName) {}
	public void AppendFileNameIfNotNull(Microsoft.Build.Framework.ITaskItem fileItem) {}
	public void AppendFileNamesIfNotNull(string[] fileNames, string delimiter) {}
	public void AppendFileNamesIfNotNull(Microsoft.Build.Framework.ITaskItem[] fileItems, string delimiter) {}
	public void AppendSwitch(string switchName) {}
	public void AppendSwitchIfNotNull(string switchName, string parameter) {}
	public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) {}
	public void AppendSwitchIfNotNull(string switchName, string[] parameters, string delimiter) {}
	public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) {}
	public void AppendSwitchUnquotedIfNotNull(string switchName, string parameter) {}
	public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) {}
	public void AppendSwitchUnquotedIfNotNull(string switchName, string[] parameters, string delimiter) {}
	public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

