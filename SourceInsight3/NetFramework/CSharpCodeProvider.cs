public class CSharpCodeProvider : System.CodeDom.Compiler.CodeDomProvider, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public CSharpCodeProvider() {}
	public CSharpCodeProvider(IDictionary<string,string> providerOptions) {}

	// Methods
	public virtual System.CodeDom.Compiler.ICodeGenerator CreateGenerator() {}
	public virtual System.CodeDom.Compiler.ICodeCompiler CreateCompiler() {}
	public virtual System.ComponentModel.TypeConverter GetConverter(Type type) {}
	public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual System.CodeDom.Compiler.ICodeGenerator CreateGenerator(System.IO.TextWriter output) {}
	public virtual System.CodeDom.Compiler.ICodeGenerator CreateGenerator(string fileName) {}
	public virtual System.CodeDom.Compiler.ICodeParser CreateParser() {}
	public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromDom(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit[] compilationUnits) {}
	public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters options, string[] fileNames) {}
	public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters options, string[] sources) {}
	public virtual bool IsValidIdentifier(string value) {}
	public virtual string CreateEscapedIdentifier(string value) {}
	public virtual string CreateValidIdentifier(string value) {}
	public virtual string GetTypeOutput(System.CodeDom.CodeTypeReference type) {}
	public virtual bool Supports(System.CodeDom.Compiler.GeneratorSupport generatorSupport) {}
	public virtual void GenerateCodeFromExpression(System.CodeDom.CodeExpression expression, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromStatement(System.CodeDom.CodeStatement statement, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromNamespace(System.CodeDom.CodeNamespace codeNamespace, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit compileUnit, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration codeType, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) {}
	public virtual System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FileExtension { get{} }
	public System.CodeDom.Compiler.LanguageOptions LanguageOptions { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

