public class ExceptionHandlingClause
{

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ExceptionHandlingClauseOptions Flags { get{} }
	public int TryOffset { get{} }
	public int TryLength { get{} }
	public int HandlerOffset { get{} }
	public int HandlerLength { get{} }
	public int FilterOffset { get{} }
	public Type CatchType { get{} }
}

