class Program
{
	static void Main(string[] args)
	{
		IEnumerable<string> measurements = File.ReadAllLines(args[0]);
		int total = 0;
		int ribbon = 0;
		/*int line = 0;*/

		foreach (string measurement in measurements)
		{
			string[] stringValues = measurement.Split("x");
			int[] values = stringValues.Select(x => Int32.Parse(x)).ToArray();
			total += 2 * values[0] * values[1];
			total += 2 * values[2] * values[1];
			total += 2 * values[0] * values[2];

			int[] min = values.Order().Take(2).ToArray();
			total += min[0] * min[1];

			ribbon += values.Order().Take(2).Aggregate((x, y) => 2 * x + 2 * y);
			ribbon += values.Aggregate((x, y) => x * y);
			/*line++;*/
			/*Console.WriteLine($"Line {line}: {measurement} -> {values.Aggregate((x, y) => x * y)}");*/
		}

		Console.WriteLine($"Square feet: {total}");
		Console.WriteLine($"Ribbon: {ribbon}");
	}
}
