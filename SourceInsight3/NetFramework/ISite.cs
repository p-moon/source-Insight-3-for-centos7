public interface ISite : System.IServiceProvider
{

	// Properties
	public IComponent Component { get{} }
	public IContainer Container { get{} }
	public bool DesignMode { get{} }
	public string Name { get{} set{} }
}

