class Program
{
    static void Main()
    {
        char[] array = { 'a', 'b', 'c', 'd', 'e' };
        int[] permutation = { 4, 3, 1, 2, 0 };

        array = ApplyPermutation(array, permutation);
        Array.ForEach(array, Console.WriteLine);
    }
    static char[] ApplyPermutation(char[] array, int[] permutation)
    {
        for (int i = 0; i < array.Length; i++)
        {
            char holder = array[permutation[i]];
            array[permutation[i]] = array[i];
            array[i] = holder;

            int indexHolder = permutation[permutation[i]];
            permutation[permutation[i]] = permutation[i];
            permutation[i] = indexHolder;
        }
        return array;
    }
}