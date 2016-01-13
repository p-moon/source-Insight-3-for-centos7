public class PageParserFilter
{

	// Methods
	public virtual void ParseComplete(ControlBuilder rootBuilder) {}
	public virtual CompilationMode GetCompilationMode(CompilationMode current) {}
	public virtual bool AllowControl(Type controlType, ControlBuilder builder) {}
	public virtual bool AllowBaseType(Type baseType) {}
	public virtual bool AllowVirtualReference(string referenceVirtualPath, VirtualReferenceType referenceType) {}
	public virtual bool AllowServerSideInclude(string includeVirtualPath) {}
	public virtual void PreprocessDirective(string directiveName, System.Collections.IDictionary attributes) {}
	public virtual bool ProcessCodeConstruct(CodeConstructType codeType, string code) {}
	public virtual bool ProcessDataBindingAttribute(string controlId, string name, string value) {}
	public virtual bool ProcessEventHookup(string controlId, string eventName, string handlerName) {}
	public virtual Type GetNoCompileUserControlType() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowCode { get{} }
	public int NumberOfControlsAllowed { get{} }
	public int TotalNumberOfDependenciesAllowed { get{} }
	public int NumberOfDirectDependenciesAllowed { get{} }
}

