public interface IHTMLDOMNode
{

	// Methods
	public abstract virtual long GetNodeType() {}
	public abstract virtual IHTMLDOMNode GetParentNode() {}
	public abstract virtual bool HasChildNodes() {}
	public abstract virtual object GetChildNodes() {}
	public abstract virtual object GetAttributes() {}
	public abstract virtual IHTMLDOMNode InsertBefore(IHTMLDOMNode newChild, object refChild) {}
	public abstract virtual IHTMLDOMNode RemoveChild(IHTMLDOMNode oldChild) {}
	public abstract virtual IHTMLDOMNode ReplaceChild(IHTMLDOMNode newChild, IHTMLDOMNode oldChild) {}
	public abstract virtual IHTMLDOMNode CloneNode(bool fDeep) {}
	public abstract virtual IHTMLDOMNode RemoveNode(bool fDeep) {}
	public abstract virtual IHTMLDOMNode SwapNode(IHTMLDOMNode otherNode) {}
	public abstract virtual IHTMLDOMNode ReplaceNode(IHTMLDOMNode replacement) {}
	public abstract virtual IHTMLDOMNode AppendChild(IHTMLDOMNode newChild) {}
	public abstract virtual string NodeName() {}
	public abstract virtual void SetNodeValue(object v) {}
	public abstract virtual object GetNodeValue() {}
	public abstract virtual IHTMLDOMNode FirstChild() {}
	public abstract virtual IHTMLDOMNode LastChild() {}
	public abstract virtual IHTMLDOMNode PreviousSibling() {}
	public abstract virtual IHTMLDOMNode NextSibling() {}
}

