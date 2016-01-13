public class RectangleHotSpot : HotSpot, System.Web.UI.IStateManager
{

	// Constructors
	public RectangleHotSpot() {}

	// Methods
	public virtual string GetCoordinates() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Bottom { get{} set{} }
	public int Left { get{} set{} }
	public int Right { get{} set{} }
	public int Top { get{} set{} }
	public string AccessKey { get{} set{} }
	public string AlternateText { get{} set{} }
	public HotSpotMode HotSpotMode { get{} set{} }
	public string PostBackValue { get{} set{} }
	public string NavigateUrl { get{} set{} }
	public short TabIndex { get{} set{} }
	public string Target { get{} set{} }
}

