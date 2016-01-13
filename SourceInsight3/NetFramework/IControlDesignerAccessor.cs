public interface IControlDesignerAccessor
{

	// Methods
	public abstract virtual System.Collections.IDictionary GetDesignModeState() {}
	public abstract virtual void SetDesignModeState(System.Collections.IDictionary data) {}
	public abstract virtual void SetOwnerControl(Control owner) {}

	// Properties
	public System.Collections.IDictionary UserData { get{} }
}

