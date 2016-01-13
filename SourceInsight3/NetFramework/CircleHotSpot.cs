public class CircleHotSpot : HotSpot, System.Web.UI.IStateManager
{

	// Constructors
	public CircleHotSpot() {}

	// Methods
	public virtual string GetCoordinates() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Radius { get{} set{} }
	public int X { get{} set{} }
	public int Y { get{} set{} }
	public string AccessKey { get{} set{} }
	public string AlternateText { get{} set{} }
	public HotSpotMode HotSpotMode { get{} set{} }
	public string PostBackValue { get{} set{} }
	public string NavigateUrl { get{} set{} }
	public short TabIndex { get{} set{} }
	public string Target { get{} set{} }
}

