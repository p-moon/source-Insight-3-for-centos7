public interface IVsaDTEngine
{

	// Methods
	public abstract virtual void InitCompleted() {}
	public abstract virtual IVsaIDE GetIDE() {}
	public abstract virtual void AttachDebugger(bool isAttach) {}

	// Properties
	public string TargetURL { get{} set{} }
}

