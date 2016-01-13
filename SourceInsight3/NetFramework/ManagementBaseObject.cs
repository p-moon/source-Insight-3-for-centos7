public class ManagementBaseObject : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Methods
	public void Dispose() {}
	public static System.IntPtr op_Explicit(ManagementBaseObject managementObject) {}
	public virtual object Clone() {}
	public object GetPropertyValue(string propertyName) {}
	public object GetQualifierValue(string qualifierName) {}
	public void SetQualifierValue(string qualifierName, object qualifierValue) {}
	public object GetPropertyQualifierValue(string propertyName, string qualifierName) {}
	public void SetPropertyQualifierValue(string propertyName, string qualifierName, object qualifierValue) {}
	public string GetText(TextFormat format) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public bool CompareTo(ManagementBaseObject otherObject, ComparisonSettings settings) {}
	public void SetPropertyValue(string propertyName, object propertyValue) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}

	// Properties
	public PropertyDataCollection Properties { get{} }
	public PropertyDataCollection SystemProperties { get{} }
	public QualifierDataCollection Qualifiers { get{} }
	public ManagementPath ClassPath { get{} }
	public object Item { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

