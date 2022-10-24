void Main()
{
	var text = Console.ReadLine();

	List<char> openingBrackets = new() { '(', '[', '{' };
	List<char> closingBrackets = new() { ')', ']', '}' };

	List<Bracket> opening_brackets_stack = new();

	for (int i = 0; i < text.Length; i++)
	{
		char next = text[i];

		if (openingBrackets.Contains(next))
		{
			// Process opening bracket, write your code here
		}

		if (closingBrackets.Contains(next))
		{
			//Process closing bracket, write your code here
		}
	}

	// Printing answer, write your code here
}

class Bracket
{
	private readonly char _bracketType;
	private readonly int _position;

	public Bracket(char bracketType, int position)
	{
		_bracketType = bracketType;
		_position = position;
	}

	public bool Match(char c)
	{
		if (_bracketType == '[' && c == ']') return true;
		if (_bracketType == '{' && c == '}') return true;
		if (_bracketType == '(' && c == ')') return true;

		return false;
	}
}