public interface IDictionaryEnumerator : IEnumerator
{

	// Properties
	public object Key { get{} }
	public object Value { get{} }
	public DictionaryEntry Entry { get{} }
}

