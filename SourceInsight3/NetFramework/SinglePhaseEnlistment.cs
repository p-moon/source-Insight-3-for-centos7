public class SinglePhaseEnlistment : Enlistment
{

	// Methods
	public void Aborted() {}
	public void Aborted(System.Exception e) {}
	public void Committed() {}
	public void InDoubt() {}
	public void InDoubt(System.Exception e) {}
	public void Done() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

