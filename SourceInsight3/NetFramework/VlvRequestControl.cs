public class VlvRequestControl : DirectoryControl
{

	// Constructors
	public VlvRequestControl() {}
	public VlvRequestControl(int beforeCount, int afterCount, int offset) {}
	public VlvRequestControl(int beforeCount, int afterCount, string target) {}
	public VlvRequestControl(int beforeCount, int afterCount, byte[] target) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int BeforeCount { get{} set{} }
	public int AfterCount { get{} set{} }
	public int Offset { get{} set{} }
	public int EstimateCount { get{} set{} }
	public byte[] Target { get{} set{} }
	public byte[] ContextId { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

