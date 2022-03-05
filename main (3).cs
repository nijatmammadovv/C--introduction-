using System;

class Program
{
    public static void Main(string[] args)
    {
      int kiçik = 0;
      int ədəd;
        for (int i = 1; i <= 18; i++)
        {
          Console.Write("{0}. ədəd : ", i);
          ədəd = Convert.ToInt32(Console.ReadLine());
          if (i == 1)
            {
                kiçik = ədəd;
            }
            if (kiçik > ədəd)
            { kiçik = ədəd; }
            

        }
        Console.WriteLine("Ən kiçik ədəd {0}", kiçik);
        Console.ReadLine();
    }
}