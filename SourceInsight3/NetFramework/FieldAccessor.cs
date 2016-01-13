public class FieldAccessor
{

	// Methods
	public abstract virtual object GetValue(object thisob) {}
	public abstract virtual void SetValue(object thisob, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

