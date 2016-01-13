public class NameMap
{

	// Constructors
	public NameMap(string Name, uint Mask) {}

	// Methods
	public static uint MapNameToMask(string name, NameMap[] nmArray) {}
	public static string MapMaskToName(uint mask, NameMap[] nmArray) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string name;
	public uint mask;
}

