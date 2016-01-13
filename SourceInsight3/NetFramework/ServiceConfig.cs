public class ServiceConfig
{

	// Constructors
	public ServiceConfig() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ThreadPoolOption ThreadPool { get{} set{} }
	public InheritanceOption Inheritance { get{} set{} }
	public BindingOption Binding { get{} set{} }
	public TransactionOption Transaction { get{} set{} }
	public TransactionIsolationLevel IsolationLevel { get{} set{} }
	public int TransactionTimeout { get{} set{} }
	public string TipUrl { get{} set{} }
	public string TransactionDescription { get{} set{} }
	public ITransaction BringYourOwnTransaction { get{} set{} }
	public System.Transactions.Transaction BringYourOwnSystemTransaction { get{} set{} }
	public SynchronizationOption Synchronization { get{} set{} }
	public bool IISIntrinsicsEnabled { get{} set{} }
	public bool COMTIIntrinsicsEnabled { get{} set{} }
	public bool TrackingEnabled { get{} set{} }
	public string TrackingAppName { get{} set{} }
	public string TrackingComponentName { get{} set{} }
	public SxsOption SxsOption { get{} set{} }
	public string SxsDirectory { get{} set{} }
	public string SxsName { get{} set{} }
	public PartitionOption PartitionOption { get{} set{} }
	public System.Guid PartitionId { get{} set{} }
}

