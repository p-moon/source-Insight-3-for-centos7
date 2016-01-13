public class ObjectSelectorEditor : System.Drawing.Design.UITypeEditor
{

	// Constructors
	public ObjectSelectorEditor() {}
	public ObjectSelectorEditor(bool subObjectSelector) {}

	// Methods
	public virtual object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) {}
	public virtual System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) {}
	public bool EqualsToValue(object value) {}
	public virtual void SetValue(object value) {}
	public object EditValue(System.IServiceProvider provider, object value) {}
	public System.Drawing.Design.UITypeEditorEditStyle GetEditStyle() {}
	public bool GetPaintValueSupported() {}
	public virtual bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public void PaintValue(object value, System.Drawing.Graphics canvas, System.Drawing.Rectangle rectangle) {}
	public virtual void PaintValue(System.Drawing.Design.PaintValueEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public bool SubObjectSelector;

	// Properties
	public bool IsDropDownResizable { get{} }
}

