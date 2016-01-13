public class QuestionEventArgs : System.EventArgs
{

	// Constructors
	public QuestionEventArgs() {}
	public QuestionEventArgs(bool response) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Response { get{} set{} }
}

