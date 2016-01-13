public class ServerComputer
{

	// Constructors
	public ServerComputer() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Clock Clock { get{} }
	public Microsoft.VisualBasic.MyServices.FileSystemProxy FileSystem { get{} }
	public ComputerInfo Info { get{} }
	public Network Network { get{} }
	public string Name { get{} }
	public Microsoft.VisualBasic.MyServices.RegistryProxy Registry { get{} }
}

