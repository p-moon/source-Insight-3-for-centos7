public class ResXDataNode : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ResXDataNode(string name, object value) {}
	public ResXDataNode(string name, ResXFileRef fileRef) {}

	// Methods
	public System.Drawing.Point GetNodePosition() {}
	public string GetValueTypeName(System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public string GetValueTypeName(System.Reflection.AssemblyName[] names) {}
	public object GetValue(System.ComponentModel.Design.ITypeResolutionService typeResolver) {}
	public object GetValue(System.Reflection.AssemblyName[] names) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Comment { get{} set{} }
	public string Name { get{} set{} }
	public ResXFileRef FileRef { get{} }
}

