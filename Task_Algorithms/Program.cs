



#region Tek ededlerin sayi
//Start:
//Console.Write("Birinci ededi daxil edin : ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Ikinci ededi daxil edin : ");
//int num2 = int.Parse(Console.ReadLine());
//int count = 0;


//if (num1 > num2)
//{
//    Console.WriteLine("Birinci eded ikinci ededden boyuk olmamalidir");
//    goto Start;
//}
//for (int i = num1+1; i < num2; i++)
//{
//    if (i % 2 != 0) count++;
//}
//Console.WriteLine(count);
#endregion

#region Tek ededlerin cemi
//Start:
//Console.Write("Birinci ededi daxil edin : ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Ikinci ededi daxil edin : ");
//int num2 = int.Parse(Console.ReadLine());
//int sum = 0;

//if (num1 > num2)
//{
//    Console.WriteLine("Birinci eded ikinci ededden boyuk olmamalidir");
//    goto Start;
//}
//for (int i = num1+1; i < num2; i++)
//{
//    if (i % 2 != 0) sum += i;
//}
//Console.WriteLine(sum);
#endregion

#region Verilen edede qeder olan cut ededlerin hasili
//Start:
//Console.Write("Ededi daxil edin : ");
//int number = int.Parse(Console.ReadLine());
//int multiply = 1;

//if (number <= 1)
//{
//    Console.WriteLine("1 den yuksek eded daxil edin");
//    goto Start;
//}

//for (int i = 1; i < number; i++)
//{
//    if (i %2 == 0) multiply *= i;
//}
//Console.WriteLine(multiply);
#endregion

#region Verilen ededin hem 3e bolunub hem de cut ve ya tek olmasini tapmaq
//Console.Write("Ededi daxil edin : ");
//int num = int.Parse(Console.ReadLine());

//if (num == 0)
//{
//    Console.WriteLine("Eded ne tek ne cutdur");
//}
//else
//{
//    if (num % 3 == 0)
//    {
//        if (num % 2 == 0) Console.WriteLine("3 e bolunen cut ededdir");
//        else Console.WriteLine("3e bolunen tek ededdir");
//    }
//    else Console.WriteLine("3 e bolunmur");
//}
#endregion

#region Ededin sade ve ya murekkeb oldugunu tapmaq
//Start:
//Console.Write("Ededi daxil edin : ");
//int num = int.Parse(Console.ReadLine());
//bool flag = false;

//if (num <= 0)
//{
//    Console.WriteLine("0 dan yuksek eded daxil edin");
//    goto Start;
//}
//else if (num == 1)
//{
//    Console.WriteLine("Ne sade ne de murekkebdir");
//}
//else
//{
//    for (int i = 2; i * i <= num; i++)
//    {
//        if (num % i == 0) flag = true;
//    }

//    if (flag) Console.WriteLine("Eded murekkebdir");
//    else Console.WriteLine("Eded sadedir");
//}
#endregion