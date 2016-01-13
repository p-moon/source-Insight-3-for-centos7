public class XmlNavigatorFilter
{

	// Methods
	public abstract virtual bool MoveToContent(System.Xml.XPath.XPathNavigator navigator) {}
	public abstract virtual bool MoveToNextContent(System.Xml.XPath.XPathNavigator navigator) {}
	public abstract virtual bool MoveToFollowingSibling(System.Xml.XPath.XPathNavigator navigator) {}
	public abstract virtual bool MoveToPreviousSibling(System.Xml.XPath.XPathNavigator navigator) {}
	public abstract virtual bool MoveToFollowing(System.Xml.XPath.XPathNavigator navigator, System.Xml.XPath.XPathNavigator navigatorEnd) {}
	public abstract virtual bool IsFiltered(System.Xml.XPath.XPathNavigator navigator) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

