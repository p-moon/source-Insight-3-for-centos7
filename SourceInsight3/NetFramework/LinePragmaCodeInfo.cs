public class LinePragmaCodeInfo
{

	// Constructors
	public LinePragmaCodeInfo() {}
	public LinePragmaCodeInfo(int startLine, int startColumn, int startGeneratedColumn, int codeLength, bool isCodeNugget) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int StartLine { get{} }
	public int StartColumn { get{} }
	public int StartGeneratedColumn { get{} }
	public int CodeLength { get{} }
	public bool IsCodeNugget { get{} }
}

