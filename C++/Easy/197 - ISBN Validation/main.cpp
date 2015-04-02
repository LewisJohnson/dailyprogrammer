#include <iostream>
#include <string>
using namespace std;

// Submitted by /u/FreakJoe - not including the extra challenge

int main()
{

	int multiplier = 10, sum = 0, currentSelection = 0;
	string ISBN = "";

	cout << "Please enter the ISBN code you want to validate." << endl;
	cin >> ISBN;

	for (int index = 0; index < ISBN.length(); ++index)
	{

		// Make sure to exclude the separating characters from the addition procedure
		if (ISBN[index] != '-')
		{

			currentSelection = ISBN[index];
			sum += multiplier * currentSelection;
			// Multiply the first number by 10, the second by 9, ...
			--multiplier;

		}

	}

	// If the final sum is evenly divisible by 11, the ISBN is valid
	if ((sum % 11) == 0)
		cout << "The ISBN you entered is valid.";
	else
		cout << "The ISBN you entered is invalid.";

}