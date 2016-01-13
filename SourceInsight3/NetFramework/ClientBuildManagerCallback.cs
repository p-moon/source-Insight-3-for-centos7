public class ClientBuildManagerCallback : System.MarshalByRefObject
{

	// Constructors
	public ClientBuildManagerCallback() {}

	// Methods
	public virtual void ReportCompilerError(System.CodeDom.Compiler.CompilerError error) {}
	public virtual void ReportParseError(System.Web.ParserError error) {}
	public virtual void ReportProgress(string message) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

