using System;

class Natural{

	public static void Main(string[] args){
	
		int n = 10;
		Print(n);
	
	}
	
	static void Print(int n){
	
		if(n ==0){
		return;
		}
		Console.WriteLine(n);
		Print(n - 1);
	}

}