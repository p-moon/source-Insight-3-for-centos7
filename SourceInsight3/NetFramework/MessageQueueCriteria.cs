public class MessageQueueCriteria
{

	// Constructors
	public MessageQueueCriteria() {}

	// Methods
	public void ClearAll() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime CreatedAfter { get{} set{} }
	public System.DateTime CreatedBefore { get{} set{} }
	public string Label { get{} set{} }
	public string MachineName { get{} set{} }
	public System.DateTime ModifiedAfter { get{} set{} }
	public System.DateTime ModifiedBefore { get{} set{} }
	public System.Guid Category { get{} set{} }
}

