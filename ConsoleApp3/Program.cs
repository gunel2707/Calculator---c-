
namespace ConsoleApp3
{
    internal class Program
    {
        private static object deximal;

        static void Main(string[] args)
        {

            Console.WriteLine("         Emeliyyati secin:");
            Console.WriteLine("  1:Toplama " + " 2:Cixma " + " 3:Vurma " + " 4:Bolme " + " 5:Quvvete yukseltme " + " 6.Kokalti");
            Console.WriteLine("  7:Ededin sade ve ya murekkeb olmasi " + " 8:Ededin tam bolenleri ve sayi " + " 9:Ededin tek ve ya cut olmasi");
            Console.WriteLine("  10:Ededin reqemlerinin cemi " + " 11:Ededin yuvarlaqlasdirilmasi");

            byte e = byte.Parse(Console.ReadLine());

            switch (e)
            {
                case 1:
                    Console.WriteLine("Birinci ededi daxil edin:");
                    int var1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin:");
                    int var2 = int.Parse(Console.ReadLine());
                    var result = Sum(var1, var2);
                    Console.WriteLine("result:" + result.ToString());
                    break;


                case 2:
                    Console.WriteLine("Birinci ededi daxil edin:");
                    int var21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin:");
                    int var22 = int.Parse(Console.ReadLine());
                    var result2 = var21 - var22;
                    Console.WriteLine("result:" + result2.ToString());
                    break;

                case 3:
                    Console.WriteLine("Birinci ededi daxil edin:");
                    int var31 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin:");
                    int var32 = int.Parse(Console.ReadLine());
                    var result3 = var31 * var32;
                    Console.WriteLine("result:" + result3.ToString());
                    break;

                case 4:
                    Console.WriteLine("Boluneni  daxil edin:");
                    int var41 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Boleni daxil edin:");
                    int var42 = int.Parse(Console.ReadLine());
                    var result4 = var41 / var42;
                    Console.WriteLine("result:" + result4.ToString());
                    break;

                case 5:
                    Console.WriteLine("Ededi  daxil edin:");
                    int var51 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ededin derecesini daxil edin:");
                    int var52 = int.Parse(Console.ReadLine());
                    var result5 = Math.Pow(var51, var52);
                    Console.WriteLine("result:" + result5.ToString());
                    break;


                case 6:
                    Console.WriteLine("Ededi daxil edin:");
                    int var6 = int.Parse(Console.ReadLine());

                    var result6 = Math.Sqrt(var6);
                    Console.WriteLine("result:" + result6.ToString());
                    break;


                case 7:
                    Console.WriteLine("Ededi daxil edin:");
                    int s = 0;
                    int var7 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= var7 / 2; i++)
                    {
                        if (var7 % i == 0) { s++; }
                    }
                    if (s > 2) { Console.WriteLine("Eded murekkebdir"); }
                    else
                    { Console.WriteLine("Eded sadedir"); }
                    break;

                case 8:
                    Console.WriteLine("Ededi daxil edin:");
                    int s8 = 0;
                    int var8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tam bolenleri:");
                    for (int i = 2; i <= var8 / 2; i++)
                    {
                        if (var8 % i == 0)
                        {
                            s8++;
                            Console.WriteLine(i.ToString());
                        }
                    }

                    Console.WriteLine("Eded tam bolenlerinin sayi:" + s8.ToString());
                    break;






                case 9:
                    Console.WriteLine("Ededi daxil edin:");

                    int var9 = int.Parse(Console.ReadLine());


                    if (var9 % 2 == 0)

                    { Console.WriteLine("Eded cutdur"); }
                    else
                    { Console.WriteLine("Eded tekdir"); }

                    break;

                case 10:
                    Console.WriteLine("Ededi daxil edin:");
                    int s1 = 0;
                    int r = 0;
                    int var10 = int.Parse(Console.ReadLine());
                    while (var10 > 0)

                    {
                        int m = var10 % 10;
                        s1++;
                        var10 = var10 / 10;
                        r = r + m;
                    }
                    Console.WriteLine("Ededin reqemlerinin cemi:" + r.ToString() + ";  reqemlerin sayi ise," + s1.ToString());

                    break;
                case 11:
                    Console.WriteLine("Ededi daxil edin:");
                    double var11 = double.Parse(Console.ReadLine());

                    var result11 = Math.Round(var11, 1);
                    Console.WriteLine("result:" + result11.ToString());
                    break;


                default:
                    Console.WriteLine(e + "Emeliyyat nomresi deyil");
                    break;
            }
            Console.ReadKey();
        }
        private static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}





