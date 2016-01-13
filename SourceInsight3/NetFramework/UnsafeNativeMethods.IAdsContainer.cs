public interface IAdsContainer
{

	// Methods
	public abstract virtual object GetObject(string className, string relativeName) {}
	public abstract virtual object Create(string className, string relativeName) {}
	public abstract virtual void Delete(string className, string relativeName) {}
	public abstract virtual object CopyHere(string sourceName, string newName) {}
	public abstract virtual object MoveHere(string sourceName, string newName) {}

	// Properties
	public int Count { get{} }
	public object _NewEnum { get{} }
	public object Filter { get{} set{} }
	public object Hints { get{} set{} }
}

