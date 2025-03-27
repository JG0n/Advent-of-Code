/*class Program*/
/*{*/
/*    public void Main*/
/*}*/

using (StreamReader reader = new(args[0]))
{
	Dictionary<Tuple<int, int>, int> visits = new();
	Tuple<int, int> santaPosition = Tuple.Create(0, 0);
	Tuple<int, int> robotPosition = Tuple.Create(0, 0);
	visits.Add(santaPosition, 1);
	char instruction;
	while (true)
	{
		if (reader.Peek() == -1)
		{
			break;
		}
		instruction = (char)reader.Read();
		santaPosition = instruction switch
		{
			'<' => Tuple.Create(santaPosition.Item1 - 1, santaPosition.Item2),
			'>' => Tuple.Create(santaPosition.Item1 + 1, santaPosition.Item2),
			'V' => Tuple.Create(santaPosition.Item1, santaPosition.Item2 - 1),
			'v' => Tuple.Create(santaPosition.Item1, santaPosition.Item2 - 1),
			'^' => Tuple.Create(santaPosition.Item1, santaPosition.Item2 + 1),
			_ => santaPosition,
		};
		/*Console.WriteLine($"Position: {santaPosition}");*/

		if (visits.ContainsKey(santaPosition))
		{
			visits[santaPosition] += 1;
		}
		else
		{
			visits.Add(santaPosition, 1);
		}

		if (reader.Peek() == -1)
		{
			break;
		}
		instruction = (char)reader.Read();
		robotPosition = instruction switch
		{
			'<' => Tuple.Create(robotPosition.Item1 - 1, robotPosition.Item2),
			'>' => Tuple.Create(robotPosition.Item1 + 1, robotPosition.Item2),
			'V' => Tuple.Create(robotPosition.Item1, robotPosition.Item2 - 1),
			'v' => Tuple.Create(robotPosition.Item1, robotPosition.Item2 - 1),
			'^' => Tuple.Create(robotPosition.Item1, robotPosition.Item2 + 1),
			_ => robotPosition,
		};
		/*Console.WriteLine($"Position: {robotPosition}");*/

		if (visits.ContainsKey(robotPosition))
		{
			visits[robotPosition] += 1;
		}
		else
		{
			visits.Add(robotPosition, 1);
		}
	}

	Console.WriteLine("Houses with at least one present: " + visits.Where(x => x.Value > 0).Count().ToString());
}
