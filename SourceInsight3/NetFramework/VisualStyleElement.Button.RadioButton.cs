public class RadioButton
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VisualStyleElement UncheckedNormal { get{} }
	public VisualStyleElement UncheckedHot { get{} }
	public VisualStyleElement UncheckedPressed { get{} }
	public VisualStyleElement UncheckedDisabled { get{} }
	public VisualStyleElement CheckedNormal { get{} }
	public VisualStyleElement CheckedHot { get{} }
	public VisualStyleElement CheckedPressed { get{} }
	public VisualStyleElement CheckedDisabled { get{} }
}

