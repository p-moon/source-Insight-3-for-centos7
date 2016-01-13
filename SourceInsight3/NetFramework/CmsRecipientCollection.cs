public class CmsRecipientCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CmsRecipientCollection() {}
	public CmsRecipientCollection(CmsRecipient recipient) {}
	public CmsRecipientCollection(SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) {}

	// Methods
	public int Add(CmsRecipient recipient) {}
	public void Remove(CmsRecipient recipient) {}
	public CmsRecipientEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(CmsRecipient[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CmsRecipient Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

