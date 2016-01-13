public class DesignerTransaction : System.IDisposable
{

	// Methods
	public void Cancel() {}
	public void Commit() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Canceled { get{} }
	public bool Committed { get{} }
	public string Description { get{} }
}

