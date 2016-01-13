public class XmlMessageFormatter : IMessageFormatter, System.ICloneable
{

	// Constructors
	public XmlMessageFormatter() {}
	public XmlMessageFormatter(string[] targetTypeNames) {}
	public XmlMessageFormatter(Type[] targetTypes) {}

	// Methods
	public virtual bool CanRead(Message message) {}
	public virtual object Clone() {}
	public virtual object Read(Message message) {}
	public virtual void Write(Message message, object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] TargetTypeNames { get{} set{} }
	public Type[] TargetTypes { get{} set{} }
}

