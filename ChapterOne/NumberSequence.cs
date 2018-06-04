class MainClass
{
		public static void Main ()
		{
			int sequence = 2;
			
			System.Console.Write (sequence);
			
			for (int ctr = 1; ctr <= 99; ctr++) 
			{
				if (sequence < 0)
				{
					sequence = sequence*-1 + 1;
				}
				else
				{
					sequence = (sequence+1)*-1;
				}
				
				System.Console.Write (", {0}", sequence);
			}
				
		}
}
