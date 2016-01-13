public interface IPropertyNotifySink
{

	// Methods
	public abstract virtual void OnChanged(int dispID) {}
	public abstract virtual int OnRequestEdit(int dispID) {}
}

