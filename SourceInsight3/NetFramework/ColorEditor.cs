public class ColorEditor : UITypeEditor
{

	// Constructors
	public ColorEditor() {}

	// Methods
	public virtual object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) {}
	public virtual UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual void PaintValue(PaintValueEventArgs e) {}
	public object EditValue(System.IServiceProvider provider, object value) {}
	public UITypeEditorEditStyle GetEditStyle() {}
	public bool GetPaintValueSupported() {}
	public void PaintValue(object value, System.Drawing.Graphics canvas, System.Drawing.Rectangle rectangle) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDropDownResizable { get{} }
}

