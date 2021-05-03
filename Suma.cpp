#include <stdio.h>
#include <stdlib>
#include <math.h>
#include <graphics.h>

int main()
{
	const float pi = 3.1415926;
	int radio, altura;
	cout << "Radio= ";
	cin >> radio;
	cout << "Altura= ";
	cin >> altura;
	float volumen;
	volumen = pi;
	cout << volumen;
	if (volumen > radio) {
		string msg;
		msg = "Mayor";
	}
	else {
		volumen = radio;
	}
}