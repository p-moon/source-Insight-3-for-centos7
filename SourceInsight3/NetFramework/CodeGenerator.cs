public class CodeGenerator : ICodeGenerator
{

	// Methods
	public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public static bool IsValidLanguageIndependentIdentifier(string value) {}
	public static void ValidateIdentifiers(System.CodeDom.CodeObject e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

