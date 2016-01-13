public class MethodSignatureGenerator
{

	// Constructors
	public MethodSignatureGenerator() {}

	// Methods
	public void SetDesignTableContent(string designTableContent) {}
	public void SetMethodSourceContent(string methodSourceContent) {}
	public string GenerateMethodSignature() {}
	public System.CodeDom.CodeMemberMethod GenerateMethod() {}
	public System.CodeDom.CodeTypeDeclaration GenerateUpdatingMethods() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get{} set{} }
	public Type ContainerParameterType { get{} set{} }
	public bool IsGetMethod { get{} set{} }
	public bool PagingMethod { get{} set{} }
	public ParameterGenerationOption ParameterOption { get{} set{} }
	public string TableClassName { get{} set{} }
	public string DataSetClassName { get{} set{} }
}

