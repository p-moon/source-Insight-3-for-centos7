public class TypedDataSetGenerator
{

	// Methods
	public static string GetProviderName(string inputFileContent) {}
	public static string GetProviderName(string inputFileContent, string tableName) {}
	public static string Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) {}
	public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Common.DbProviderFactory specifiedFactory) {}
	public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders) {}
	public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, GenerateOption option) {}
	public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, GenerateOption option, string dataSetNamespace) {}
	public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) {}
	public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, GenerateOption option) {}
	public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, GenerateOption option, string dataSetNamespace) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ICollection<System.Reflection.Assembly> ReferencedAssemblies { get{} }
}

