#include<iostream>

namespace Helper 
{

	int GetValidatedInt(const char* strMessage, int MinimumRange = 0, int MaximumRange = 0)//Will loop till a valid integer is recorded
	{
		bool valid = true;
		int userinput;
		std::cout << strMessage;
		while (valid)
		{
			std::cin >> userinput;

			if (!std::cin >> userinput || userinput<MinimumRange || userinput>MaximumRange)
			{
				std::cout << "Invalid input, please enter a number between " << MinimumRange << " and " << MaximumRange << "\n";
				ClearInput();
			}
		}
		return userinput;

	}

	void ClearInput()//Places clearing input into one method
	{
		std::cin.clear();
		std::cin.ignore();
	}

	int GetRandomNumber(int min, int max)//will return a random number between a min and max range
	{
		srand(unsigned(NULL));

		int number;
		number = rand() % max + min;
		return number;
	}

	int PrintMenu(char Menu[]) //Will display a Menu for the user and return their selection. Will need numbered options
	{
		int selection;
		for (int i = 0; i <= sizeof(Menu); i++)
		{
			std::cout << Menu[i] << "\n";
		}
		selection = GetValidatedInt(Menu, 1, sizeof(Menu));
		return selection;
	}
}
