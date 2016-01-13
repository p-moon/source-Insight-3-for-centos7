public class MessageQueue : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.Collections.IEnumerable
{

	// Constructors
	public MessageQueue() {}
	public MessageQueue(string path) {}
	public MessageQueue(string path, QueueAccessMode accessMode) {}
	public MessageQueue(string path, bool sharedModeDenyReceive) {}
	public MessageQueue(string path, bool sharedModeDenyReceive, bool enableCache) {}
	public MessageQueue(string path, bool sharedModeDenyReceive, bool enableCache, QueueAccessMode accessMode) {}

	// Methods
	public System.IAsyncResult BeginPeek() {}
	public System.IAsyncResult BeginPeek(System.TimeSpan timeout) {}
	public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject) {}
	public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) {}
	public System.IAsyncResult BeginPeek(System.TimeSpan timeout, Cursor cursor, PeekAction action, object state, System.AsyncCallback callback) {}
	public System.IAsyncResult BeginReceive() {}
	public System.IAsyncResult BeginReceive(System.TimeSpan timeout) {}
	public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject) {}
	public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) {}
	public System.IAsyncResult BeginReceive(System.TimeSpan timeout, Cursor cursor, object state, System.AsyncCallback callback) {}
	public static void ClearConnectionCache() {}
	public void Close() {}
	public static MessageQueue Create(string path) {}
	public static MessageQueue Create(string path, bool transactional) {}
	public Cursor CreateCursor() {}
	public static void Delete(string path) {}
	public Message EndPeek(System.IAsyncResult asyncResult) {}
	public Message EndReceive(System.IAsyncResult asyncResult) {}
	public static bool Exists(string path) {}
	public Message[] GetAllMessages() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public static System.Guid GetMachineId(string machineName) {}
	public static SecurityContext GetSecurityContext() {}
	public static MessageQueueEnumerator GetMessageQueueEnumerator() {}
	public static MessageQueueEnumerator GetMessageQueueEnumerator(MessageQueueCriteria criteria) {}
	public MessageEnumerator GetMessageEnumerator() {}
	public MessageEnumerator GetMessageEnumerator2() {}
	public static MessageQueue[] GetPrivateQueuesByMachine(string machineName) {}
	public static MessageQueue[] GetPublicQueues() {}
	public static MessageQueue[] GetPublicQueues(MessageQueueCriteria criteria) {}
	public static MessageQueue[] GetPublicQueuesByCategory(System.Guid category) {}
	public static MessageQueue[] GetPublicQueuesByLabel(string label) {}
	public static MessageQueue[] GetPublicQueuesByMachine(string machineName) {}
	public Message Peek() {}
	public Message Peek(System.TimeSpan timeout) {}
	public Message Peek(System.TimeSpan timeout, Cursor cursor, PeekAction action) {}
	public Message PeekById(string id) {}
	public Message PeekById(string id, System.TimeSpan timeout) {}
	public Message PeekByCorrelationId(string correlationId) {}
	public Message PeekByCorrelationId(string correlationId, System.TimeSpan timeout) {}
	public void Purge() {}
	public Message Receive() {}
	public Message Receive(MessageQueueTransaction transaction) {}
	public Message Receive(MessageQueueTransactionType transactionType) {}
	public Message Receive(System.TimeSpan timeout) {}
	public Message Receive(System.TimeSpan timeout, Cursor cursor) {}
	public Message Receive(System.TimeSpan timeout, MessageQueueTransaction transaction) {}
	public Message Receive(System.TimeSpan timeout, MessageQueueTransactionType transactionType) {}
	public Message Receive(System.TimeSpan timeout, Cursor cursor, MessageQueueTransaction transaction) {}
	public Message Receive(System.TimeSpan timeout, Cursor cursor, MessageQueueTransactionType transactionType) {}
	public Message ReceiveById(string id) {}
	public Message ReceiveById(string id, MessageQueueTransaction transaction) {}
	public Message ReceiveById(string id, MessageQueueTransactionType transactionType) {}
	public Message ReceiveById(string id, System.TimeSpan timeout) {}
	public Message ReceiveById(string id, System.TimeSpan timeout, MessageQueueTransaction transaction) {}
	public Message ReceiveById(string id, System.TimeSpan timeout, MessageQueueTransactionType transactionType) {}
	public Message ReceiveByCorrelationId(string correlationId) {}
	public Message ReceiveByCorrelationId(string correlationId, MessageQueueTransaction transaction) {}
	public Message ReceiveByCorrelationId(string correlationId, MessageQueueTransactionType transactionType) {}
	public Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout) {}
	public Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, MessageQueueTransaction transaction) {}
	public Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, MessageQueueTransactionType transactionType) {}
	public Message ReceiveByLookupId(long lookupId) {}
	public Message ReceiveByLookupId(MessageLookupAction action, long lookupId, MessageQueueTransactionType transactionType) {}
	public Message ReceiveByLookupId(MessageLookupAction action, long lookupId, MessageQueueTransaction transaction) {}
	public Message PeekByLookupId(long lookupId) {}
	public Message PeekByLookupId(MessageLookupAction action, long lookupId) {}
	public void Refresh() {}
	public void Send(object obj) {}
	public void Send(object obj, MessageQueueTransaction transaction) {}
	public void Send(object obj, MessageQueueTransactionType transactionType) {}
	public void Send(object obj, string label) {}
	public void Send(object obj, string label, MessageQueueTransaction transaction) {}
	public void Send(object obj, string label, MessageQueueTransactionType transactionType) {}
	public void ResetPermissions() {}
	public void SetPermissions(string user, MessageQueueAccessRights rights) {}
	public void SetPermissions(string user, MessageQueueAccessRights rights, AccessControlEntryType entryType) {}
	public void SetPermissions(MessageQueueAccessControlEntry ace) {}
	public void SetPermissions(AccessControlList dacl) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.TimeSpan InfiniteTimeout;
	public long InfiniteQueueSize;

	// Properties
	public QueueAccessMode AccessMode { get{} }
	public bool Authenticate { get{} set{} }
	public short BasePriority { get{} set{} }
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public System.Guid Category { get{} set{} }
	public System.DateTime CreateTime { get{} }
	public DefaultPropertiesToSend DefaultPropertiesToSend { get{} set{} }
	public bool DenySharedReceive { get{} set{} }
	public bool EnableConnectionCache { get{} set{} }
	public EncryptionRequired EncryptionRequired { get{} set{} }
	public string FormatName { get{} }
	public IMessageFormatter Formatter { get{} set{} }
	public System.Guid Id { get{} }
	public string Label { get{} set{} }
	public System.DateTime LastModifyTime { get{} }
	public string MachineName { get{} set{} }
	public long MaximumJournalSize { get{} set{} }
	public long MaximumQueueSize { get{} set{} }
	public MessagePropertyFilter MessageReadPropertyFilter { get{} set{} }
	public string MulticastAddress { get{} set{} }
	public string Path { get{} set{} }
	public string QueueName { get{} set{} }
	public System.IntPtr ReadHandle { get{} }
	public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get{} set{} }
	public bool Transactional { get{} }
	public bool UseJournalQueue { get{} set{} }
	public System.IntPtr WriteHandle { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Messaging.PeekCompletedEventHandler PeekCompleted;
	public event System.Messaging.ReceiveCompletedEventHandler ReceiveCompleted;
	public event System.EventHandler Disposed;
}

