void Main()
{
	HeapBuilder heap_builder = new();

	heap_builder.Solve();
}

class HeapBuilder
{

	private int _n;
	private int[] _data;

	private List<(int from, int to)> _swaps = new();

	private void ReadData()
	{
		_n = Convert.ToInt32(Console.ReadLine());
		_data = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
	}

	private void WriteResponse()
	{
		Console.WriteLine(_swaps.Count());

		foreach (var swap in _swaps)
		{
			Console.WriteLine($"{swap.from} {swap.to}");
		}
	}

	private void GenerateSwaps()
	{
		// The following naive implementation just sorts 
		// the given sequence using selection sort algorithm
		// and saves the resulting sequence of swaps.
		// This turns the given array into a heap, 
		// but in the worst case gives a quadratic number of swaps.
		//
		// TODO: replace by a more efficient implementation
		for (int i = 0; i < _data.Length; i++)
		{
			for (int j = i + 1; j < _data.Length; j++)
			{
				if (_data[i] > _data[j])
				{
					_swaps.Add((i, j));
					var aux = _data[j];
					_data[j] = _data[i];
					_data[i] = aux;
				}
			}
		}
	}

	public void Solve()
	{
		ReadData();

		GenerateSwaps();

		WriteResponse();
	}
}