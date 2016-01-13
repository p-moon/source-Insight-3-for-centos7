public class Audio
{

	// Constructors
	public Audio() {}

	// Methods
	public void Play(string location) {}
	public void Play(string location, Microsoft.VisualBasic.AudioPlayMode playMode) {}
	public void Play(byte[] data, Microsoft.VisualBasic.AudioPlayMode playMode) {}
	public void Play(System.IO.Stream stream, Microsoft.VisualBasic.AudioPlayMode playMode) {}
	public void PlaySystemSound(System.Media.SystemSound systemSound) {}
	public void Stop() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

