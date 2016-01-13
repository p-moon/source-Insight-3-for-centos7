public class HttpClientCertificate : System.Collections.Specialized.NameValueCollection, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
{

	// Methods
	public virtual string Get(string field) {}
	public void Add(System.Collections.Specialized.NameValueCollection c) {}
	public virtual void Clear() {}
	public void CopyTo(System.Array dest, int index) {}
	public bool HasKeys() {}
	public virtual void Add(string name, string value) {}
	public virtual string[] GetValues(string name) {}
	public virtual void Set(string name, string value) {}
	public virtual void Remove(string name) {}
	public virtual string Get(int index) {}
	public virtual string[] GetValues(int index) {}
	public virtual string GetKey(int index) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void OnDeserialization(object sender) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Cookie { get{} }
	public byte[] Certificate { get{} }
	public int Flags { get{} }
	public int KeySize { get{} }
	public int SecretKeySize { get{} }
	public string Issuer { get{} }
	public string ServerIssuer { get{} }
	public string Subject { get{} }
	public string ServerSubject { get{} }
	public string SerialNumber { get{} }
	public System.DateTime ValidFrom { get{} }
	public System.DateTime ValidUntil { get{} }
	public int CertEncoding { get{} }
	public byte[] PublicKey { get{} }
	public byte[] BinaryIssuer { get{} }
	public bool IsPresent { get{} }
	public bool IsValid { get{} }
	public string Item { get{} set{} }
	public string Item { get{} }
	public string[] AllKeys { get{} }
	public int Count { get{} }
	public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get{} }
}

