public interface ICodeGenerator
{

	// Methods
	public abstract virtual bool IsValidIdentifier(string value) {}
	public abstract virtual void ValidateIdentifier(string value) {}
	public abstract virtual string CreateEscapedIdentifier(string value) {}
	public abstract virtual string CreateValidIdentifier(string value) {}
	public abstract virtual string GetTypeOutput(System.CodeDom.CodeTypeReference type) {}
	public abstract virtual bool Supports(GeneratorSupport supports) {}
	public abstract virtual void GenerateCodeFromExpression(System.CodeDom.CodeExpression e, System.IO.TextWriter w, CodeGeneratorOptions o) {}
	public abstract virtual void GenerateCodeFromStatement(System.CodeDom.CodeStatement e, System.IO.TextWriter w, CodeGeneratorOptions o) {}
	public abstract virtual void GenerateCodeFromNamespace(System.CodeDom.CodeNamespace e, System.IO.TextWriter w, CodeGeneratorOptions o) {}
	public abstract virtual void GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit e, System.IO.TextWriter w, CodeGeneratorOptions o) {}
	public abstract virtual void GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration e, System.IO.TextWriter w, CodeGeneratorOptions o) {}
}

