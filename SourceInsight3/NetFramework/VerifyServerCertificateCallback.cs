public class VerifyServerCertificateCallback : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public VerifyServerCertificateCallback(object object, System.IntPtr method) {}

	// Methods
	public virtual bool Invoke(LdapConnection connection, System.Security.Cryptography.X509Certificates.X509Certificate certificate) {}
	public virtual System.IAsyncResult BeginInvoke(LdapConnection connection, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.AsyncCallback callback, object object) {}
	public virtual bool EndInvoke(System.IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

