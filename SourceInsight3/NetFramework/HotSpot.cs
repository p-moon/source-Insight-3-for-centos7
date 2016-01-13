public class HotSpot : System.Web.UI.IStateManager
{

	// Methods
	public abstract virtual string GetCoordinates() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AccessKey { get{} set{} }
	public string AlternateText { get{} set{} }
	public HotSpotMode HotSpotMode { get{} set{} }
	public string PostBackValue { get{} set{} }
	public string NavigateUrl { get{} set{} }
	public short TabIndex { get{} set{} }
	public string Target { get{} set{} }
}

