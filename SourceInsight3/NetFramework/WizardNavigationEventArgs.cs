public class WizardNavigationEventArgs : System.EventArgs
{

	// Constructors
	public WizardNavigationEventArgs(int currentStepIndex, int nextStepIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancel { get{} set{} }
	public int CurrentStepIndex { get{} }
	public int NextStepIndex { get{} }
}

