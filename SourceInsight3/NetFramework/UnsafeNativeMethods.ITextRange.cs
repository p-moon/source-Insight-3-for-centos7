public interface ITextRange
{

	// Methods
	public abstract virtual string GetText() {}
	public abstract virtual void SetText(string text) {}
	public abstract virtual object GetChar() {}
	public abstract virtual void SetChar(object ch) {}
	public abstract virtual ITextRange GetDuplicate() {}
	public abstract virtual ITextRange GetFormattedText() {}
	public abstract virtual void SetFormattedText(ITextRange range) {}
	public abstract virtual int GetStart() {}
	public abstract virtual void SetStart(int cpFirst) {}
	public abstract virtual int GetEnd() {}
	public abstract virtual void SetEnd(int cpLim) {}
	public abstract virtual object GetFont() {}
	public abstract virtual void SetFont(object font) {}
	public abstract virtual object GetPara() {}
	public abstract virtual void SetPara(object para) {}
	public abstract virtual int GetStoryLength() {}
	public abstract virtual int GetStoryType() {}
	public abstract virtual void Collapse(int start) {}
	public abstract virtual int Expand(int unit) {}
	public abstract virtual int GetIndex(int unit) {}
	public abstract virtual void SetIndex(int unit, int index, int extend) {}
	public abstract virtual void SetRange(int cpActive, int cpOther) {}
	public abstract virtual int InRange(ITextRange range) {}
	public abstract virtual int InStory(ITextRange range) {}
	public abstract virtual int IsEqual(ITextRange range) {}
	public abstract virtual void Select() {}
	public abstract virtual int StartOf(int unit, int extend) {}
	public abstract virtual int EndOf(int unit, int extend) {}
	public abstract virtual int Move(int unit, int count) {}
	public abstract virtual int MoveStart(int unit, int count) {}
	public abstract virtual int MoveEnd(int unit, int count) {}
	public abstract virtual int MoveWhile(object cset, int count) {}
	public abstract virtual int MoveStartWhile(object cset, int count) {}
	public abstract virtual int MoveEndWhile(object cset, int count) {}
	public abstract virtual int MoveUntil(object cset, int count) {}
	public abstract virtual int MoveStartUntil(object cset, int count) {}
	public abstract virtual int MoveEndUntil(object cset, int count) {}
	public abstract virtual int FindText(string text, int cch, int flags) {}
	public abstract virtual int FindTextStart(string text, int cch, int flags) {}
	public abstract virtual int FindTextEnd(string text, int cch, int flags) {}
	public abstract virtual int Delete(int unit, int count) {}
	public abstract virtual void Cut(out System.Object& pVar) {}
	public abstract virtual void Copy(out System.Object& pVar) {}
	public abstract virtual void Paste(object pVar, int format) {}
	public abstract virtual int CanPaste(object pVar, int format) {}
	public abstract virtual int CanEdit() {}
	public abstract virtual void ChangeCase(int type) {}
	public abstract virtual void GetPoint(int typeout , System.Int32& xout , System.Int32& y) {}
	public abstract virtual void SetPoint(int x, int y, int type, int extend) {}
	public abstract virtual void ScrollIntoView(int value) {}
	public abstract virtual object GetEmbeddedObject() {}
}

