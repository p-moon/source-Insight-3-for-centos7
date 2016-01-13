public interface IEditableObject
{

	// Methods
	public abstract virtual void BeginEdit() {}
	public abstract virtual void EndEdit() {}
	public abstract virtual void CancelEdit() {}
}

