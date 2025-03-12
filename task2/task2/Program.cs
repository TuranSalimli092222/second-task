#region classTask
/*int[] arr = new int[10];
int index = 0;
for (int number = 0; index < arr.Length; number++)
{
    if ( number % 2 == 0 && number != 0)
    {

    arr[index++] = number; 
    }
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}*/
#endregion
#region classwork1
/*Console.WriteLine("Telebenin balin yazin:");
int bal = Convert.ToInt32(Console.ReadLine());
switch (bal)
{
    case int n when (n >= 90 && n <= 100):
        Console.WriteLine("Telebenin Qiyməti A-dir.");
        break;
    case int n when (n >= 80 && n <= 90):
        Console.WriteLine("Telebenin Qiyməti B-dir.");
        break;
    case int n when (n >= 70 && n <= 80):
        Console.WriteLine("Telebenin Qiyməti C-dir.");
        break;
    case int n when (n >= 60 && n <= 70):
        Console.WriteLine("Telebenin Qiyməti D-dir.");
        break;
    case int n when (n >= 50 && n <= 60):
        Console.WriteLine("Telebenin Qiyməti E-dir.");
        break;
case int n when (n >= 0 && n <= 50):
        Console.WriteLine("Telebe kesilb tebrikler.");
        break;
    default:
        Console.WriteLine("daxil etdiyiniz bal yanlisdir");
        break;
}*/
#endregion
#region classwork2

/*Console.WriteLine("Reqem daxil edin:");
int eded = Convert.ToInt32(Console.ReadLine());
int cem = 0;
while (eded > 0)
{
    cem = cem + eded % 10;
    eded = eded / 10;

}
Console.WriteLine(cem);*/
#endregion
#region classwork3

/*int[] arr = {1 , 2 , 3 , 4, 66,55, 77, 65 , 21};
for (int i = 0; i < arr.Length; i++)
{
int index = arr[i];
    if (index % 2 == 0)
    {
        Console.WriteLine(arr[i]);
    }
    index++;
}*/
#endregion
#region classwork4
/*int[] Numbers = { 5, 12, 3, 9, 7, 15, 1 };
int en_boyukEded = Numbers[0];
int en_kicikEded = Numbers[0];
for (int i = 0; i < Numbers.Length; i++)
{
  if (Numbers[i] > en_boyukEded)
  {
       en_boyukEded = Numbers[i];
  }
  if (Numbers[i] < en_kicikEded)
  {
        en_kicikEded = Numbers[i];
  }
}
Console.WriteLine("Massivin ən böyük elementi: " + en_boyukEded);
Console.WriteLine("Massivin ən kiçik elementi: " + en_kicikEded);

*/
#endregion