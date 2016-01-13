public class BuildTask
{

	// Methods
	public string[] GetParameterNames() {}
	public string GetParameterValue(string attributeName) {}
	public void SetParameterValue(string parameterName, string parameterValue, bool treatParameterValueAsLiteral) {}
	public void SetParameterValue(string parameterName, string parameterValue) {}
	public void AddOutputItem(string taskParameter, string itemName) {}
	public void AddOutputProperty(string taskParameter, string propertyName) {}
	public bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Condition { get{} set{} }
	public bool ContinueOnError { get{} set{} }
	public Type Type { get{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

