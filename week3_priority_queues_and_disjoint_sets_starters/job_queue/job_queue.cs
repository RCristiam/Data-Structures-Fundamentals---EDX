void Main()
{
	JobQueue job_queue = new();

	job_queue.Solve();
}


class JobQueue
{
	private int _numWorkers;
	private int[] _jobs;
	private int[] _assignedWorkers;
	private int[] _startTimes;

	public void Solve()
	{
		ReadData();
		AssignJobs();
		WriteResponse();
	}

	private void ReadData()
	{
		var workers_m = Console.ReadLine().Split(' ').Select(w => Convert.ToInt32(w)).ToArray();
		_numWorkers = workers_m[0];
		int m = workers_m[1];
		_jobs = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();

		Debug.Assert(m == _jobs.Length);
	}

	private void AssignJobs()
	{
		// TODO : Replace this code with a faster algorithm.
		_assignedWorkers = new int[_jobs.Length];
		_startTimes = new int[_jobs.Length];
		var nextFreeTime = new int[_numWorkers];
		for (int i = 0; i < _jobs.Length; i++)
		{
			int nextWorker = 0;
			for (int j = 0; j < _numWorkers; j++)
			{
				if (nextFreeTime[j] < nextFreeTime[nextWorker])
					nextWorker = j;
			}
			_assignedWorkers[i] = nextWorker;
			_startTimes[i] = nextFreeTime[nextWorker];
			nextFreeTime[nextWorker] += _jobs[i];
		}
	}

	private void WriteResponse()
	{
		for (int i = 0; i < _jobs.Length; i++)
		{
			Console.WriteLine($"{_assignedWorkers[i]} {_startTimes[i]} ");
		}
	}
}