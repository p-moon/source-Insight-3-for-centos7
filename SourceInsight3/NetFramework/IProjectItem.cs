public interface IProjectItem
{

	// Properties
	public string AppRelativeUrl { get{} }
	public string Name { get{} }
	public IProjectItem Parent { get{} }
	public string PhysicalPath { get{} }
}

