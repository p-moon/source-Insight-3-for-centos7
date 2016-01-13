public class WebBaseErrorEvent : WebManagementEvent
{

	// Methods
	public virtual string ToString() {}
	public virtual string ToString(bool includeAppInfo, bool includeCustomEventDetails) {}
	public virtual void FormatCustomEventDetails(WebEventFormatter formatter) {}
	public virtual void Raise() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Exception ErrorException { get{} }
	public WebProcessInformation ProcessInformation { get{} }
	public System.DateTime EventTime { get{} }
	public System.DateTime EventTimeUtc { get{} }
	public string Message { get{} }
	public object EventSource { get{} }
	public long EventSequence { get{} }
	public long EventOccurrence { get{} }
	public int EventCode { get{} }
	public int EventDetailCode { get{} }
	public System.Guid EventID { get{} }
}

