internal class Program
{
	static void Main()
	{
		int[] tab = [2, 7, 11, 15];
		int target = 17;

		int[]? result = TwoSum(tab, target);

		if (result != null)
		{
			Console.WriteLine($"Indecies: {result[0]}, {result[1]}");
		}
		else
		{
			Console.WriteLine($"There aren't such two numbers in the array that sum up to {target}");
		}
	}

	private static int[]? TwoSum(int[] tab, int target)
	{
		for (int i = 0; i < tab.Length - 1; i++)
		{
			for (int j = i + 1; j < tab.Length; j++)
			{
				int sum = tab[i] + tab[j];

				if (sum == target)
				{
					return [i, j];
				}
			}
		}
		return null;
	}
}
