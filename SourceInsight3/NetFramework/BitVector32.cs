public class BitVector32 : System.ValueType
{

	// Constructors
	public BitVector32(int data) {}
	public BitVector32(BitVector32 value) {}

	// Methods
	public static int CreateMask() {}
	public static int CreateMask(int previous) {}
	public static Section CreateSection(short maxValue) {}
	public static Section CreateSection(short maxValue, Section previous) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public static string ToString(BitVector32 value) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public bool Item { get{} set{} }
	public int Item { get{} set{} }
	public int Data { get{} }
}

