namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string id;
            int pw;
            do
            {
                Console.Write("Kullanıcı adınızı giriniz: ");
                id = Console.ReadLine();
                if (id == "KingsMan")
                {
                    Console.Write("Şifrenizi giriniz: ");
                    pw = Convert.ToInt32(Console.ReadLine());
                    if (pw == 1234)
                    {
                        Console.WriteLine("Giriş Başarılı! Hoşgeldin Ajan.");
                    }
                    else
                        Console.WriteLine("Şifre hatalı, imha için geri sayım başlıyor...");
                }

            } while (id != "KingsMan");
        }
        
    }
}