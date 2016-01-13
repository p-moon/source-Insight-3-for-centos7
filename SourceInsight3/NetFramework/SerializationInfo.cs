public class SerializationInfo
{

	// Constructors
	public SerializationInfo(Type type, IFormatterConverter converter) {}

	// Methods
	public void SetType(Type type) {}
	public SerializationInfoEnumerator GetEnumerator() {}
	public void AddValue(string name, object value, Type type) {}
	public void AddValue(string name, object value) {}
	public void AddValue(string name, bool value) {}
	public void AddValue(string name, char value) {}
	public void AddValue(string name, System.SByte value) {}
	public void AddValue(string name, byte value) {}
	public void AddValue(string name, short value) {}
	public void AddValue(string name, ushort value) {}
	public void AddValue(string name, int value) {}
	public void AddValue(string name, uint value) {}
	public void AddValue(string name, long value) {}
	public void AddValue(string name, ulong value) {}
	public void AddValue(string name, float value) {}
	public void AddValue(string name, double value) {}
	public void AddValue(string name, decimal value) {}
	public void AddValue(string name, System.DateTime value) {}
	public object GetValue(string name, Type type) {}
	public bool GetBoolean(string name) {}
	public char GetChar(string name) {}
	public System.SByte GetSByte(string name) {}
	public byte GetByte(string name) {}
	public short GetInt16(string name) {}
	public ushort GetUInt16(string name) {}
	public int GetInt32(string name) {}
	public uint GetUInt32(string name) {}
	public long GetInt64(string name) {}
	public ulong GetUInt64(string name) {}
	public float GetSingle(string name) {}
	public double GetDouble(string name) {}
	public decimal GetDecimal(string name) {}
	public System.DateTime GetDateTime(string name) {}
	public string GetString(string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FullTypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
	public int MemberCount { get{} }
}

