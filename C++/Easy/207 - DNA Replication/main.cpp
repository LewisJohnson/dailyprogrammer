#include <iostream>
#include <string>
using namespace std;

// Submitted by /u/FreakJoe - not including the extra challenge

int main()
{

	string inputStrand = "";
	string outputStrand = "";
	char currentBase = 'a';

	cout << "Please put in one side of the DNA strand to generate the other side of it." << endl;
	cin >> inputStrand;

	for (int i = 0; i < inputStrand.length(); ++i)
	{

		currentBase = inputStrand[i];
		switch(currentBase)
		{

		case 'A':
			outputStrand += 'T';
			break;
		case 'T':
			outputStrand += 'A';
			break;
		case 'C':
			outputStrand += 'G';
			break;
		case 'G':
			outputStrand += 'C';
			break;
		default:
			break;

		}

	}

	cout << outputStrand << endl;

}