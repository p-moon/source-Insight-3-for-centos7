public interface IWebFormsDocumentService
{

	// Methods
	public abstract virtual object CreateDiscardableUndoUnit() {}
	public abstract virtual void DiscardUndoUnit(object discardableUndoUnit) {}
	public abstract virtual void EnableUndo(bool enable) {}
	public abstract virtual void UpdateSelection() {}

	// Properties
	public string DocumentUrl { get{} }
	public bool IsLoading { get{} }

	// Events
	public event System.EventHandler LoadComplete;
}

