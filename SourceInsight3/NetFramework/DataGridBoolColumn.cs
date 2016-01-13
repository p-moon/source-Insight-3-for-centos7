public class DataGridBoolColumn : DataGridColumnStyle, System.ComponentModel.IComponent, System.IDisposable, IDataGridColumnStyleEditingNotificationService
{

	// Constructors
	public DataGridBoolColumn() {}
	public DataGridBoolColumn(System.ComponentModel.PropertyDescriptor prop) {}
	public DataGridBoolColumn(System.ComponentModel.PropertyDescriptor prop, bool isDefault) {}

	// Methods
	public void ResetHeaderText() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object TrueValue { get{} set{} }
	public object FalseValue { get{} set{} }
	public object NullValue { get{} set{} }
	public bool AllowNull { get{} set{} }
	public HorizontalAlignment Alignment { get{} set{} }
	public AccessibleObject HeaderAccessibleObject { get{} }
	public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get{} set{} }
	public DataGridTableStyle DataGridTableStyle { get{} }
	public string HeaderText { get{} set{} }
	public string MappingName { get{} set{} }
	public string NullText { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public int Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler TrueValueChanged;
	public event System.EventHandler FalseValueChanged;
	public event System.EventHandler AllowNullChanged;
	public event System.EventHandler AlignmentChanged;
	public event System.EventHandler PropertyDescriptorChanged;
	public event System.EventHandler FontChanged;
	public event System.EventHandler HeaderTextChanged;
	public event System.EventHandler MappingNameChanged;
	public event System.EventHandler NullTextChanged;
	public event System.EventHandler ReadOnlyChanged;
	public event System.EventHandler WidthChanged;
	public event System.EventHandler Disposed;
}

