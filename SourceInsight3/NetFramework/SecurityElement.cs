public class SecurityElement : ISecurityElementFactory
{

	// Constructors
	public SecurityElement(string tag) {}
	public SecurityElement(string tag, string text) {}

	// Methods
	public static SecurityElement FromString(string xml) {}
	public void AddAttribute(string name, string value) {}
	public void AddChild(SecurityElement child) {}
	public bool Equal(SecurityElement other) {}
	public SecurityElement Copy() {}
	public static bool IsValidTag(string tag) {}
	public static bool IsValidText(string text) {}
	public static bool IsValidAttributeName(string name) {}
	public static bool IsValidAttributeValue(string value) {}
	public static string Escape(string str) {}
	public virtual string ToString() {}
	public string Attribute(string name) {}
	public SecurityElement SearchForChildByTag(string tag) {}
	public string SearchForTextOfTag(string tag) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Tag { get{} set{} }
	public System.Collections.Hashtable Attributes { get{} set{} }
	public string Text { get{} set{} }
	public System.Collections.ArrayList Children { get{} set{} }
}

