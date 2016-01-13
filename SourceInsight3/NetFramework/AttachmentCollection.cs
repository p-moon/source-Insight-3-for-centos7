public class AttachmentCollection : Collection<System.Net.Mail.Attachment>, IList<System.Net.Mail.Attachment>, ICollection<System.Net.Mail.Attachment>, IEnumerable<System.Net.Mail.Attachment>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual void Add(Attachment item) {}
	public virtual void Clear() {}
	public virtual void CopyTo(Attachment[] array, int index) {}
	public virtual bool Contains(Attachment item) {}
	public virtual IEnumerator<System.Net.Mail.Attachment> GetEnumerator() {}
	public virtual int IndexOf(Attachment item) {}
	public virtual void Insert(int index, Attachment item) {}
	public virtual bool Remove(Attachment item) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public Attachment Item { get{} set{} }
}

