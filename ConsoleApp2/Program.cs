//2. შექმენით კონსოლური აპლიკაცია, რომელიც დააგენერირებს და შეინახავს გამრავლების ტაბულას მასივში და შემდეგ მის მნიშვნელობებს დაბეჭდავს.
// მაგ.:
// Enter a number: 5
// Multiplication Table of 5:
// 5 x 1 = 5
// 5 x 2 = 10
// ...
// 5 x 10 = 50
Console.WriteLine("Enter a number: ");
string input1 = Console.ReadLine();
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int num = int.Parse(input1);

for( int i = 1; i <= 10; i++ )
{
    int result = i * num;
    Console.WriteLine(i + " X " + num +" = "  +result);
}
