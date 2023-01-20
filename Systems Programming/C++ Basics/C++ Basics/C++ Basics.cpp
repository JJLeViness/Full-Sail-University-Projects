// C++ Basics.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int ValidInteger(int userinput, char question[]);
void One();
void Two();
void Three();
void Four();
void Five();
void Six();
void Seven();
void Eight();
void Nine();
void Ten();



int main()
{
	cout << "Program 1-1 \n";
	One();
	cout << "\n";
	system("Pause");
	cout << "Program 1-2 \n";
	Two();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-3 \n";
	Three();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-4 \n";
	Four();
	cout << "\n";
	system("Pause");
	system("cls");

	cout << "Program 1-5 \n";
	Five();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-6 \n";
	Six();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-7\n";
	Seven();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-8 \n";
	Eight();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-9 \n";
	Nine();
	cout << "\n";
	system("Pause");
	system("cls");
	cout << "Program 1-10 \n";
	Ten();
	cout << "\n";
	system("Pause");

}

//Method will loop until correct integer input is aquired
int ValidInteger(int userinput, char question[])
{
	cout << question;

	while (!(std::cin >> userinput))
	{
		cout << question;
		cin >> userinput;
		cin.clear();
		cin.ignore();
	}
	return userinput;

}
//Program 1-1
void One()
{
	char initial[5];
	int age = 0;
	char AgeQuestion[] = "What is your age?: ";


	cout << "Please enter your initials:  ";
	cin.get(initial, 5);
	cout << "\n";
	age = ValidInteger(age, AgeQuestion);
	age = age * 365;

	cout << initial << ", did you know that you're at least " << age << " days old?";
	cout << "\n";





}

//Program 1-2
void Two()
{
	int NumberArray[5];
	char ArrayQuestion[] = "Please enter a number:  ";

	for (int i = 0; i < 5; i++)
	{
		NumberArray[i] = ValidInteger(NumberArray[i], ArrayQuestion);
	}
	cout << "\n";

	cout << "You entered:  ";

	for (int i = 0; i < 5; i++)
	{
		cout << NumberArray[i];
	}

	cout << "\n";


}

//Program 1-3
void Three()
{
	char A[] = "Please enter a value for A:  ";
	char B[] = "Please enter a value for B:  ";
	char C[] = "Please enter a value for C:  ";
	int a = 0;
	int b = 0;
	int c = 0;
	a = ValidInteger(a, A);
	b = ValidInteger(b, B);
	c = ValidInteger(c, C);

	int Answer1 = a + 1 * b + 2 - c;
	int Answer2 = (a + 1) * (b + 2) - c;

	cout << a << +" + 1 * " << b << " + 2 - " << c << " = " << Answer1 << "\n";
	cout << "(" << a << " + 1) * (" << b << " + 2) - " << c << " = " << Answer2 << " \n";



}

//Program 1-4
void Four()
{
	cout << " Type\t\t Range\n";
	cout << "========================\n";
	cout << " ushort\t\t 0 to " << USHRT_MAX << "\n";
	cout << " short\t\t " << SHRT_MIN << " to " << SHRT_MAX << " \n";
	cout << " int\t\t " << INT_MIN << " to " << INT_MAX << " \n";
	cout << " uint\t\t 0 to " << UINT_MAX << "\n";
	cout << " longlong \t" << LONG_MIN << " to " << LONG_MAX << " \n";
	cout << " ulong \t\t 0 to " << ULONG_MAX << " \n";

}



//Program 1-5
void Five()
{
	char Name[32];
	cout << "Please enter your full name: \n";
	cin.clear();
	cin.ignore();
	cin.getline(Name, 32);
	cout << Name << ", did you know that hawaiian pizza was invented in Canada? \n";

}
//Program 1-6
void Six()
{
	char HowOld[] = "How old are you?: ";
	int Age = 0;
	Age = ValidInteger(Age, HowOld);
	if (Age <= 14)
	{
		cout << "Sorry! you are too young to play. Have a great day!\n";
	}
	if (Age > 14)
	{
		if (Age <= 29)
		{
			cout << "Getting close to Thirty! Starting to get old...\n";
		}
		if (Age > 30)
		{
			cout << Age << ", Wow!, you're more than 30% through your life!\n";
		}


	}




}
//Program 1-7
void Seven()
{
	int number = 0;
	char EvenNumber[] = "Please enter a number: ";
	number = ValidInteger(number, EvenNumber);
	if (number % 2 == 0)
	{
		cout << "Congrats! You entered an even number!\n";
	}
	if (number % 2 != 0)
	{
		cout << "*Buzzer noise* That is not an even number!\n";
	}

}
//Program 1-8
void Eight()
{
	int divisor = 0;
	char Divisor[] = "Please enter a number to divde by:  ";
	srand((unsigned)time(NULL));
	divisor = ValidInteger(divisor, Divisor);

	for (int i = 0; i < 3; i++)
	{
		int number = rand();
		cout << number << "\t";
		if (number % divisor == 0)
		{
			cout << " Yes\n";

		}
		else
		{
			cout << "No\n";
		}
	}



}
//Program 1-9
void Nine()
{
	enum PopColor
	{
		Red = 1,
		Green,
		Purple,
		Blue,
		Orange,
		Yellow,

	};
	char Flavor[] = "Please Select a color popsicle:\n\t1:Red\n\t2:Green\n\t3:Purple\n\t4:Blue\n\t5:Orange\n\t6:Yellow\n";
	int ColorSelection = 0;

	ColorSelection = ValidInteger(ColorSelection, Flavor);
	switch (ColorSelection)
	{
	case 1:
	{
		ColorSelection = 1;
		cout << "A red popsicle! Cherry is a safe choice\n";
		break;
	}
	case 2:
	{
		ColorSelection = 2;
		cout << "A green popsicle! This one is Lime\n";
		break;

	}
	case 3:
	{
		ColorSelection = 3;
		cout << "A purple popsicle! Grape is underrated\n";
		break;
	}
	case 4:
	{
		ColorSelection = 4;
		cout << "A blue popsicle! Blue Raspberry is delicious\n";
		break;
	}
	case 5:
	{
		ColorSelection = 5;
		cout << "An orange popsicle! Orange you glad it's orange?\n";
		break;
	}
	case 6:
	{
		ColorSelection = 6;
		cout << "A yellow popsicle! Wonder if it's banana or lemon...\n";
		break;
	}
	default:
		cout << "You didn't select a flavor, but I can offer you a picture of a puppy?\n";

	}


}
//Program 1-10
void Ten()
{

	int choice = 0;
	char DifQuestion[] = "Difficulty Level:\n\t1: Easy\n\t2: Medium\n\t3: Hard\n\tWhat will it be?: ";
	int enemieseasy = rand() % 10 + 1;
	int enemiesmed = rand() % 25 + 11;
	int enemieshard = rand() % 50 + 26;


	choice = ValidInteger(choice, DifQuestion);
	switch (choice)
	{
	case 1:
	{
		choice = 1;
		cout << "Easy! You encountered " << enemieseasy << " number of enemies! Good Luck!\n";
		break;
	}
	case 2:

	{
		choice = 2;
		cout << "Medium! You encountered " << enemiesmed << " number of enemies! Best of Luck!\n";
		break;
	}
	case 3:
	{
		choice = 3;
		cout << "Hard! You encountered " << enemieshard << " number of enemies! May the odds be ever in you favor!\n";
		break;
	}
	default:
	{
		cout << "Your enemies were confused and left..Technically you won. Congrats?\n";
	}

	}


}






