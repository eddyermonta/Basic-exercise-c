class ArrayUtilities
{

    public static int GetMax( int [] intsArray){
        validateArray(intsArray);
        return intsArray.Max(new CustomComparer());
    }

    public static int GetMin(int [] intsArray)
    {
        validateArray(intsArray);
        return intsArray.Min(new CustomComparer());
    }

    public static void validateArray(int[] intsArray){
        if(intsArray == null || intsArray.Length == 0){
            throw new ArgumentException("Array is null or empty.");
    }
    }

    public class CustomComparer : IComparer<int>{
        public int Compare(int x, int y){
            return x.CompareTo(y);
        }
    }
}