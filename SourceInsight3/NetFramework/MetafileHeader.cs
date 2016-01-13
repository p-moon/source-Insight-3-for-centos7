public class MetafileHeader
{

	// Methods
	public bool IsWmf() {}
	public bool IsWmfPlaceable() {}
	public bool IsEmf() {}
	public bool IsEmfOrEmfPlus() {}
	public bool IsEmfPlus() {}
	public bool IsEmfPlusDual() {}
	public bool IsEmfPlusOnly() {}
	public bool IsDisplay() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MetafileType Type { get{} }
	public int MetafileSize { get{} }
	public int Version { get{} }
	public float DpiX { get{} }
	public float DpiY { get{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public MetaHeader WmfHeader { get{} }
	public int EmfPlusHeaderSize { get{} }
	public int LogicalDpiX { get{} }
	public int LogicalDpiY { get{} }
}

