public class CodeParser : ICodeParser
{

	// Methods
	public abstract virtual System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

