public class DesignerOptions
{

	// Constructors
	public DesignerOptions() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Size GridSize { get{} set{} }
	public bool ShowGrid { get{} set{} }
	public bool SnapToGrid { get{} set{} }
	public bool UseSnapLines { get{} set{} }
	public bool UseSmartTags { get{} set{} }
	public bool ObjectBoundSmartTagAutoShow { get{} set{} }
	public bool UseOptimizedCodeGeneration { get{} set{} }
	public bool EnableInSituEditing { get{} set{} }
}

