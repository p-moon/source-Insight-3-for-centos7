public class CorrelationManager
{

	// Methods
	public void StartLogicalOperation(object operationId) {}
	public void StartLogicalOperation() {}
	public void StopLogicalOperation() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Guid ActivityId { get{} set{} }
	public System.Collections.Stack LogicalOperationStack { get{} }
}

