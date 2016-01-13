public class WebPartMovingEventArgs : WebPartCancelEventArgs
{

	// Constructors
	public WebPartMovingEventArgs(WebPart webPart, WebPartZoneBase zone, int zoneIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartZoneBase Zone { get{} set{} }
	public int ZoneIndex { get{} set{} }
	public WebPart WebPart { get{} set{} }
	public bool Cancel { get{} set{} }
}

