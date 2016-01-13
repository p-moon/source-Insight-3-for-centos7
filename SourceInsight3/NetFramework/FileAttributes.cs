public class FileAttributes : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public FileAttributes ReadOnly;
	public FileAttributes Hidden;
	public FileAttributes System;
	public FileAttributes Directory;
	public FileAttributes Archive;
	public FileAttributes Device;
	public FileAttributes Normal;
	public FileAttributes Temporary;
	public FileAttributes SparseFile;
	public FileAttributes ReparsePoint;
	public FileAttributes Compressed;
	public FileAttributes Offline;
	public FileAttributes NotContentIndexed;
	public FileAttributes Encrypted;
}

