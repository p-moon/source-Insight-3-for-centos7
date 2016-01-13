public class CursorEditor : UITypeEditor
{

	// Constructors
	public CursorEditor() {}

	// Methods
	public virtual object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) {}
	public virtual UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) {}
	public object EditValue(System.IServiceProvider provider, object value) {}
	public UITypeEditorEditStyle GetEditStyle() {}
	public bool GetPaintValueSupported() {}
	public virtual bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public void PaintValue(object value, System.Drawing.Graphics canvas, System.Drawing.Rectangle rectangle) {}
	public virtual void PaintValue(PaintValueEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDropDownResizable { get{} }
}

