public class AxParameterData
{

	// Constructors
	public AxParameterData(string inname, string typeName) {}
	public AxParameterData(string inname, Type type) {}
	public AxParameterData(System.Reflection.ParameterInfo info) {}
	public AxParameterData(System.Reflection.ParameterInfo info, bool ignoreByRefs) {}

	// Methods
	public static AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos) {}
	public static AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos, bool ignoreByRefs) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.FieldDirection Direction { get{} }
	public bool IsByRef { get{} }
	public bool IsIn { get{} }
	public bool IsOut { get{} }
	public bool IsOptional { get{} }
	public string Name { get{} set{} }
	public Type ParameterType { get{} }
	public string TypeName { get{} }
}

