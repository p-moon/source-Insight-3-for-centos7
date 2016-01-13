public class CodeCompiler : CodeGenerator, ICodeGenerator, ICodeCompiler
{

	// Methods
	public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

