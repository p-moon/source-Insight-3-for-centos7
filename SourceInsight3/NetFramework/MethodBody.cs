public class MethodBody
{

	// Methods
	public byte[] GetILAsByteArray() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int LocalSignatureMetadataToken { get{} }
	public IList<System.Reflection.LocalVariableInfo> LocalVariables { get{} }
	public int MaxStackSize { get{} }
	public bool InitLocals { get{} }
	public IList<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauses { get{} }
}

