public class XmlSortKeyAccumulator : System.ValueType
{

	// Methods
	public void Create() {}
	public void AddStringSortKey(XmlCollation collation, string value) {}
	public void AddDecimalSortKey(XmlCollation collation, decimal value) {}
	public void AddIntegerSortKey(XmlCollation collation, long value) {}
	public void AddIntSortKey(XmlCollation collation, int value) {}
	public void AddDoubleSortKey(XmlCollation collation, double value) {}
	public void AddDateTimeSortKey(XmlCollation collation, System.DateTime value) {}
	public void AddEmptySortKey(XmlCollation collation) {}
	public void FinishSortKeys() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Array Keys { get{} }
}

