

#include <iostream>
using namespace std;

void One();
void WriteNumberAndPointer(int number, int* pointer);
void Two();
void CreateCars();
void Three();



int GetInt(char Question[], int userinput)
{
	cout << Question;
	while (!(cin >> userinput))
	{
		cout << Question << "\n";
		cin >> userinput;
		cin.clear();
		cin.ignore();
	}
	return userinput;
}

enum ColorDefinition
{
	Purple = 1,
	Blue,
	Red,
	Green,
	Black
};

struct Car
{
	char Make[32];
	char Model[32];
	int Year;
	int Mileage;
	ColorDefinition Color;
};
Car YourCar[3];

void RepaintCar(Car* carpointer, ColorDefinition color);
void PaintCar();
void AddMileage(Car* car, int AddMileage);
void AddTheMileage();



int main()
{
	One();
	system("pause");
	system("cls");
	Two();
	system("pause");
	system("cls");
	Three();
	system("pause");
	system("cls");
	cout << "Car Repainting\n";
	PaintCar();
	cout << "\n";
	system("pause");
	system("cls");
	cout << "Add Mileage to Your Car\n";
	AddTheMileage();
	system("pause");
	system("cls");
	cout << "Thank you!";



}


//Program 1-1
void One()
{
	int Numbers[15];
	srand(unsigned(NULL));

	cout << "Program 1";
	cout << "\n";
	cout << "Numbers\t\t\tMemory Address";
	cout << "\n";
	for (int i = 0; i < 15; i++)
	{
		Numbers[i] = rand();
		cout << Numbers[i] << "\t\t\t" << &Numbers[i];
		cout << "\n";

	}

}

//Program 2, Number and Pointer Method
void WriteNumberAndPointer(int number, int* pointer)
{
	cout << number << "\t\t\t" << pointer;
}
//Program 2
void Two()
{
	cout << "Program 2\n";
	cout << "Numbers\t\t\tMemory Address\n";

	int numbers[15];

	for (int i = 0; i < 15; i++)
	{
		numbers[i] = rand();
		int* pointer = &numbers[i];


		WriteNumberAndPointer(numbers[i], pointer);
		cout << "\n";
	}

}
void PointerWriteCar(Car* car)
{
	cout << "\t" << (*car).Year << " ";
	switch ((*car).Color)
	{
	case Purple:
	{
		cout << "Purple ";
		break;
	}
	case Blue:
	{
		cout << "Blue ";
		break;

	}
	case Red:
	{
		cout << "Red ";
		break;
	}
	case Green:
	{
		cout << "Green ";
		break;
	}
	case Black:
	{
		cout << "Black ";
		break;
	}
	}
	cout << (*car).Make << " " << (*car).Model << " with " << (*car).Mileage << " miles\n";

}

void WriteCar(Car Car)
{
	cout << "\t" << Car.Year << " ";
	switch (Car.Color)
	{
	case Purple:
	{
		cout << "Purple ";
		break;
	}
	case Blue:
	{
		cout << "Blue ";
		break;

	}
	case Red:
	{
		cout << "Red ";
		break;
	}
	case Green:
	{
		cout << "Green ";
		break;
	}
	case Black:
	{
		cout << "Black ";
		break;
	}
	}
	cout << Car.Make << " " << Car.Model << " with " << Car.Mileage << " miles\n";
}


void CreateCars()
{


	char year[] = "Please Enter the Year:";
	char mile[] = "Please enter the Mileage";
	char Color[] = "Please select a color\n1=Purple\n2=Blue\n3=Red\n4=Green\n5=Black\n";
	for (int i = 0; i < 3; i++)
	{

		cout << "Please enter the make:";
		cin.getline(YourCar[i].Make, 32);
		cout << "\n";

		cout << "Please enter the model:";
		cin.getline(YourCar[i].Model, 32);
		cout << "\n";


		YourCar[i].Year = GetInt(year, YourCar[i].Year);
		cout << "\n";


		YourCar[i].Mileage = GetInt(mile, YourCar[i].Mileage);
		cout << "\n";


		YourCar[i].Color = (ColorDefinition)GetInt(Color, YourCar[i].Color);
		cin.clear();
		cin.ignore();

		system("cls");
	}


}
void RepaintCar(Car* carpointer, ColorDefinition newcolor)
{
	carpointer->Color = newcolor;

}
void PaintCar()
{
	char whichcar[] = "Which car would you like to repaint? 1,2 or 3?: ";
	int CarNumber = 0;
	cout << "Let's repaint a car green!\n";
	CarNumber = GetInt(whichcar, CarNumber) - 1;
	Car* car = &YourCar[CarNumber];

	RepaintCar(car, Green);
	cout << "\nThis car is now green!\n";
	PointerWriteCar(car);



}

void AddMileage(Car* car, int AddMileage)
{
	car->Mileage =(car->Mileage + AddMileage);

}

void AddTheMileage()
{
	char which[] = "Which car would you like to add miles to? 1,2,or 3?: ";
	char HowMany[] = "How many miles would you like to add?: ";
	int whichcar = 0;
	int MilesToAdd = 0;

	whichcar = GetInt(which, whichcar) - 1;
	cin.clear();
	cin.ignore();
	cout << "\n";
	MilesToAdd = GetInt(HowMany, MilesToAdd);
	cout << "\n You have added " << MilesToAdd << " miles to the car\n";
	Car* car = &YourCar[whichcar];
	AddMileage(car, MilesToAdd);
	PointerWriteCar(car);


}




//Main method for Creating Cars
void Three()
{
	cout << "Program 3\n";

	CreateCars();
	cout << "Your Cars\n";
	for (int i = 0; i < 3; i++)
	{
		WriteCar(YourCar[i]);
	}
	cout << "\n Writing your Cars using Pointers\n";
	for (int i = 0; i < 3; i++)
	{
		Car* CarPointer = &YourCar[i];
		PointerWriteCar(CarPointer);
	}

}








