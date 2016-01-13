public class StringFormat : System.MarshalByRefObject, System.ICloneable, System.IDisposable
{

	// Constructors
	public StringFormat() {}
	public StringFormat(StringFormatFlags options) {}
	public StringFormat(StringFormatFlags options, int language) {}
	public StringFormat(StringFormat format) {}

	// Methods
	public virtual void Dispose() {}
	public virtual object Clone() {}
	public void SetMeasurableCharacterRanges(CharacterRange[] ranges) {}
	public void SetTabStops(float firstTabOffset, float[] tabStops) {}
	public float[] GetTabStops(out System.Single& firstTabOffset) {}
	public void SetDigitSubstitution(int language, StringDigitSubstitute substitute) {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public StringFormatFlags FormatFlags { get{} set{} }
	public StringAlignment Alignment { get{} set{} }
	public StringAlignment LineAlignment { get{} set{} }
	public System.Drawing.Text.HotkeyPrefix HotkeyPrefix { get{} set{} }
	public StringTrimming Trimming { get{} set{} }
	public StringFormat GenericDefault { get{} }
	public StringFormat GenericTypographic { get{} }
	public StringDigitSubstitute DigitSubstitutionMethod { get{} }
	public int DigitSubstitutionLanguage { get{} }
}

