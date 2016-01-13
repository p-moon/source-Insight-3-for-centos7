public class MailEventNotificationInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebBaseEventCollection Events { get{} }
	public EventNotificationType NotificationType { get{} }
	public int EventsInNotification { get{} }
	public int EventsRemaining { get{} }
	public int MessagesInNotification { get{} }
	public int EventsInBuffer { get{} }
	public int EventsDiscardedByBuffer { get{} }
	public int EventsDiscardedDueToMessageLimit { get{} }
	public int NotificationSequence { get{} }
	public int MessageSequence { get{} }
	public System.DateTime LastNotificationUtc { get{} }
	public System.Net.Mail.MailMessage Message { get{} }
}

