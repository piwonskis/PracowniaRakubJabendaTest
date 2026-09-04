#include <iostream>
#include <fstream>
#include <string>
using namespace std;
int main()
{
	//Komentarz jedna linia
	ifstream File("C:/Users/student/Desktop/informatyka-2026-maj-matura-rozszerzona-zalaczniki/Dane-NF-2605/pary.txt");
	string myText;
	///Opis pętli (doxygen)
	while (getline(File, myText)) {
		cout << myText;
	}
	File.close();

	/*komentarz
	wielo
	linowy*/
	
}
