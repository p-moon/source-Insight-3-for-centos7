public class DeviceSpecificChoiceTemplateBuilder : System.Web.UI.TemplateBuilder, System.Web.UI.ITemplate
{

	// Constructors
	public DeviceSpecificChoiceTemplateBuilder() {}

	// Methods
	public virtual void Init(System.Web.UI.TemplateParser parser, System.Web.UI.ControlBuilder parentBuilder, Type type, string tagName, string id, System.Collections.IDictionary attributes) {}
	public virtual void AppendLiteralString(string text) {}
	public virtual void AppendSubBuilder(System.Web.UI.ControlBuilder subBuilder) {}
	public virtual void CloseControl() {}
	public virtual object BuildObject() {}
	public virtual bool NeedsTagInnerText() {}
	public virtual void SetTagInnerText(string text) {}
	public virtual void InstantiateIn(System.Web.UI.Control container) {}
	public virtual bool AllowWhitespaceLiterals() {}
	public virtual Type GetChildControlType(string tagName, System.Collections.IDictionary attribs) {}
	public System.Web.UI.ObjectPersistData GetObjectPersistData() {}
	public virtual bool HasBody() {}
	public virtual bool HtmlDecodeLiterals() {}
	public virtual void OnAppendToParentBuilder(System.Web.UI.ControlBuilder parentBuilder) {}
	public void SetServiceProvider(System.IServiceProvider serviceProvider) {}
	public string GetResourceKey() {}
	public void SetResourceKey(string resourceKey) {}
	public virtual void ProcessGeneratedCode(System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.CodeTypeDeclaration baseType, System.CodeDom.CodeTypeDeclaration derivedType, System.CodeDom.CodeMemberMethod buildMethod, System.CodeDom.CodeMemberMethod dataBindingMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Text { get{} set{} }
	public Type BindingContainerType { get{} }
	public Type ControlType { get{} }
	public System.Web.UI.IFilterResolutionService CurrentFilterResolutionService { get{} }
	public Type DeclareType { get{} }
	public System.Web.UI.IThemeResolutionService ThemeResolutionService { get{} }
	public bool HasAspCode { get{} }
	public string ID { get{} set{} }
	public bool Localize { get{} }
	public Type NamingContainerType { get{} }
	public System.IServiceProvider ServiceProvider { get{} }
	public string TagName { get{} }
}

