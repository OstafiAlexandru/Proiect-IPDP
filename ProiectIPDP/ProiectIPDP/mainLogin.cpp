// mainLogin.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

bool isLoggedIn()
{
	string user, pass, comp_user, comp_pass;
	cout << "Enter your username: ";
	cin >> user;
	cout << "Enter your password: ";
	cin >> pass;
	ifstream read(user + ".txt");
	getline(read, comp_user);
	getline(read, comp_pass);

	if (comp_user == user && comp_pass == pass)
	{
		return true;
	}
	else
	{
		return false;
	}
}

int main()
{
	int choice;
	cout << "Sign Up or Log in\n1.Sign Up\n2.`Log in\n";
	cin >> choice;
	if (choice == 1)
	{
		string user, pass;
		cout << "Type in your username: \n";
		cin >> user;
		cout << "Type in your password: \n";
		cin >> pass;

		ofstream file;
		file.open(user + ".txt");
		file << user << endl << pass;
		file.close();

		main();
	}
	else if (choice == 2)
		{
			bool status = isLoggedIn();
			if (!status)
			{
				cout << "Invalid username or password" << endl;
				system("PAUSE");
				return 0;
			}
			else
			{
				cout << "Succesfully logged in!" << endl;
				system("PAUSE");
				return 1;
			}
		}
}

