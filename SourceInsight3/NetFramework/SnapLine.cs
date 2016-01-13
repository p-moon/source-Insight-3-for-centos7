public class SnapLine
{

	// Constructors
	public SnapLine(SnapLineType type, int offset) {}
	public SnapLine(SnapLineType type, int offset, string filter) {}
	public SnapLine(SnapLineType type, int offset, SnapLinePriority priority) {}
	public SnapLine(SnapLineType type, int offset, string filter, SnapLinePriority priority) {}

	// Methods
	public void AdjustOffset(int adjustment) {}
	public static bool ShouldSnap(SnapLine line1, SnapLine line2) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Filter { get{} }
	public bool IsHorizontal { get{} }
	public bool IsVertical { get{} }
	public int Offset { get{} }
	public SnapLinePriority Priority { get{} }
	public SnapLineType SnapLineType { get{} }
}

