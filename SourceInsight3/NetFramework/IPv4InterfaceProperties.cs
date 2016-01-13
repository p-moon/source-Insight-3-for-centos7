public class IPv4InterfaceProperties
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UsesWins { get{} }
	public bool IsDhcpEnabled { get{} }
	public bool IsAutomaticPrivateAddressingActive { get{} }
	public bool IsAutomaticPrivateAddressingEnabled { get{} }
	public int Index { get{} }
	public bool IsForwardingEnabled { get{} }
	public int Mtu { get{} }
}

