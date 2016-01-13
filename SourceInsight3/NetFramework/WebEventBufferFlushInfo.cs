public class WebEventBufferFlushInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebBaseEventCollection Events { get{} }
	public System.DateTime LastNotificationUtc { get{} }
	public int EventsDiscardedSinceLastNotification { get{} }
	public int EventsInBuffer { get{} }
	public int NotificationSequence { get{} }
	public EventNotificationType NotificationType { get{} }
}

