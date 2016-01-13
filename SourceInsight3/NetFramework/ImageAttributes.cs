public class ImageAttributes : System.ICloneable, System.IDisposable
{

	// Constructors
	public ImageAttributes() {}

	// Methods
	public virtual void Dispose() {}
	public virtual object Clone() {}
	public void SetColorMatrix(ColorMatrix newColorMatrix) {}
	public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag flags) {}
	public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag mode, ColorAdjustType type) {}
	public void ClearColorMatrix() {}
	public void ClearColorMatrix(ColorAdjustType type) {}
	public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix) {}
	public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag flags) {}
	public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag mode, ColorAdjustType type) {}
	public void SetThreshold(float threshold) {}
	public void SetThreshold(float threshold, ColorAdjustType type) {}
	public void ClearThreshold() {}
	public void ClearThreshold(ColorAdjustType type) {}
	public void SetGamma(float gamma) {}
	public void SetGamma(float gamma, ColorAdjustType type) {}
	public void ClearGamma() {}
	public void ClearGamma(ColorAdjustType type) {}
	public void SetNoOp() {}
	public void SetNoOp(ColorAdjustType type) {}
	public void ClearNoOp() {}
	public void ClearNoOp(ColorAdjustType type) {}
	public void SetColorKey(System.Drawing.Color colorLow, System.Drawing.Color colorHigh) {}
	public void SetColorKey(System.Drawing.Color colorLow, System.Drawing.Color colorHigh, ColorAdjustType type) {}
	public void ClearColorKey() {}
	public void ClearColorKey(ColorAdjustType type) {}
	public void SetOutputChannel(ColorChannelFlag flags) {}
	public void SetOutputChannel(ColorChannelFlag flags, ColorAdjustType type) {}
	public void ClearOutputChannel() {}
	public void ClearOutputChannel(ColorAdjustType type) {}
	public void SetOutputChannelColorProfile(string colorProfileFilename) {}
	public void SetOutputChannelColorProfile(string colorProfileFilename, ColorAdjustType type) {}
	public void ClearOutputChannelColorProfile() {}
	public void ClearOutputChannelColorProfile(ColorAdjustType type) {}
	public void SetRemapTable(ColorMap[] map) {}
	public void SetRemapTable(ColorMap[] map, ColorAdjustType type) {}
	public void ClearRemapTable() {}
	public void ClearRemapTable(ColorAdjustType type) {}
	public void SetBrushRemapTable(ColorMap[] map) {}
	public void ClearBrushRemapTable() {}
	public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode) {}
	public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode, System.Drawing.Color color) {}
	public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode, System.Drawing.Color color, bool clamp) {}
	public void GetAdjustedPalette(ColorPalette palette, ColorAdjustType type) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

