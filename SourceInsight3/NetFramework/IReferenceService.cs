public interface IReferenceService
{

	// Methods
	public abstract virtual System.ComponentModel.IComponent GetComponent(object reference) {}
	public abstract virtual object GetReference(string name) {}
	public abstract virtual string GetName(object reference) {}
	public abstract virtual object[] GetReferences() {}
	public abstract virtual object[] GetReferences(Type baseType) {}
}

