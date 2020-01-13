 class Ujian
    {
        static void Main(string[] args)
        {
           
            // 
            // 
            
            console.readline("world");
        }
    }
    
 // Example
   class NumberOne 
    {
        public static void hello(string args)
        {   

        Console.Write("Nama kamu siapa ? ");

        string nama = Console.ReadLine();
        Console. WriteLine("Nama kamu "+nama);
        
        }
    }

    class NumberTwo
    {
        public static void tanggal(string[] args)
        {   
            Dim awal As DateTime = New DateTime(2019, 10, 15);
            Dim akhir As DateTime = New DateTime(2020, 10, 15);
            Console.WriteLine("days remaining to my next birthday is : " & DateDiff(DateInterval.Day, awal, akhir));
        }
    }

    class NumberFour
    { 
        static String censor(String text, String word)  
        { 

            String[] word_list = text.split("\\s+"); 
  
            String result = ""; 

            String stars = ""; 
            for (int i = 0; i < word.length(); i++) 
            stars += '*'; 

            int index = 0; 
            for (String i : word_list)  
            { 
                if (i.compareTo(word) == 0) 

                word_list[index] = stars; 
                index++; 
            } 
            for (String i : word_list) 
            result += i + ' '; 
  
            return result; 
        } 
    public static void main(String[] args)  
    { 
        String extract = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy."; 
        String cen = "imperdiet","dolor","duo"; 
        System.out.println(censor(extract, cen)); 
    } 


    class numberFive
    {
        static void Main(string[] args)
        {
            int bil;
            string ket;

            Console.Write(“masukan bilangan = “);
            bil = Convert.ToInt16(Console.ReadLine());
            if (bil % 2 == 0)
            ket = “IsOdd”;
            else
            ket = “IsEven”;
            Console.WriteLine(ket+"("+bil+")");
        }
    }

    class numbersix
    {
        static void Main(String Args)
        {
            String Grade;
            int hasil;
            Hasil = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("\nGrade Anda : ");
                if (Hasil >= 80)
                {
                    Console.WriteLine(Grade = "A");
                }
                else if (Hasil >= 70)
                {
                    Console.WriteLine(Grade = "B");
                }
                else if (Hasil >= 60)
                {
                    Console.WriteLine(Grade = "C");
                }
                else if (Hasil >= 50)
                {
                    Console.WriteLine(Grade = "D");
                }
                else
                {
                    Console.WriteLine(Grade = "E");
                }

                Console.ReadLine();    
        }
    }

    class numberseven
    {
        static void Main(string[] args)
        {
            int celcius,kelvin;
            float fahrenheit, celciustofahrenheit, celciustokelvin, fahrenheittocelcius, fahrenheittokelvin, kelvintocelcius, kelvintofahrenheit;
            //input
            Console.Write("Input suhu dalam celcius = ");
            celcius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input suhu dalam fahrenheit = ");
            celcius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input suhu dalam kelvin = ");
            celcius = Convert.ToInt32(Console.ReadLine());
            //proses
            celciustofahrenheit = (float)celcius * 9 / 5 + 32;
            celciustokelvin = celcius + 273;
            fahrenheittocelcius = (float)(fahrenheit - 32) / 5 / 9;
            fahrenheittokelvin = (float)(fahrenheitt - 459) / 5 / 9;
            kelvintofahrenheit = kelvin - 273
            kelvintocelcius = (float)kelvin * 9 / 5 - 459
            Console.WriteLine();
            //menampilkan hasil
            Console.WriteLine("Besaran dalam C to F = {0}",celciustofahrenheit);
            Console.WriteLine("Besaran dalam F to C      = {0}",fahrenheittocelcius);
            Console.WriteLine("Besaran dalam C to K = {0}",celciustokelvin);
            Console.WriteLine("Besaran dalam K to C      = {0}",kelvintocelcius);
            Console.WriteLine("Besaran dalam K to F = {0}",kelvintofahrenheit);
            Console.WriteLine("Besaran dalam F to K      = {0}",fahrenheittokelvin);
            Console.ReadKey();
        }
    }
}

    class NumberEight 
    { 
  
        public static void Main() 
        { 

        for (int y = 2000; y <= 2020; y++)  
        { 
  
            // using method 
            if (DateTime.IsLeapYear(y))  
            { 
                Console.WriteLine("{0} is a Leap Year.", y); 
            } 
  
            else 
            { 
                Console.WriteLine("{0} is not a Leap Year.", y); 
            } 
        } 
        } 
    } 

    class numberten
    {
        private double sum (double a, double b)
        {
    
            return ( a + b );
        }
    
        private double substrack (double a, double b )
        {
            return ( a - b );
        }
    
        private double multiply (double a, double b )
        {
            return ( a * b );
        }
    
        private double divide (double a, double b )
        {
            return (a / b );
        }
    
    public void Main()
        {
        
            double bil1, bil2;
            Console.WriteLine(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());;
                Console.WriteLine(" Hasilnya Adalah : "+sum(bil1,bil2));
                Console.WriteLine(" Hasilnya Adalah : "+substrack(bil1,bil2));
                Console.WriteLine(" Hasilnya Adalah : "+multiply(bil1,bil2));
                Console.WriteLine(" Hasilnya Adalah : "+divide(bil1,bil2));

        }
    }

    class numbertwelve
    { 

        public static void Main() 
        { 
 
        string str1 = "H4ello World"; 
  
        string upperstr1 = str1.ToUpper(); 
  
        Console.WriteLine(upperstr1); 
        } 
    } 

    class numberthreeten 
    { 

        public static void Main() 
        { 
  
        string str = "Lorem ipsum dolor sit amet"; 
        Console.WriteLine(str.Length);  
        } 
    }

    class numberfourten 
    {
      static void Main(string[] args) 
      {

         string string1, rev;
         string1 = "ibu ratna antar ubi";
         char[] ch = string1.ToCharArray();

         Array.Reverse(ch);
         rev = new string(ch);

         bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
         if (b == true) {
            Console.WriteLine("" + string1 + " is a Palindrome!");
         } else {
            Console.WriteLine(" " + string1 + " is not a Palindrome!");
         }
         Console.Read();
      }
   }

    class numberseventen
    {
        static void Main(string[] args)
        {
            int b;
            int t;
            int l;
            int n = 0;
            Console.Write("Masukkan angka  :");
            n = Convert.ToInt32(Console.ReadLine());
 
            for (b = 1; b <= n; b++)
            {
                t = b % 5;
                l = b % 20;
                if (t == 0 & l == 0)
                {
                    Console.WriteLine("Baz");
                }
                else
                {
                    if (t == 0)
                    {
                        Console.WriteLine("foo ");
                    }
                    if (l == 0)
                    {
                        Console.WriteLine("bar");
                    }
                    Console.Write("");
                }
            }
        }
    }

    class numbereighten
   {
     static void Main(string[] args)
      {
        int jumlah = 0;
        int[] angka = new int[0];
        string pilihan;
           
        do
        {
         Array.Resize(ref angka, angka.Length + 1);
         Console.Write("Input Sembarang Angka = ");
         angka[angka.GetUpperBound(0)] = Convert.ToInt32(Console.ReadLine());
         Console.Write("Mau input data lagi? (Y/T) = ");
         pilihan = Console.ReadLine();
         Console.WriteLine();
         }
         while (pilihan == "y" || pilihan == "Y");
         Array.Sort(angka);
         for (int i = 0; i < angka.Length; i++)
         {
         jumlah += angka[i];
         }
         Console.Write("Barisan Angka: ");
         foreach (int i in angka)
         Console.Write(i + " ");
         Console.WriteLine();
         Console.WriteLine("Nilai  Minimum  = {0}", angka[0]);
         Console.WriteLine("Nilai  Maximum  = {0}", angka[angka.Length - 1]);
         Console.WriteLine("Rata-Rata  = {0}", (float)jumlah / angka.Length);
         Console.ReadKey();
        }
    }

    class numbernineten 
    {
        static void Main(string[] args) 
        {
            int[] arr = new int[10] { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45};
            int n = 12;
            Console.WriteLine("Selection sort");  
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++) 
            {
                smallest = i;
                for (int j = i + 1; j < n; j++) 
                    {
                        if (arr[j] < arr[smallest]) 
                            {
                            smallest = j;
                            }
                     }
                    temp = arr[smallest];
                    arr[smallest] = arr[i];
                    arr[i] = temp;
            }
      Console.WriteLine();
      Console.Write("Sorted array is: "); 
      for (int i = 0; i < n; i++) 
            {
            Console.Write(arr[i] + " ");
            }
        }
    }

}