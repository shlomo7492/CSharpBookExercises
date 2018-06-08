using System;

namespace TousandNumbersToBulWords
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int tmp = 0;
			string strCtr = null;
			bool parseTest = false;
			while (parseTest==false) 
			{
				Console.WriteLine ("Please enter a number betwen 0 and 999.");
				strCtr = Console.ReadLine ();
				parseTest = int.TryParse (strCtr, out tmp);
				if ((tmp < 0) || (tmp > 999)) 
				{
					parseTest = false;
				}
			}
			string textName = NumToWord(strCtr,strCtr.Length);
			Console.WriteLine ("The text name in Bulgarian of {0} is \"{1}\"",strCtr,textName);
		}
		public static string  NumToWord (string strN,int pos)
		{
			int[] intNum;
			intNum = new int[3];
			string strWord = null;
			for (int i=1; i<=strN.Length; i++) 
			{
				intNum [strN.Length-i] = (int)Char.GetNumericValue(strN [i-1]);
			}
			switch (pos) 
			{
			case 1:
				switch (intNum [0]) 
				{
					case 0:
						strWord = " Нула";
						break;
					case 1:
						strWord = " Едно";
						break;
					case 2:
						strWord = " Две";
						break;
					case 3:
						strWord = " Три";
						break;
					case 4:
						strWord = " Четири";
						break;
					case 5:
						strWord = " Пет";
						break;
					case 6:
						strWord = " Шест";
						break;
					case 7:
						strWord = " Седем";
						break;
					case 8:
						strWord = " Осем";
						break;	
					case 9:
						strWord = " Девет";
						break;
					default:
						break;
				}
				break;
			case 2:
				switch (intNum [1]) 
				{
					case 0:
						if (strN.Length > 2)
						{
							strWord = "и" + NumToWord (strN, pos - 1);
						} 
						else 
						{
							strWord = NumToWord (strN, pos - 1);
						}break;

					case 1:
						switch (intNum[0])
						{
							case 0:
								strWord = "Десет";
								break;
							case 1:
								strWord = " Еднинадесет";
								break;
							case 2:
								strWord = " Дванадесет";
								break;
							case 3:
								strWord = NumToWord("3",1)+"надесет";
								break;
							case 4:
								strWord = NumToWord("4",1)+"надесет";
								break;
							case 5:
								strWord = NumToWord("5",1)+"надесет";
								break;
							case 6:
								strWord = NumToWord("6",1)+"надесет";
								break;
							case 7:
								strWord = NumToWord("7",1)+"надесет";
								break;
							case 8:
								strWord = NumToWord("8",1)+"надесет";
								break;	
							case 9:
								strWord = NumToWord("9",1)+"надесет";
								break;
							default:
								break;
						}	 break;
					case 2:
						if (intNum [0] == 0) 
						{
							if (strN.Length > 2) 
							{
								strWord = " и Двaдесет";			
							} 
							else 
							{
								strWord = "Двaдесет";
							}
						}
						else
						{
							strWord = "Двaдесет и" + NumToWord (strN, 1);

						} break;
					case 3:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("2",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("2",1)+"десет";
							} 						
						}
						else
						{
							strWord = NumToWord("3",1)+"десет и"+NumToWord(strN,1);
						} break;

					case 4:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("4",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("4",1)+"десет";
							} 						
						}
						else
						{
							strWord = NumToWord("4",1)+"десет и"+NumToWord(strN,1);
						} break;					
					case 5:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("5",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("5",1)+"десет";
							} 				
						}
						else
						{
							strWord = NumToWord("5",1)+"десет и"+NumToWord(strN,1);
						} break;
					case 6:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("6",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("6",1)+"десет";
							} 					
						}
						else
						{
							strWord = NumToWord("6",1)+"десет и"+NumToWord(strN,1);
						} break;
					case 7:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("7",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("7",1)+"десет";
							} 							
						}
						else
						{
							strWord = NumToWord("7",1)+"десет и"+NumToWord(strN,1);
						} break;					
					case 8:
						if (intNum [0] == 0)
						{
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("8",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("8",1)+"десет";
							} 			
						}
						else
						{
							strWord = NumToWord("8",1)+"десет и"+NumToWord(strN,1);
						} break;	
					case 9:
						if (intNum [0] == 0)
						{
							
							if (strN.Length >2)
							{
								strWord =" и " + NumToWord("9",1)+"десет";			
							}
							else
							{
								strWord = NumToWord("9",1)+"десет";
							} 			
						}
						else
						{
							strWord = NumToWord("9",1)+"десет и"+NumToWord(strN,1);
						}
						break;
					default: 
					break;
				}
				break;

			case 3:
				switch (intNum [2]) 
				{
					case 0:
						strWord = NumToWord(strN,2); break;
					case 1:
					if ((intNum[1]==0)&&(intNum[0]==0))
					{
						strWord = "Сто"; break;
					}
					else
					{
						strWord = "Сто"+NumToWord(strN,2); break;
					}
					case 2:
					strWord = "Двеста"+NumToWord(strN,2); break;
					case 3:
					strWord = NumToWord("3",1)+"стотин"+NumToWord(strN,2); break;
					case 4:
					strWord = NumToWord("4",1)+"стотин"+NumToWord(strN,2); break;
					case 5:
					strWord = NumToWord("5",1)+"стотин"+NumToWord(strN,2); break;
					case 6:
					strWord = NumToWord("6",1)+"стотин"+NumToWord(strN,2); break;
					case 7:
					strWord = NumToWord("7",1)+"стотин"+NumToWord(strN,2); break;
					case 8:
					strWord = NumToWord("8",1)+"стотин"+NumToWord(strN,2); break;	
					case 9:
					strWord = NumToWord("9",1)+"стотин"+NumToWord(strN,2); break;
					default: break;
				}				break;

			}
			return strWord;
		}
	}
}
