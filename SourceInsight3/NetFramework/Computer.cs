public class Computer : ServerComputer
{

	// Constructors
	public Computer() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Audio Audio { get{} }
	public Microsoft.VisualBasic.MyServices.ClipboardProxy Clipboard { get{} }
	public Ports Ports { get{} }
	public Mouse Mouse { get{} }
	public Keyboard Keyboard { get{} }
	public System.Windows.Forms.Screen Screen { get{} }
	public Clock Clock { get{} }
	public Microsoft.VisualBasic.MyServices.FileSystemProxy FileSystem { get{} }
	public ComputerInfo Info { get{} }
	public Network Network { get{} }
	public string Name { get{} }
	public Microsoft.VisualBasic.MyServices.RegistryProxy Registry { get{} }
}

