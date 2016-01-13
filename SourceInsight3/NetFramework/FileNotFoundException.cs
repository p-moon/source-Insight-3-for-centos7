public class FileNotFoundException : IOException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public FileNotFoundException() {}
	public FileNotFoundException(string message) {}
	public FileNotFoundException(string message, System.Exception innerException) {}
	public FileNotFoundException(string message, string fileName) {}
	public FileNotFoundException(string message, string fileName, System.Exception innerException) {}

	// Methods
	public virtual string ToString() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public string FileName { get{} }
	public string FusionLog { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

