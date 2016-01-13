public class LogicalMethodInfo
{

	// Constructors
	public LogicalMethodInfo(System.Reflection.MethodInfo methodInfo) {}

	// Methods
	public virtual string ToString() {}
	public object[] Invoke(object target, object[] values) {}
	public System.IAsyncResult BeginInvoke(object target, object[] values, System.AsyncCallback callback, object asyncState) {}
	public object[] EndInvoke(object target, System.IAsyncResult asyncResult) {}
	public object[] GetCustomAttributes(Type type) {}
	public object GetCustomAttribute(Type type) {}
	public static bool IsBeginMethod(System.Reflection.MethodInfo methodInfo) {}
	public static bool IsEndMethod(System.Reflection.MethodInfo methodInfo) {}
	public static LogicalMethodInfo[] Create(System.Reflection.MethodInfo[] methodInfos) {}
	public static LogicalMethodInfo[] Create(System.Reflection.MethodInfo[] methodInfos, LogicalMethodTypes types) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type DeclaringType { get{} }
	public string Name { get{} }
	public System.Reflection.ParameterInfo AsyncResultParameter { get{} }
	public System.Reflection.ParameterInfo AsyncCallbackParameter { get{} }
	public System.Reflection.ParameterInfo AsyncStateParameter { get{} }
	public Type ReturnType { get{} }
	public bool IsVoid { get{} }
	public bool IsAsync { get{} }
	public System.Reflection.ParameterInfo[] InParameters { get{} }
	public System.Reflection.ParameterInfo[] OutParameters { get{} }
	public System.Reflection.ParameterInfo[] Parameters { get{} }
	public System.Reflection.ICustomAttributeProvider CustomAttributeProvider { get{} }
	public System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributeProvider { get{} }
	public System.Reflection.MethodInfo MethodInfo { get{} }
	public System.Reflection.MethodInfo BeginMethodInfo { get{} }
	public System.Reflection.MethodInfo EndMethodInfo { get{} }
}

