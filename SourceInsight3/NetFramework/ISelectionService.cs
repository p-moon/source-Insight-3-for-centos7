public interface ISelectionService
{

	// Methods
	public abstract virtual bool GetComponentSelected(object component) {}
	public abstract virtual System.Collections.ICollection GetSelectedComponents() {}
	public abstract virtual void SetSelectedComponents(System.Collections.ICollection components) {}
	public abstract virtual void SetSelectedComponents(System.Collections.ICollection components, SelectionTypes selectionType) {}

	// Properties
	public object PrimarySelection { get{} }
	public int SelectionCount { get{} }

	// Events
	public event System.EventHandler SelectionChanged;
	public event System.EventHandler SelectionChanging;
}

