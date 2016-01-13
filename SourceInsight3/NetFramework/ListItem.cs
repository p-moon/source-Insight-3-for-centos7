public class ListItem : System.Web.UI.IStateManager, System.Web.UI.IParserAccessor, System.Web.UI.IAttributeAccessor
{

	// Constructors
	public ListItem() {}
	public ListItem(string text) {}
	public ListItem(string text, string value) {}
	public ListItem(string text, string value, bool enabled) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public static ListItem FromString(string s) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public bool Enabled { get{} set{} }
	public bool Selected { get{} set{} }
	public string Text { get{} set{} }
	public string Value { get{} set{} }
}

