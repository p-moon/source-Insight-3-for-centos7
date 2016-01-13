public interface IColorizeText
{

	// Methods
	public abstract virtual ITokenEnumerator Colorize(string sourceCode, SourceState state) {}
	public abstract virtual SourceState GetStateForText(string sourceCode, SourceState currentState) {}
}

