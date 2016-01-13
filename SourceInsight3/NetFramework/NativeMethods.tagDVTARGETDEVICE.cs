public class tagDVTARGETDEVICE
{

	// Constructors
	public tagDVTARGETDEVICE() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int tdSize;
	public short tdDriverNameOffset;
	public short tdDeviceNameOffset;
	public short tdPortNameOffset;
	public short tdExtDevmodeOffset;
}

