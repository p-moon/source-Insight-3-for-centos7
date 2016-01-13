public class CrossDomainMoveControl : DirectoryControl
{

	// Constructors
	public CrossDomainMoveControl() {}
	public CrossDomainMoveControl(string targetDomainController) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TargetDomainController { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

