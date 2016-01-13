public class ConfigurationErrorsException : ConfigurationException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public ConfigurationErrorsException(string message, System.Exception inner, string filename, int line) {}
	public ConfigurationErrorsException(string message) {}
	public ConfigurationErrorsException(string message, System.Exception inner) {}
	public ConfigurationErrorsException(string message, string filename, int line) {}
	public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlNode node) {}
	public ConfigurationErrorsException() {}
	public ConfigurationErrorsException(string message, System.Xml.XmlNode node) {}
	public ConfigurationErrorsException(string message, System.Xml.XmlReader reader) {}
	public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlReader reader) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public static int GetLineNumber(System.Xml.XmlNode node) {}
	public static string GetFilename(System.Xml.XmlNode node) {}
	public static int GetLineNumber(System.Xml.XmlReader reader) {}
	public static string GetFilename(System.Xml.XmlReader reader) {}
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
	public System.Collections.ICollection Errors { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

