public class HitTestInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Point Point { get{} }
	public HitArea HitArea { get{} }
	public System.DateTime Time { get{} }
}

