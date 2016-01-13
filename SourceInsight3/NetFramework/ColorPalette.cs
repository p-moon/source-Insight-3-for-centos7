public class ColorPalette
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Flags { get{} }
	public System.Drawing.Color[] Entries { get{} }
}

