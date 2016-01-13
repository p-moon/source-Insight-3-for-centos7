public class ClientScriptManager
{

	// Methods
	public void RegisterForEventValidation(PostBackOptions options) {}
	public void RegisterForEventValidation(string uniqueId) {}
	public void RegisterForEventValidation(string uniqueId, string argument) {}
	public void ValidateEvent(string uniqueId) {}
	public void ValidateEvent(string uniqueId, string argument) {}
	public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context) {}
	public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context, bool useAsync) {}
	public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context, string clientErrorCallback, bool useAsync) {}
	public string GetCallbackEventReference(string target, string argument, string clientCallback, string context, string clientErrorCallback, bool useAsync) {}
	public string GetPostBackClientHyperlink(Control control, string argument) {}
	public string GetPostBackClientHyperlink(Control control, string argument, bool registerForEventValidation) {}
	public string GetPostBackEventReference(Control control, string argument) {}
	public string GetPostBackEventReference(Control control, string argument, bool registerForEventValidation) {}
	public string GetPostBackEventReference(PostBackOptions options) {}
	public string GetPostBackEventReference(PostBackOptions options, bool registerForEventValidation) {}
	public string GetWebResourceUrl(Type type, string resourceName) {}
	public bool IsClientScriptBlockRegistered(string key) {}
	public bool IsClientScriptBlockRegistered(Type type, string key) {}
	public bool IsClientScriptIncludeRegistered(string key) {}
	public bool IsClientScriptIncludeRegistered(Type type, string key) {}
	public bool IsStartupScriptRegistered(string key) {}
	public bool IsStartupScriptRegistered(Type type, string key) {}
	public bool IsOnSubmitStatementRegistered(string key) {}
	public bool IsOnSubmitStatementRegistered(Type type, string key) {}
	public void RegisterArrayDeclaration(string arrayName, string arrayValue) {}
	public void RegisterExpandoAttribute(string controlId, string attributeName, string attributeValue) {}
	public void RegisterExpandoAttribute(string controlId, string attributeName, string attributeValue, bool encode) {}
	public void RegisterHiddenField(string hiddenFieldName, string hiddenFieldInitialValue) {}
	public void RegisterClientScriptBlock(Type type, string key, string script) {}
	public void RegisterClientScriptBlock(Type type, string key, string script, bool addScriptTags) {}
	public void RegisterClientScriptInclude(string key, string url) {}
	public void RegisterClientScriptInclude(Type type, string key, string url) {}
	public void RegisterClientScriptResource(Type type, string resourceName) {}
	public void RegisterOnSubmitStatement(Type type, string key, string script) {}
	public void RegisterStartupScript(Type type, string key, string script) {}
	public void RegisterStartupScript(Type type, string key, string script, bool addScriptTags) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

