class MainClass	
{
		public static void Main ()
		{
			System.Console.WriteLine ("Моля въведете вашата възраст:");
			
            int myAge = int.Parse (System.Console.ReadLine ());

            System.Console.WriteLine("Your current age is: {0} ", myAge);
			int added = 10;
			int newAge = myAge + added;
			System.Console.WriteLine("Time period is: {0} years, and after that time you will be {1} years old", added,newAge);
            // System.DateTime age = new System.DateTime(myAge);
			
            // string[] years = age.AddYears (added);	
			// int newAge =  int.Parse(years);

            // System.Console.WriteLine ("Вашата възраст след {0} ще бъде:{1} години", years,newAge);
         
            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
            
     
        }
}
