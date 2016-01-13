public interface ICodeParser
{

	// Methods
	public abstract virtual System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream) {}
}

