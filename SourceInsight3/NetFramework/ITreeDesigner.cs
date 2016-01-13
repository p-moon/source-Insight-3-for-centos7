public interface ITreeDesigner : IDesigner, System.IDisposable
{

	// Properties
	public System.Collections.ICollection Children { get{} }
	public IDesigner Parent { get{} }
}

