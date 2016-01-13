public class ValidatePasswordEventArgs : System.EventArgs
{

	// Constructors
	public ValidatePasswordEventArgs(string userName, string password, bool isNewUser) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string UserName { get{} }
	public string Password { get{} }
	public bool IsNewUser { get{} }
	public bool Cancel { get{} set{} }
	public System.Exception FailureInformation { get{} set{} }
}

