using System;

public class Program
{
	public static void Main()
	{
		// Array deklarieren und instanziieren
		int[] a = new int[10];
		int[] b = new int[10];
		int[] c = new int[10];
		int[] d = new int[10];


		int u = 4;
		int z = 10;
		for (int i = 0; i <= 9; i++)
		{
			a[i] = i + 1;
			b[i] = u;
			c[i] = z;
			d[i] = a[i] + b[i] + c[i];
			z--;
			u *= 2;
		}

		for (int i = 0; i <= 9; i++)
		{
			Console.WriteLine(d[i]);
		}

	}
}

/*
 Daten in Index speichern und ausgeben:
	a { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 }
	b { 4 , 8 , 16, 32 , 64 , 128 , 256 , 512 , 1024 , 2048 }
	c { 10, 9, 8 ,7 ,6 ,5 ,4 , 3 , 2 , 1 }
	d { summe(a,b,c),  ... }
*/