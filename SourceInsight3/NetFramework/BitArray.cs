public class BitArray : ICollection, IEnumerable, System.ICloneable
{

	// Constructors
	public BitArray(int length) {}
	public BitArray(int length, bool defaultValue) {}
	public BitArray(byte[] bytes) {}
	public BitArray(bool[] values) {}
	public BitArray(int[] values) {}
	public BitArray(BitArray bits) {}

	// Methods
	public bool Get(int index) {}
	public void Set(int index, bool value) {}
	public void SetAll(bool value) {}
	public BitArray And(BitArray value) {}
	public BitArray Or(BitArray value) {}
	public BitArray Xor(BitArray value) {}
	public BitArray Not() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual object Clone() {}
	public virtual IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Item { get{} set{} }
	public int Length { get{} set{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}

