public class LosFormatter
{

	// Constructors
	public LosFormatter() {}
	public LosFormatter(bool enableMac, string macKeyModifier) {}
	public LosFormatter(bool enableMac, byte[] macKeyModifier) {}

	// Methods
	public object Deserialize(System.IO.Stream stream) {}
	public object Deserialize(System.IO.TextReader input) {}
	public object Deserialize(string input) {}
	public void Serialize(System.IO.Stream stream, object value) {}
	public void Serialize(System.IO.TextWriter output, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

