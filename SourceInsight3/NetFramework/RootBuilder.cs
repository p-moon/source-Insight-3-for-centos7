public class RootBuilder : TemplateBuilder, ITemplate
{

	// Constructors
	public RootBuilder() {}
	public RootBuilder(TemplateParser parser) {}

	// Methods
	public virtual Type GetChildControlType(string tagName, System.Collections.IDictionary attribs) {}
	public virtual void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string ID, System.Collections.IDictionary attribs) {}
	public virtual void CloseControl() {}
	public virtual object BuildObject() {}
	public virtual bool NeedsTagInnerText() {}
	public virtual void SetTagInnerText(string text) {}
	public virtual void InstantiateIn(Control container) {}
	public virtual bool AllowWhitespaceLiterals() {}
	public virtual void AppendLiteralString(string s) {}
	public virtual void AppendSubBuilder(ControlBuilder subBuilder) {}
	public ObjectPersistData GetObjectPersistData() {}
	public virtual bool HasBody() {}
	public virtual bool HtmlDecodeLiterals() {}
	public virtual void OnAppendToParentBuilder(ControlBuilder parentBuilder) {}
	public void SetServiceProvider(System.IServiceProvider serviceProvider) {}
	public string GetResourceKey() {}
	public void SetResourceKey(string resourceKey) {}
	public virtual void ProcessGeneratedCode(System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.CodeTypeDeclaration baseType, System.CodeDom.CodeTypeDeclaration derivedType, System.CodeDom.CodeMemberMethod buildMethod, System.CodeDom.CodeMemberMethod dataBindingMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary BuiltObjects { get{} }
	public string Text { get{} set{} }
	public Type BindingContainerType { get{} }
	public Type ControlType { get{} }
	public IFilterResolutionService CurrentFilterResolutionService { get{} }
	public Type DeclareType { get{} }
	public IThemeResolutionService ThemeResolutionService { get{} }
	public bool HasAspCode { get{} }
	public string ID { get{} set{} }
	public bool Localize { get{} }
	public Type NamingContainerType { get{} }
	public System.IServiceProvider ServiceProvider { get{} }
	public string TagName { get{} }
}

