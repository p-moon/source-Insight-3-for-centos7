public interface ITextDocument
{

	// Methods
	public abstract virtual string GetName() {}
	public abstract virtual object GetSelection() {}
	public abstract virtual int GetStoryCount() {}
	public abstract virtual object GetStoryRanges() {}
	public abstract virtual int GetSaved() {}
	public abstract virtual void SetSaved(int value) {}
	public abstract virtual object GetDefaultTabStop() {}
	public abstract virtual void SetDefaultTabStop(object value) {}
	public abstract virtual void New() {}
	public abstract virtual void Open(object pVar, int flags, int codePage) {}
	public abstract virtual void Save(object pVar, int flags, int codePage) {}
	public abstract virtual int Freeze() {}
	public abstract virtual int Unfreeze() {}
	public abstract virtual void BeginEditCollection() {}
	public abstract virtual void EndEditCollection() {}
	public abstract virtual int Undo(int count) {}
	public abstract virtual int Redo(int count) {}
	public abstract virtual ITextRange Range(int cp1, int cp2) {}
	public abstract virtual ITextRange RangeFromPoint(int x, int y) {}
}

