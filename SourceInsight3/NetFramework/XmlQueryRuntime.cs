public class XmlQueryRuntime
{

	// Methods
	public string[] DebugGetGlobalNames() {}
	public System.Collections.IList DebugGetGlobalValue(string name) {}
	public void DebugSetGlobalValue(string name, object value) {}
	public object DebugGetXsltValue(System.Collections.IList seq) {}
	public object GetEarlyBoundObject(int index) {}
	public bool EarlyBoundFunctionExists(string name, string namespaceUri) {}
	public bool IsGlobalComputed(int index) {}
	public object GetGlobalValue(int index) {}
	public void SetGlobalValue(int index, object value) {}
	public string GetAtomizedName(int index) {}
	public XmlNavigatorFilter GetNameFilter(int index) {}
	public XmlNavigatorFilter GetTypeFilter(System.Xml.XPath.XPathNodeType nodeType) {}
	public System.Xml.XmlQualifiedName ParseTagName(string tagName, int indexPrefixMappings) {}
	public System.Xml.XmlQualifiedName ParseTagName(string tagName, string ns) {}
	public bool IsQNameEqual(System.Xml.XPath.XPathNavigator n1, System.Xml.XPath.XPathNavigator n2) {}
	public bool IsQNameEqual(System.Xml.XPath.XPathNavigator navigator, int indexLocalName, int indexNamespaceUri) {}
	public object ChangeTypeXsltArgument(int indexType, object value, Type destinationType) {}
	public object ChangeTypeXsltResult(int indexType, object value) {}
	public bool MatchesXmlType(IList<System.Xml.XPath.XPathItem> seq, int indexType) {}
	public bool MatchesXmlType(System.Xml.XPath.XPathItem item, int indexType) {}
	public bool MatchesXmlType(IList<System.Xml.XPath.XPathItem> seq, System.Xml.Schema.XmlTypeCode code) {}
	public bool MatchesXmlType(System.Xml.XPath.XPathItem item, System.Xml.Schema.XmlTypeCode code) {}
	public XmlCollation GetCollation(int index) {}
	public XmlCollation CreateCollation(string collation) {}
	public int ComparePosition(System.Xml.XPath.XPathNavigator navigatorThis, System.Xml.XPath.XPathNavigator navigatorThat) {}
	public IList<System.Xml.XPath.XPathNavigator> DocOrderDistinct(IList<System.Xml.XPath.XPathNavigator> seq) {}
	public string GenerateId(System.Xml.XPath.XPathNavigator navigator) {}
	public bool FindIndex(System.Xml.XPath.XPathNavigator context, int indexIdout , XmlILIndex& index) {}
	public void AddNewIndex(System.Xml.XPath.XPathNavigator context, int indexId, XmlILIndex index) {}
	public void StartSequenceConstruction(out XmlQueryOutput& output) {}
	public IList<System.Xml.XPath.XPathItem> EndSequenceConstruction(out XmlQueryOutput& output) {}
	public void StartRtfConstruction(string baseUriout , XmlQueryOutput& output) {}
	public System.Xml.XPath.XPathNavigator EndRtfConstruction(out XmlQueryOutput& output) {}
	public System.Xml.XPath.XPathNavigator TextRtfConstruction(string text, string baseUri) {}
	public void SendMessage(string message) {}
	public void ThrowException(string text) {}
	public static int OnCurrentNodeChanged(System.Xml.XPath.XPathNavigator currentNode) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlQueryContext ExternalContext { get{} }
	public XsltLibrary XsltFunctions { get{} }
	public System.Xml.XmlNameTable NameTable { get{} }
	public XmlQueryOutput Output { get{} }
}

