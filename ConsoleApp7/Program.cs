namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World!";
            Console.WriteLine(string.IsNullOrEmpty(s)); //s'in olup olmadığı s'e sorulmaz, o yüzden string.IsNullOrEmpty diye sorulur (True-False döner)
            //False
            Console.WriteLine(s.Length);
            //14
            Console.WriteLine(s.Trim().ToUpper()); //Başında ve sonundaki boş karakterleri atar
            //HELLO, WORLD!
            Console.WriteLine(s.Substring(2, 3)); //2. karakterden başla 3 karakter al
            //ell
            Console.WriteLine(s.Substring(2)); //2. karakterden başla sonuna kadar al
            //ello, World!
            Console.WriteLine(s.StartsWith(" H")); // H ile mi başlıyor? (True-False döner)
            //True
            Console.WriteLine(s.PadLeft(20, '*')); //14 karakterlik yazı var 20'ye tamamlayacak kadar başına * koyar.
            //******Hello, World!
            Console.WriteLine(s.PadRight(20, '*')); //14 karakterlik yazı var 20'ye tamamlayacak kadar sonuna * koyar.
            //Hello, World! * *****
            Console.WriteLine(s.Replace("Hello", "Naber")); //Hello yazan yere Naber yaz
            //Naber, World!
            Console.WriteLine(s.Contains('H')); //İçinde H geçiyor mu? (True-False döner)
            //True
            Console.WriteLine(s.IndexOf('H')); //H kaçıncı karakterdir onu verir
            //1
            Console.WriteLine(s.Insert(3, "H")); //3. karakterin olduğu yere H ekle ama 3. karakteri silme, diğer metin kaysın
            // HeHllo, World!
            Console.WriteLine(s.Reverse());
            Console.WriteLine(ContainsX("Araba", 'b'));
            //True
            Console.WriteLine(PadLeftX("Araba", 7 , '*'));
            //**Araba

        }
        public static bool ContainsX(string s, char c) //s metninin içinde c karakteri var mıdır fonksiyonu
        {
            List<Char> chars = s.ToList();
            foreach (var item in chars)
            {
                if (item == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static int IndexOfX(string s, char c) //s metninin içindeki c karakterinin sırasın verir. For ile
        {
            List<Char> chars = s.ToList();
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int IndexOfX2(string s, char c) //s metninin içindeki c karakterinin sırasın verir. Foreach ile
        {
            List<Char> chars = s.ToList();
            int index = -1;
            foreach (var item in chars)
            {
                index++;
                if (item == c)
                {
                    return index;
                }
            }
            return -1;
        }
        public static string PadLeftX(string s, int count, char c)
        {
            if (s.Length >= count)
            {
                return s;
            }
            int fark = count - s.Length;
            string pad = "";
            for (int i = 0; i < fark; i++)
            {
                pad += c;
            }
            return pad + s;
        }
        public static string SubstringX(string s, int start)
        {
            string sonuc = "";
            for (int i = start; start <= s.Length; i++)
            {
                sonuc += s[i];
            }
            return sonuc;
        }
        public static string SubstringX1(string s, int start, int count)
        {
            List<Char> chars = s.ToList();
            string sonuc = "";
            for (int i = start; start <= count+start; i++)
            {
                sonuc += s[i];
            }
            return sonuc;
        }


    }
}