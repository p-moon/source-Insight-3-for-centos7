public class TVSORTCB : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public System.IntPtr hParent;
	public TreeViewCompareCallback lpfnCompare;
	public System.IntPtr lParam;
}

