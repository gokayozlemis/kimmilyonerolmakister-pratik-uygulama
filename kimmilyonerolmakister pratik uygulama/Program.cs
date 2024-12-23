using System;

class Program
{
    static void Main()
    {
        int correctAnswers = 0; // Doğru cevap sayısını tutacak değişken

        // 1. soru
        Console.WriteLine("1. Soru: Hangi gezegen Güneş Sistemi'nde en büyüğüdür?");
        Console.WriteLine("A) Mars");
        Console.WriteLine("B) Jüpiter");
        string answer1 = Console.ReadLine().ToUpper(); // Kullanıcı cevabını alırız ToUpper da aldıgımız harfleri her türlü büyük harfe cevirir

        // Doğru cevabı kontrol et
        if (answer1 == "B")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!.");
        }
        else
        {
            Console.WriteLine("Yanlış cevap.");
        }

        // 2. soru
        Console.WriteLine("\n2. Soru: Hangi elementin sembolü 'O'dur?");
        Console.WriteLine("A) Oksijen");
        Console.WriteLine("B) Altın");
        string answer2 = Console.ReadLine().ToUpper(); // Kullanıcı cevabını al

        // Doğru cevabı kontrol et
        if (answer2 == "A")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!.");
        }
        else
        {
            Console.WriteLine("Yanlış cevap.");
        }

        // Eğer 2 doğru cevap alındıysa, 3. soru yok
        if (correctAnswers >= 2)
        {
            Console.WriteLine("\nTebrikler! 2 doğru cevap verdiniz ve 1 Milyon TL'lik büyük ödülü kazandınız!");
            return; // 3. soruya geçmeden programı sonlandırır
        }

        // 3. soru
        Console.WriteLine("\n3. Soru: Hangi gezegen Güneş Sistemi'nde en yakın olanıdır?");
        Console.WriteLine("A) Venüs");
        Console.WriteLine("B) Merkür");
        string answer3 = Console.ReadLine().ToUpper(); // Kullanıcı cevabını al

        // Doğru cevabı kontrol et
        if (answer3 == "B")
        {
            correctAnswers++;
            Console.WriteLine("Doğru cevap!.");
        }
        else
        {
            Console.WriteLine("Yanlış cevap.");
        }

        // Sonuç değerlendirmesi
        if (correctAnswers >= 2)
        {
            Console.WriteLine("\nTebrikler! 2 doğru cevap verdiniz ve 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("\nÜzgünüz! 2 doğru cevabı tamamlayamadınız ve büyük ödülü kazanamadınız.");
        }

        Console.ReadLine(); // Konsol ekranı kapanmasın
    }
}
