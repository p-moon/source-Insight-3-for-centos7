public class SearchForVirtualItemEventArgs : System.EventArgs
{

	// Constructors
	public SearchForVirtualItemEventArgs(bool isTextSearch, bool isPrefixSearch, bool includeSubItemsInSearch, string text, System.Drawing.Point startingPoint, SearchDirectionHint direction, int startIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsTextSearch { get{} }
	public bool IncludeSubItemsInSearch { get{} }
	public int Index { get{} set{} }
	public bool IsPrefixSearch { get{} }
	public string Text { get{} }
	public System.Drawing.Point StartingPoint { get{} }
	public SearchDirectionHint Direction { get{} }
	public int StartIndex { get{} }
}

