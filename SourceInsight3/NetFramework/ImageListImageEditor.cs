public class ImageListImageEditor : System.Drawing.Design.ImageEditor
{

	// Constructors
	public ImageListImageEditor() {}

	// Methods
	public virtual object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) {}
	public virtual bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) {}
	public virtual void PaintValue(System.Drawing.Design.PaintValueEventArgs e) {}
	public virtual System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) {}
	public object EditValue(System.IServiceProvider provider, object value) {}
	public System.Drawing.Design.UITypeEditorEditStyle GetEditStyle() {}
	public bool GetPaintValueSupported() {}
	public void PaintValue(object value, System.Drawing.Graphics canvas, System.Drawing.Rectangle rectangle) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDropDownResizable { get{} }
}

