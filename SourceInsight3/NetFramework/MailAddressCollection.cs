public class MailAddressCollection : Collection<System.Net.Mail.MailAddress>, IList<System.Net.Mail.MailAddress>, ICollection<System.Net.Mail.MailAddress>, IEnumerable<System.Net.Mail.MailAddress>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public MailAddressCollection() {}

	// Methods
	public void Add(string addresses) {}
	public virtual string ToString() {}
	public virtual void Add(MailAddress item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(MailAddress[] array, int index) {}
	public virtual bool Contains(MailAddress item) {}
	public virtual IEnumerator<System.Net.Mail.MailAddress> GetEnumerator() {}
	public virtual int IndexOf(MailAddress item) {}
	public virtual void Insert(int index, MailAddress item) {}
	public virtual bool Remove(MailAddress item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public MailAddress Item { get{} set{} }
}

