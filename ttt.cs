using System;

public class TicTacToe
{
	static public void Main()
	{
		TicTacToe game = new TicTacToe();
		game.DrawBoard();
	}
	
	public void DrawBoard()
	{
		for (int r = 1; r < 10; r+=3)
		{
			Console.WriteLine("|-----------------|");
			Console.Write("|");
			for (int c = r; c < r + 3; c++)
			{
				Console.Write("  " + c + "  |");
			}
			if(r == 7)
			{
				Console.WriteLine("\n|-----------------|");
			}
			Console.WriteLine();
		}
	}
}