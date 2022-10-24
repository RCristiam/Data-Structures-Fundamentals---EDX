void Main()
{
	TreeHeight tree = new();
	tree.Read();
	Console.WriteLine(tree.ComputeHeight());
}

class TreeHeight
{
	private int _n;
	private int[] _parent;

	public void Read()
	{
		_n = Convert.ToInt32(Console.ReadLine());
		_parent = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
	}

	public int ComputeHeight()
	{
		// Replace this code with a faster implementation
		var maxHeight = 0;
		for (int vertex = 0; vertex < _n; vertex++)
		{
			var height = 0;
			var i = vertex;
			while (i != -1)
			{
				height++;
				i = _parent[i];
				maxHeight = new[] { maxHeight, height }.Max();

			}
		}
		return maxHeight;
	}
}
