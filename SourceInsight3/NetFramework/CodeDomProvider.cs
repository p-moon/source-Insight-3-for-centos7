public class CodeDomProvider : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Methods
	public static string GetLanguageFromExtension(string extension) {}
	public static CompilerInfo GetCompilerInfo(string language) {}
	public abstract virtual ICodeGenerator CreateGenerator() {}
	public virtual ICodeGenerator CreateGenerator(System.IO.TextWriter output) {}
	public virtual ICodeGenerator CreateGenerator(string fileName) {}
	public abstract virtual ICodeCompiler CreateCompiler() {}
	public virtual ICodeParser CreateParser() {}
	public virtual System.ComponentModel.TypeConverter GetConverter(Type type) {}
	public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, System.CodeDom.CodeCompileUnit[] compilationUnits) {}
	public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, string[] fileNames) {}
	public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, string[] sources) {}
	public virtual bool IsValidIdentifier(string value) {}
	public virtual string CreateEscapedIdentifier(string value) {}
	public virtual string CreateValidIdentifier(string value) {}
	public virtual string GetTypeOutput(System.CodeDom.CodeTypeReference type) {}
	public virtual bool Supports(GeneratorSupport generatorSupport) {}
	public virtual void GenerateCodeFromExpression(System.CodeDom.CodeExpression expression, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromStatement(System.CodeDom.CodeStatement statement, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromNamespace(System.CodeDom.CodeNamespace codeNamespace, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit compileUnit, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration codeType, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, CodeGeneratorOptions options) {}
	public virtual System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream) {}
	public static CodeDomProvider CreateProvider(string language) {}
	public static bool IsDefinedLanguage(string language) {}
	public static bool IsDefinedExtension(string extension) {}
	public static CompilerInfo[] GetAllCompilerInfo() {}
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
	public LanguageOptions LanguageOptions { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

