public class ConfigurationException : System.SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public ConfigurationException(string message, System.Exception inner) {}
	public ConfigurationException() {}
	public ConfigurationException(string message) {}
	public ConfigurationException(string message, System.Xml.XmlNode node) {}
	public ConfigurationException(string message, System.Exception inner, System.Xml.XmlNode node) {}
	public ConfigurationException(string message, string filename, int line) {}
	public ConfigurationException(string message, System.Exception inner, string filename, int line) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public static string GetXmlNodeFilename(System.Xml.XmlNode node) {}
	public static int GetXmlNodeLineNumber(System.Xml.XmlNode node) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public string BareMessage { get{} }
	public string Filename { get{} }
	public int Line { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

