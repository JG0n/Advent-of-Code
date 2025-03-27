class Program
{
	static void Main(string[] args)
	{
		int floor = 0;
		int position = 0;
		IEnumerable<string> directions = File.ReadLines(args[0]);
		foreach (string d in directions)
		{
			foreach (char c in d)
			{
				position++;
				
				if (c == '(')
				{
					floor++;
				}
				else
				{
					floor--;
				}
				
				if(floor == -1){
					Console.WriteLine($"Position: {position}");
				}
			}
		}
		Console.WriteLine($"Floor: {floor}");
	}
}
