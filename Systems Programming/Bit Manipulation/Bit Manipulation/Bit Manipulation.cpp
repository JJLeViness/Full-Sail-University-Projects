// Bit Manipulation.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
unsigned int bitfield;
int ValidInteger(int userinput, char question[]);
void TurnOn(int bit);
void TurnOff(int bit);
void Toggle(int bit);
void Negate();
void LeftShift();
void RightShift();
void WriteBinaryNumber(unsigned int bitfield);

int main()
{
	int userinput = 0;
	int bittochange = 0;
	bool menu = true;
	char NumberPrompt[] = "Number:  ";
	char WhichBit[] = "Which bit would you like to change?:  ";
	char Menu[] = "What would you like to do?\n\t1:Turn On\n\t2: Turn Off\n\t 3: Toggle\n\t 4: Negate\n\t5: Left Shift\n\t 6: Right Shift\n\t 7: Exit\n\tSelection:  ";

	cout << "Please enter a number between 0 and " << UINT_MAX;
	cout << "\n";
	bitfield = ValidInteger(bitfield, NumberPrompt);
	
	system("cls");

	while (menu)
	{
		cout << "Bit Manipulation Lab\n";
		cout << "Your number: " << bitfield<<"\n";
		cout << "Number in binary: ";
		WriteBinaryNumber(bitfield);
		cout << "\n";
		
		
		userinput = ValidInteger(userinput, Menu);
		switch (userinput)
		{
		case 1:
		{
			userinput = 1;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";

			bittochange = ValidInteger(bittochange, WhichBit);
			TurnOn(1 << bittochange - 1);

			
			system("cls");
			break;
		}
		case 2:
		{
			userinput = 2;
			userinput = 1;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";

			bittochange = ValidInteger(bittochange, WhichBit);
			TurnOff(1 << bittochange - 1);
			
			system("cls");
			break;
		}
		case 3:
		{
			userinput = 3;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";
			bittochange = ValidInteger(bittochange, WhichBit);
			Toggle(1 << bittochange - 1);
			
			
			system("cls");
			break;
		}
		case 4:
		{
			userinput = 4;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";
			Negate();
			
			system("cls");
			break;
		}
		case 5:
		{
			userinput = 5;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";
			LeftShift();
			
			system("cls");
			break;
		}
		case 6:
		{
			userinput = 6;
			cout << "Bit Manipulation Lab\n";
			cout << "Your number: " << bitfield << "\n";
			cout << "Number in binary: ";
			WriteBinaryNumber(bitfield);
			cout << "\n";
			RightShift();
			
			system("cls");
			break;
		}
		case 7:
		{
			userinput = 7;
			menu = false;
			
			system("cls");
			cout << "\nHave a great day!";
			break;
		}
		}

	}


}

void WriteBinaryNumber(unsigned int Number)
{
	char BinaryNum[32];
	for (int i = 31; i >= 0; i--)
	{
		if (Number % 2 == 0)
		{
			BinaryNum[i] = '0';
		}
		else
		{
			BinaryNum[i] = '1';
		}
		Number = Number / 2;
	}

	for (int i = 0; i < 32; i++)
	{
		if (i % 4 == 0)
		{
			cout << " ";
		}

		cout << BinaryNum[i];
	}
}




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

void TurnOn(int bit)
{
	bitfield = bitfield | bit;

}

void TurnOff(int bit)
{
	bitfield = bitfield & ~bit;
}

void Toggle(int bit)
{
	bitfield = bitfield ^ bit;
}

void Negate()
{
	bitfield = ~bitfield;
}

void LeftShift()
{
	bitfield = bitfield << 1;
}

void RightShift()
{
	bitfield = bitfield >> 2;
}

