public class WmfPlaceableFileHeader
{

	// Constructors
	public WmfPlaceableFileHeader() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Key { get{} set{} }
	public short Hmf { get{} set{} }
	public short BboxLeft { get{} set{} }
	public short BboxTop { get{} set{} }
	public short BboxRight { get{} set{} }
	public short BboxBottom { get{} set{} }
	public short Inch { get{} set{} }
	public int Reserved { get{} set{} }
	public short Checksum { get{} set{} }
}

