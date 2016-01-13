public class VsaCompilerError : Microsoft.Vsa.IVsaError
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Line { get{} }
	public int Severity { get{} }
	public string Description { get{} }
	public string LineText { get{} }
	public Microsoft.Vsa.IVsaItem SourceItem { get{} }
	public int EndColumn { get{} }
	public int StartColumn { get{} }
	public int Number { get{} }
	public string SourceMoniker { get{} }
}

