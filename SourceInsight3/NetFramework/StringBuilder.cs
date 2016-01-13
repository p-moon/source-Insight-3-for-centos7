public class StringBuilder : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public StringBuilder() {}
	public StringBuilder(int capacity) {}
	public StringBuilder(string value) {}
	public StringBuilder(string value, int capacity) {}
	public StringBuilder(string value, int startIndex, int length, int capacity) {}
	public StringBuilder(int capacity, int maxCapacity) {}

	// Methods
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) {}
	public int EnsureCapacity(int capacity) {}
	public virtual string ToString() {}
	public string ToString(int startIndex, int length) {}
	public StringBuilder Append(char value, int repeatCount) {}
	public StringBuilder Append(char[] value, int startIndex, int charCount) {}
	public StringBuilder Append(string value) {}
	public StringBuilder Append(string value, int startIndex, int count) {}
	public StringBuilder AppendLine() {}
	public StringBuilder AppendLine(string value) {}
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) {}
	public StringBuilder Insert(int index, string value, int count) {}
	public StringBuilder Remove(int startIndex, int length) {}
	public StringBuilder Append(bool value) {}
	public StringBuilder Append(System.SByte value) {}
	public StringBuilder Append(byte value) {}
	public StringBuilder Append(char value) {}
	public StringBuilder Append(short value) {}
	public StringBuilder Append(int value) {}
	public StringBuilder Append(long value) {}
	public StringBuilder Append(float value) {}
	public StringBuilder Append(double value) {}
	public StringBuilder Append(decimal value) {}
	public StringBuilder Append(ushort value) {}
	public StringBuilder Append(uint value) {}
	public StringBuilder Append(ulong value) {}
	public StringBuilder Append(object value) {}
	public StringBuilder Append(char[] value) {}
	public StringBuilder Insert(int index, string value) {}
	public StringBuilder Insert(int index, bool value) {}
	public StringBuilder Insert(int index, System.SByte value) {}
	public StringBuilder Insert(int index, byte value) {}
	public StringBuilder Insert(int index, short value) {}
	public StringBuilder Insert(int index, char value) {}
	public StringBuilder Insert(int index, char[] value) {}
	public StringBuilder Insert(int index, char[] value, int startIndex, int charCount) {}
	public StringBuilder Insert(int index, int value) {}
	public StringBuilder Insert(int index, long value) {}
	public StringBuilder Insert(int index, float value) {}
	public StringBuilder Insert(int index, double value) {}
	public StringBuilder Insert(int index, decimal value) {}
	public StringBuilder Insert(int index, ushort value) {}
	public StringBuilder Insert(int index, uint value) {}
	public StringBuilder Insert(int index, ulong value) {}
	public StringBuilder Insert(int index, object value) {}
	public StringBuilder AppendFormat(string format, object arg0) {}
	public StringBuilder AppendFormat(string format, object arg0, object arg1) {}
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) {}
	public StringBuilder AppendFormat(string format, object[] args) {}
	public StringBuilder AppendFormat(System.IFormatProvider provider, string format, object[] args) {}
	public StringBuilder Replace(string oldValue, string newValue) {}
	public bool Equals(StringBuilder sb) {}
	public StringBuilder Replace(char oldChar, char newChar) {}
	public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int MaxCapacity { get{} }
	public int Length { get{} set{} }
	public char Chars { get{} set{} }
}

