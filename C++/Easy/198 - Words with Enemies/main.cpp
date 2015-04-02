#include <iostream>
#include <string>
using namespace std;

// Submitted by /u/FreakJoe

void subtractLetters(string& firstWord, string& secondWord)
{
		
	string newFirstWord = "";
	string newSecondWord = secondWord;
	bool found;

	for (int firstIndex = 0; firstIndex < firstWord.length(); ++firstIndex)
	{

		// For each letter in the first word, search through the entire second
		// word to see if there's a matching letter in the second word
		found = false;

		for(int secondIndex = 0; secondIndex < secondWord.length(); ++secondIndex)
		{

			// If a matching character is found, set the variable "found" to true
			// and remove the character from the second word, by setting it to 0

			if ((firstWord[firstIndex] == secondWord[secondIndex]) && !found)
			{

				secondWord[secondIndex] = 0;
				found = true;

			}

		}

		// If there was no corresponding character in the second word that the
		// character could collide with, it will continue to exist
		if (!found)
			newFirstWord += firstWord[firstIndex];

	}

	// Reset "secondWord" to the word supplied by the user
	secondWord = newSecondWord;
	newSecondWord = "";

	for (int secondIndex = 0; secondIndex < secondWord.length(); ++secondIndex)
	{

		found = false;

		for(int firstIndex = 0; firstIndex < firstWord.length(); ++firstIndex)
		{

			if (firstWord[firstIndex] == secondWord[secondIndex])
			{

				firstWord[firstIndex] = 0;
				found = true;

			}

		}

		if (!found)
			newSecondWord += secondWord[secondIndex];

	}

	// Set the supplied variables equal to the remaining characters
	firstWord = newFirstWord;
	secondWord = newSecondWord;

}

int main()
{

	string firstWord = "", secondWord = "";

	// Ask for the two words that should be compared to each other
	cout << "Enter two words:" << endl;
	cin >> firstWord;
	cin >> secondWord;

	subtractLetters(firstWord, secondWord);
	cout << "Left side: " << firstWord << endl;
	cout << "Right side: " << secondWord << endl;
	// Whichever side has more characters remaining will win
	// If neither side has more characters, it will be a draw
	if (firstWord.length() > secondWord.length())
		cout << "The left side has won." << endl;

	else if (firstWord.length() < secondWord.length())
		cout << "The right side has won." << endl;

	else
		cout << "Neither side has won." << endl;
	
}