public interface ICodeCompiler
{

	// Methods
	public abstract virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, System.CodeDom.CodeCompileUnit compilationUnit) {}
	public abstract virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName) {}
	public abstract virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source) {}
	public abstract virtual CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, System.CodeDom.CodeCompileUnit[] compilationUnits) {}
	public abstract virtual CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames) {}
	public abstract virtual CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources) {}
}

