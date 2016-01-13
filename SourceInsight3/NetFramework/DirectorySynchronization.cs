public class DirectorySynchronization
{

	// Constructors
	public DirectorySynchronization() {}
	public DirectorySynchronization(DirectorySynchronizationOptions option) {}
	public DirectorySynchronization(DirectorySynchronization sync) {}
	public DirectorySynchronization(byte[] cookie) {}
	public DirectorySynchronization(DirectorySynchronizationOptions option, byte[] cookie) {}

	// Methods
	public byte[] GetDirectorySynchronizationCookie() {}
	public void ResetDirectorySynchronizationCookie() {}
	public void ResetDirectorySynchronizationCookie(byte[] cookie) {}
	public DirectorySynchronization Copy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectorySynchronizationOptions Option { get{} set{} }
}

