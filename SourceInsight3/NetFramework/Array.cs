public class Array : ICloneable, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) {}
	public static void Resize<T>(T[]& array, int newSize) {}
	public static int BinarySearch<T>(T[] array, T value) {}
	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) {}
	public static int BinarySearch<T>(T[] array, int index, int length, T value) {}
	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) {}
	public static TOutput[] ConvertAll<TInput><TOutput>(TInput[] array, Converter<TInput,TOutput> converter) {}
	public static bool Exists<T>(T[] array, Predicate<T> match) {}
	public static T Find<T>(T[] array, Predicate<T> match) {}
	public static T[] FindAll<T>(T[] array, Predicate<T> match) {}
	public static int FindIndex<T>(T[] array, Predicate<T> match) {}
	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) {}
	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) {}
	public static T FindLast<T>(T[] array, Predicate<T> match) {}
	public static int FindLastIndex<T>(T[] array, Predicate<T> match) {}
	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) {}
	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) {}
	public static void ForEach<T>(T[] array, Action<T> action) {}
	public static int IndexOf<T>(T[] array, T value) {}
	public static int IndexOf<T>(T[] array, T value, int startIndex) {}
	public static int IndexOf<T>(T[] array, T value, int startIndex, int count) {}
	public static int LastIndexOf<T>(T[] array, T value) {}
	public static int LastIndexOf<T>(T[] array, T value, int startIndex) {}
	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) {}
	public static void Sort<T>(T[] array) {}
	public static void Sort<TKey><TValue>(TKey[] keys, TValue[] items) {}
	public static void Sort<T>(T[] array, int index, int length) {}
	public static void Sort<TKey><TValue>(TKey[] keys, TValue[] items, int index, int length) {}
	public static void Sort<TKey><TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) {}
	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) {}
	public static void Sort<TKey><TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) {}
	public static void Sort<T>(T[] array, Comparison<T> comparison) {}
	public static bool TrueForAll<T>(T[] array, Predicate<T> match) {}
	public static void Sort<T>(T[] array, IComparer<T> comparer) {}
	public static void Clear(Array array, int index, int length) {}
	public int GetLength(int dimension) {}
	public int GetUpperBound(int dimension) {}
	public int GetLowerBound(int dimension) {}
	public void Initialize() {}
	public static Array CreateInstance(Type elementType, int length) {}
	public static Array CreateInstance(Type elementType, int length1, int length2) {}
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) {}
	public static Array CreateInstance(Type elementType, int[] lengths) {}
	public static Array CreateInstance(Type elementType, long[] lengths) {}
	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds) {}
	public static void Copy(Array sourceArray, Array destinationArray, int length) {}
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {}
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {}
	public static void Copy(Array sourceArray, Array destinationArray, long length) {}
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) {}
	public object GetValue(int[] indices) {}
	public object GetValue(int index) {}
	public object GetValue(int index1, int index2) {}
	public object GetValue(int index1, int index2, int index3) {}
	public object GetValue(long index) {}
	public object GetValue(long index1, long index2) {}
	public object GetValue(long index1, long index2, long index3) {}
	public object GetValue(long[] indices) {}
	public void SetValue(object value, int index) {}
	public void SetValue(object value, int index1, int index2) {}
	public void SetValue(object value, int index1, int index2, int index3) {}
	public void SetValue(object value, int[] indices) {}
	public void SetValue(object value, long index) {}
	public void SetValue(object value, long index1, long index2) {}
	public void SetValue(object value, long index1, long index2, long index3) {}
	public void SetValue(object value, long[] indices) {}
	public long GetLongLength(int dimension) {}
	public virtual object Clone() {}
	public static int BinarySearch(Array array, object value) {}
	public static int BinarySearch(Array array, int index, int length, object value) {}
	public static int BinarySearch(Array array, object value, System.Collections.IComparer comparer) {}
	public static int BinarySearch(Array array, int index, int length, object value, System.Collections.IComparer comparer) {}
	public virtual void CopyTo(Array array, int index) {}
	public void CopyTo(Array array, long index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public static int IndexOf(Array array, object value) {}
	public static int IndexOf(Array array, object value, int startIndex) {}
	public static int IndexOf(Array array, object value, int startIndex, int count) {}
	public static int LastIndexOf(Array array, object value) {}
	public static int LastIndexOf(Array array, object value, int startIndex) {}
	public static int LastIndexOf(Array array, object value, int startIndex, int count) {}
	public static void Reverse(Array array) {}
	public static void Reverse(Array array, int index, int length) {}
	public static void Sort(Array array) {}
	public static void Sort(Array keys, Array items) {}
	public static void Sort(Array array, int index, int length) {}
	public static void Sort(Array keys, Array items, int index, int length) {}
	public static void Sort(Array array, System.Collections.IComparer comparer) {}
	public static void Sort(Array keys, Array items, System.Collections.IComparer comparer) {}
	public static void Sort(Array array, int index, int length, System.Collections.IComparer comparer) {}
	public static void Sort(Array keys, Array items, int index, int length, System.Collections.IComparer comparer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Length { get{} }
	public long LongLength { get{} }
	public int Rank { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public bool IsSynchronized { get{} }
}

