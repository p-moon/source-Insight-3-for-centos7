public class BinaryMessageFormatter : IMessageFormatter, System.ICloneable
{

	// Constructors
	public BinaryMessageFormatter() {}
	public BinaryMessageFormatter(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle topObjectFormat, System.Runtime.Serialization.Formatters.FormatterTypeStyle typeFormat) {}

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
	public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TopObjectFormat { get{} set{} }
	public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get{} set{} }
}

