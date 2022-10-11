//{
//    Console.WriteLine("Task 1.: Write your Name & Surname");

//    string name;
//    string surname;

//    Console.WriteLine("Please enter your name: ");
//    name = Console.ReadLine();

//    Console.WriteLine("Please enter your surname: ");
//    surname = Console.ReadLine();

//    Console.WriteLine("Your name and surname is: " + name + " " + surname);
//}


//{
//    Console.WriteLine("Task 2.: Get 2 numbers from the Keybord and calculate sum, subtract, multiply and remaindar.");

//    Console.WriteLine("Enter first number: ");
//    string n1 = (Console.ReadLine());

//    int.TryParse(n1, out int r1);


//    Console.WriteLine("Enter second number: ");
//    string n2 = (Console.ReadLine());

//    int.TryParse(n2, out int r2);

//    Console.WriteLine("The sum of two numbers is :" + (r1 + r2));
//    Console.WriteLine("The multiplicaitaion is" + (r1 * r2));
//    Console.WriteLine("The subtract numbers is :" + (r1 - r2));
//    Console.WriteLine("The sum of two numbers is :" + (r1 % r2));
//}


//{
//    Console.WriteLine("Task 3.: Get 2 numbers from keyboard and swap meaings.");

//    Console.WriteLine("Enter first number: ");
//    string x = Console.ReadLine();
//    int.TryParse(x, out int r1);

//    Console.WriteLine("Enter second number: ");
//    string y = Console.ReadLine();
//    int.TryParse(y, out int r2);


//    int temp;
//    temp = r1;
//    r1 = r2;
//    r2 = temp;

//    Console.WriteLine($"After swap: {r1} {r2}");
//}


//{
//    Console.WriteLine("Task 4.: Get 4 numbers from keyboard and calculate an average.");

//    Console.WriteLine("Enter 1st number: ");
//    double x = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Enter 2nd number: ");
//    double y = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Enter 3rd number: ");
//    double z = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Enter 4th number: ");
//    double w = Convert.ToDouble(Console.ReadLine());

//    double result = (x + y + z + w) / 4;
//    Console.WriteLine("Average is: " + result);
//}


//{

//    Console.WriteLine("Task 6.: Check whether a number is positive or negative.");

//    Console.WriteLine("Enter number: ");
//    int num;
//    num = Convert.ToInt32(Console.ReadLine());

//    if (num >= 0)

//        Console.WriteLine("number is positive.\n", num);
//    else
//        Console.WriteLine("number is negative. \n", num);
//}


//{
//    Console.WriteLine("Task 7.: Get 3 numbers from the Keyboard and print the smallest and largest.");

//    Console.WriteLine("Input first number:");
//    int x = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input second number:");
//    int y = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input third number:");
//    int z = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Smallest of three: " + Math.Min(x, Math.Min(y, z)));
//    Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
//}


//{
//    Console.WriteLine("Task 8.: Get 2 numbers from the keyboard and if they are equal multiply to 3.");

//    Console.WriteLine("input first number:");
//    int x = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("input second number:");
//    int y = Convert.ToInt32(Console.ReadLine());

//    if (x == y)

//    Console.WriteLine("The numbers were equal and are multiplied to 3: " + (x * 3) + " and " + (y * 3)); ;

//}


//{
//    Console.WriteLine("Task 9.: Get the number from the keyboard and check if it's divisible by 7.");

//    Console.WriteLine("input the number:");
//    int x = Convert.ToInt32(Console.ReadLine());

//    if (x % 7 == 0)
//    {
//        Console.WriteLine("Divisible by 7.");
//    }
//    else
//    {
//        Console.WriteLine("Not divisible by 7.");
//    }
//    Console.ReadLine();
}

//{
//    Console.WriteLine("Task 10.: Get number from the keyboard and check if it contains 5.");
//    Console.WriteLine("Enter number");
//    string num = Console.ReadLine();

//    bool IsDigitsOnly(string str)
//    {
//        foreach (char c in str)
//        {
//            if (c < '0' || c > '9')
//                return false;
//        }
//        return true;
//    }

//    if (IsDigitsOnly(num))
//    {
//        if (num.Contains('5'))
//        {
//            Console.WriteLine("Contains 5.");
//        }
//        else
//        {
//            Console.WriteLine("Does not contain 5.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Please enter only numbers.");
//    }
//}








//Homework #2:

//// task 1. program to enter 10 elements from the keyboard and fill the array


//int[] arr;
//int size = int.Parse(Console.ReadLine());  // array size

//arr = new int[size]; // array with the given size


//Console.WriteLine($"Enter {size} numbers: "); // enter array elements


//for (int i = 0; i < size; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine()); // fills array

//}


//// Book exercise 6.1: write a program that prints on the console the numbers from 1 to N. 


//Console.WriteLine("Enter number:" );
//int n = int.Parse(Console.ReadLine()); 

//for (int i = 0; i < n; i++) 
//{
//    Console.Write("{0}", i); //if n = 5, returns 01234
//}
//Console.WriteLine();



///// Task 2. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს რიცხვს n-ს
// და დაბეჭდავს 1-დან n მდე რიცხვებს ისე როგორც სურათზე


//int num = 10; // 10 numbers in total
//int lines = 1; // elements on each line starting from 1
//int x = 1; // integer to use in stpping into enother line

//while (x <= num) // until x <= 10;

//{

//    for (int i = 0; i < lines; i++) // how many times
//    {
//        Console.Write($"   {x++}"); // print x integer that starts with 1
//    }

//    Console.WriteLine();

//    lines++; //increases no of lines in while loop
//}




//// Book exercise 6.2 Write a program that prints on the console the numbers from 1 to N,
//which are not divisible by 3 and 7 simultaneously. N should be read from the standard input.

//Console.WriteLine("Enter number: "); // e.g.: 8, output must be 1,2,4,5,6,8
//int n = int.Parse(Console.ReadLine());

//int b = 1; // new integer is needed from where to start, since n is only upper size

//while (b < n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        if (b % 3 !=0 && b % 7 != 0)

//        {
//            Console.WriteLine(b);
//        }

//        b++;
//    }
//}


//// task 3. კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ 1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი.

//Console.WriteLine("Enter number: "); // e.g. 10, output must be sum = 25

//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//int mult = 0;

//for (int i = 1; i < n; i=i+2)
//{
//    sum += i;
//    mult = i*i;

//}
//Console.WriteLine(sum);
//Console.WriteLine(mult);



////Book exercise 6.3 write a program that reads from the console a series of integers and
//prints the smallest and largest of them.


//int minNum = 0;
//int maxNum = 0;

//Console.WriteLine("Enter numbers length: "); //e.g. 6, so should enter 6 numbers
//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++) // 6 times print request to enter number
//{
//    Console.Write("Enter number: ");
//    int input = int.Parse(Console.ReadLine());

//    if (i == 0) minNum = maxNum = input;
//    else
//    {
//        if (minNum > input) minNum = input;
//        if (maxNum < input) maxNum = input;

//    }
//}

//Console.WriteLine("Min Number = {0}, Max Number = {1}", minNum, maxNum);






//// task 4. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი რიცხვისთვის დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.


//Console.WriteLine("Enter number length:");
//int length = int.Parse(Console.ReadLine());
//int sum = 0;
//int sqr;

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter number: ");
//    int input = int.Parse(Console.ReadLine());

//    sqr = input * input; // not needed 
//    sum += input * input;

//}
//Console.WriteLine(sum);


//// Book exercise 6.4 write a program that prints all possible cards from a standard deck
//// cards, without jokers (there are 52 cards: 4 suits of 13 cards).

//string[] suits = { "heart", "club", "diamond", "spade" }; // 4 possible suits
//string[] cards = {"A", "2", "3", "4", "5", "6", "7","8", "9", "10", "J", "Q", "K"}; // 13 possible cards


//foreach (string card in cards)
//{
//	foreach (string suit in suits)
//	{
//		Console.WriteLine($"{card} of {suit }");

//	}
//}



//// my excersize: program that prints all possible versions of 4 type classes (a, b, c, d) from 1 to 11 classes


//string[] types = { "a", "b", "c", "d" };
//int[] classNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//foreach (string type in types)
//{
//	foreach ( int classNum in classNums)
//	{
//		Console.WriteLine($"{classNum}-{type} class");
//	}
//}


//// task 5. დაწერეთ პროგრამა რომელიც შეამოწმებს არის თუ არა სტრინგი პალინდრომი.

//Console.Write("Enter a string : ");
//string input = Console.ReadLine();

//bool isPalindrome = true;

//for (int i = 0; i < input.Length / 2; i++)

//{
//    if (input[i] != input[input.Length - 1 - i])
//    {
//        isPalindrome = false;
//        Console.WriteLine("is not palindrome");
//        break; // stops check
//    }
//}


//if (isPalindrome)
//{
//    Console.WriteLine("Is palindrome");
//}

//// task 6.დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოსულ რიცხვს შეამოწმებს არის თუ არა პალინდრომი (არ გამოიყენოთ სტრინგები)

//Console.Write("Enter integer: ");
//int x = int.Parse(Console.ReadLine());

//int[] array = new int[x];
//Console.WriteLine("Enter the values of the array:");

//for (int i = 0; i < x; i++)
//{
//    array[i] = int.Parse(Console.ReadLine());
//}
//bool palindrome = true;
//for (int i = 0; i < array.Length / 2; i++)
//{
//    if (array[i] != array[x - i - 1])
//    {
//        palindrome = false;
//        break;
//    }
//}
//Console.WriteLine("Is palindrome");




// task 7. მოცემულია მასივი, რომელიც შეგიძლიათ შეავსოთ კლავიატურიდანაც და პროგრამიდანაც.
// დაწერეთ პროგრამა რომელიც დაითვლის ამ მასივში თითოეული ელემენტის რაოდენობას.



//int[] arr;
//int size = int.Parse(Console.ReadLine());

//arr = new int[size]; 

//Console.WriteLine($"Enter {size} numbers: ");

//for (int i = 0; i < size; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine()); 

//}


//// task 8. დაწერეთ პროგრამა რომელიც მასივში დაითვლის ამ მასივში უმცირეს,უდიდეს ელემენტს და იპოვნის მედიანას(შუა წევრს)

//int[] arr1 = new int[100];
//int i, mx, mn, n;

//Console.Write("Input the number of elements in the array :");
//n = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input {0} elements in the array : ", n);
//for (i = 0; i < n; i++)
//{
//    Console.Write("element {0}: ", i);
//    arr1[i] = int.Parse(Console.ReadLine());
//}

//mx = arr1[0];
//mn = arr1[0];

//for (i = 1; i < n; i++)
//{
//    if (arr1[i] > mx)
//    {
//        mx = arr1[i];
//    }

//    if (arr1[i] < mn)
//    {
//        mn = arr1[i];
//    }
//}
//Console.Write("Maximum element is: {0} ", mx);
//Console.Write("Minimum element is: {0} ", mn);



// task 9. დაწერეთ პროგრამა რომელიც მოცემულ მასივს დაბეჭდავს შებრუნებული სახით მაგ 1 2 3 4 —-> 4 3 2 1


//int[] array = { 1, 2, 3, 4, 5 };
//int length = array.Length;

//int[] reversed = new int[length]; // creatng new reversed array

//for (int i = 0; i < length; i++)
//{
//    reversed[length - i - 1] = array[i];
//}

//for (int i = 0; i < length; i++)
//{
//    Console.Write(reversed[i] + " ");
//}




// task 10. დაწერეთ პროგრამა რომელიც მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას.




//task.5

//string input, opposite = null;
//Console.Write("Enter a string : ");

//input = Console.ReadLine();

//if (input != null)
//{
//    for (int i = input.Length - 1; i >= 0; i--) // (length - 1) = the last element, since 1st element starts from 0

//    {
//        opposite += input[i].ToString();
//    }

//    if (opposite == input)
//    {
//        Console.WriteLine("is Palindrome");
//    }

//    else
//    {
//        Console.WriteLine("is not Palindrome");
//    }

//}



//task.6

//int num, r, sum = 0, t;

//Console.Write("Input a number: ");
//num = int.Parse(Console.ReadLine());


//for (t = num; num != 0; num = num / 10)
//{
//r = num % 10;
//    sum = sum * 10 + r;
//}
//if (t == sum)
//    Console.Write("{0} is a palindrome number.", t);
//else
//    Console.Write("{0} is not a palindrome number.", t);




//task.7


//string s = Console.ReadLine();

//bool isPalindrom = true;

//for (int i = 0; i < s.Length / 2; i++)
//{
//    if (s[i] != s[s.Length - 1 - i])
//    {
//        isPalindrom = false;
//        Console.WriteLine("Is not palindrome");
//        break;
//    }
//}

//if (isPalindrom)
//{
//    Console.WriteLine("Is Palindrome");
//}


//int x = 0;

//int[] arr = new int[7];

//for (int i = 0; i < 8; i++)
//{

//    x += 3;

//    arr[i] = x;
//    Console.WriteLine(arr[i]);

//}







//int b = 5;

//int[] arrTako = new int[101];


//    for (int i = 0; i <= arrTako.Length; i += 3)
//{

//    arrTako[i] = b;
//    b += 5;

//    Console.WriteLine(arrTako[i]);

//    if (i+1 <=arrTako.Length)
//    {
//        Console.WriteLine(arrTako[i + 1]);
//    }


//    if (i+2<= arrTako.Length)
//    {

//        Console.WriteLine(arrTako[i + 2]);

//    }
//}


//Console.WriteLine("Enter integer: ");
//string x = Console.ReadLine();

//int a = int.Parse(x);
//int k = a;
//int b = 0;
//int num = 0;


//while (a != 0)

//{

//    a /= 10;
//    b++;

//}

//Console.WriteLine(b); /// gavige sigrze

//a = k;

//while (b!=0)

//{
//    num += a % 10 * (int)Math.Pow(10, b - 1);

//    a /= 10;
//    b--;

//}

//Console.WriteLine(num);


// 1 3 3 5 6 7 7 8 11




//int[] arr;
//int[] brr;
//int a = 0;
//int size = int.Parse(Console.ReadLine());

//arr = new int[size]; // massive length is size
//brr = new int[size];

//Console.WriteLine($"Enter {size} numbers: ");


//for (int i = 0; i < size; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine()); //massivi sheivso

//}

//for (int i = 0; i < size; i++)
//{
//    for (int j = 0; j < size; j++)
//    {
//        if (arr[i] == brr[j])
//        {
//            a++;
//        }
//    }
//    if (a == 0) { brr[i] = arr[i]; }
//    a = 0;

//}

//for (int i = 0; i < size; i++)
//{
//    if (brr[i] != 0) { Console.WriteLine(brr[i]); }
//}

//    int i = 10;
//Console.WriteLine(i);