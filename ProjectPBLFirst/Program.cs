using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CME_Project_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a11, a12, a13, a21, a22, a23, a31, a32, a33, temp;
            int scorePlayer = 0, scoreComputer = 0;
            int totalseries, totalboxscore, round = 1, turn = 1;
            /*Bu while döngüsünde 3. kişinin girdiği sayılarda geçersiz giriş yapılırsa hata verilecek,
             sayılarda tekrar olup olmadığı kontrol edilecek*/
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 1st number : ");
                    if (int.TryParse(Console.ReadLine(), out a11) && a11 >= 1 && a11 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 2nd number : ");
                    if (int.TryParse(Console.ReadLine(), out a12) && a12 >= 1 && a12 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 3rd number : ");
                    if (int.TryParse(Console.ReadLine(), out a13) && a13 >= 1 && a13 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 4th number : ");
                    if (int.TryParse(Console.ReadLine(), out a21) && a21 >= 1 && a21 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 5th number : ");
                    if (int.TryParse(Console.ReadLine(), out a22) && a22 >= 1 && a22 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 6th number : ");
                    if (int.TryParse(Console.ReadLine(), out a23) && a23 >= 1 && a23 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 7th number : ");
                    if (int.TryParse(Console.ReadLine(), out a31) && a31 >= 1 && a31 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 8th number : ");
                    if (int.TryParse(Console.ReadLine(), out a32) && a32 >= 1 && a32 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Please enter the 9th number : ");
                    if (int.TryParse(Console.ReadLine(), out a33) && a33 >= 1 && a33 <= 9)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a NUMBER from 1 to 9.\nPress enter to continue...");
                        Console.ReadLine();
                    }
                }
                if (a11 == a12 || a12 == a13 || a11 == a21 || a11 == a22 || a11 == a23 || a11 == a31 || a11 == a32 || a11 == a33 ||
                        a12 == a13 || a12 == a21 || a12 == a22 || a12 == a23 || a12 == a31 || a12 == a32 || a12 == a33 ||
                        a13 == a21 || a13 == a22 || a13 == a23 || a13 == a31 || a13 == a32 || a13 == a33 ||
                        a21 == a22 || a21 == a23 || a21 == a31 || a21 == a32 || a21 == a33 ||
                        a22 == a23 || a22 == a31 || a22 == a32 || a22 == a33 ||
                        a23 == a31 || a23 == a32 || a23 == a33 ||
                        a31 == a32 || a31 == a33 ||
                        a32 == a33)
                {
                    Console.WriteLine("The numbers you entered shouldn't have repetitions.\nPress enter to try again...");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            /*İlk ekranda herhangi bir seri varsa tahtadaki seri sayısı 0 olana kadar iki taraf da sırayla hamle yapacak ve tahtadaki puan 
            en azından bir kez 0 olduktan sonrasında oyuncular serilerden puan alabilecek. En başında tahtada bir
            seri yoksa yani oldtotalseries 0 ise oyun normal bir şekilde devam edecek ve controlFirstScreen döngüsü hiç çalışmayacak.*/
            // İlk girilen tablonun seri kontrolü. Oldtotalseries demek tahtanın ilk görünümünde seri var mı demek
            int oldtotalseries = 0;
            if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) oldtotalseries++;
            if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) oldtotalseries++;
            if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) oldtotalseries++;
            if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) oldtotalseries++;
            if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) oldtotalseries++;
            if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) oldtotalseries++;
            // Çapraz seri
            if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) oldtotalseries++;
            if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) oldtotalseries++;
            bool turnwho = true;
            while (true)
            {
                if (round == 6)
                    break;
                /*İlk ekranda herhangi bir seri varsa tahtadaki seri sayısı 0 olana kadar iki taraf da sırayla hamle yapacak ve tahtadaki puan 
                en azından bir kez 0 olduktan sonrasında oyuncular serilerden puan alabilecek. En başında tahtada bir
                seri yoksa yani oldtotalseries 0 ise oyun normal bir şekilde devam edecek ve controlFirstScreen döngüsü hiç çalışmayacak.*/
                while (oldtotalseries > 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n                 M4          M5          M6\n");
                    Console.WriteLine("            +-----------------------------------+");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine($"     M1     |     {a11}     |     {a12}     |     {a13}     |               Round : {round}");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine($"            |-----------------------------------|               Turn : {turn}");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine($"    M2      |     {a21}     |     {a22}     |     {a23}     |               Box Score : {oldtotalseries * oldtotalseries}");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |-----------------------------------|");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine($"            |           |           |           |               Player's Score : {scorePlayer}");
                    Console.WriteLine($"    M3      |     {a31}     |     {a32}     |     {a33}     |               Computer's Score : {scoreComputer}");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            |           |           |           |");
                    Console.WriteLine("            +-----------------------------------+");

                    bool validMoveEntered = false;
                    if (turnwho)//Player sırası
                    {
                        Console.Write("Player's turn. Make your move : ");
                        while (validMoveEntered == false)
                        {
                            if (int.TryParse(Console.ReadLine(), out int move1))
                            {
                                switch (move1)// Hareketlere göre matris değişimi
                                {
                                    case 1:
                                        int a14 = a11;
                                        a11 = a13;
                                        a13 = a12;
                                        a12 = a14;
                                        validMoveEntered = true;
                                        break;
                                    case 2:
                                        int a24 = a21;
                                        a21 = a23;
                                        a23 = a22;
                                        a22 = a24;
                                        validMoveEntered = true;
                                        break;
                                    case 3:
                                        int a34 = a31;
                                        a31 = a33;
                                        a33 = a32;
                                        a32 = a34;
                                        validMoveEntered = true;
                                        break;
                                    case 4:
                                        int a41 = a11;
                                        a11 = a31;
                                        a31 = a21;
                                        a21 = a41;
                                        validMoveEntered = true;
                                        break;
                                    case 5:
                                        int a42 = a12;
                                        a12 = a32;
                                        a32 = a22;
                                        a22 = a42;
                                        validMoveEntered = true;
                                        break;
                                    case 6:
                                        int a43 = a13;
                                        a13 = a33;
                                        a33 = a23;
                                        a23 = a43;
                                        validMoveEntered = true;
                                        break;
                                    default:
                                        Console.Write("Invalid move number. Select your move from 1 to 6 : ");
                                        validMoveEntered = false;  // Reset validMoveEntered to false for invalid move
                                        break;
                                }
                            }
                            else
                            {
                                Console.Write("Invalid input. Select your move from 1 to 6 : ");
                                continue;
                            }
                        }//Geçerli bir hareket girildiyse hareketi yap

                        oldtotalseries = 0;
                        if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) oldtotalseries++;
                        if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) oldtotalseries++;
                        if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) oldtotalseries++;
                        if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) oldtotalseries++;
                        if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) oldtotalseries++;
                        if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) oldtotalseries++;
                        // Çapraz seri
                        if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) oldtotalseries++;
                        if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) oldtotalseries++;

                        if (oldtotalseries == 0)
                        {
                            turn++;
                            turnwho = false;
                            break;
                        }
                        else if (oldtotalseries > 0)
                        {
                            turnwho = false;
                            turn++;
                            continue;
                        }

                    }//Player Sırası
                    if (turnwho == false) //Bilgisayaarın sırası
                    {
                        Random rndmov = new Random();
                        int move2 = rndmov.Next(1, 7);
                        Console.WriteLine("Press enter to see computers move.");
                        Console.ReadLine();
                        // Hareketlere göre matris değişimi
                        switch (move2)
                        {
                            case 1:
                                temp = a11;
                                a11 = a13;
                                a13 = a12;
                                a12 = temp;
                                break;
                            case 2:
                                temp = a21;
                                a21 = a23;
                                a23 = a22;
                                a22 = temp;
                                break;
                            case 3:
                                temp = a31;
                                a31 = a33;
                                a33 = a32;
                                a32 = temp;
                                break;
                            case 4:
                                temp = a11;
                                a11 = a31;
                                a31 = a21;
                                a21 = temp;
                                break;
                            case 5:
                                temp = a12;
                                a12 = a32;
                                a32 = a22;
                                a22 = temp;
                                break;
                            case 6:
                                temp = a13;
                                a13 = a33;
                                a33 = a23;
                                a23 = temp;
                                break;

                        }
                        oldtotalseries = 0;
                        if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) oldtotalseries++;
                        if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) oldtotalseries++;
                        if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) oldtotalseries++;
                        if (a11 == a21 + 1 && a21 == a31 + 1 || a11 == a21 - 1 && a21 == a31 - 1) oldtotalseries++;
                        if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) oldtotalseries++;
                        if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) oldtotalseries++;
                        // Çapraz seri
                        if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) oldtotalseries++;
                        if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) oldtotalseries++;
                        if (oldtotalseries == 0)
                        {
                            turn++;
                            turnwho = true;
                            break;
                        }
                        else if (oldtotalseries > 0)
                        {
                            turnwho = true;
                            turn++;
                            continue;
                        }
                    }//Bilgisayarın sırası
                }
                totalseries = 0;
                Console.Clear();
                Console.WriteLine("\n\n                 M4          M5          M6\n");
                Console.WriteLine("            +-----------------------------------+");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine($"     M1     |     {a11}     |     {a12}     |     {a13}     |               Round : {round}");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine($"            |-----------------------------------|               Turn : {turn}");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine($"    M2      |     {a21}     |     {a22}     |     {a23}     |               Box Score : {totalseries * totalseries}");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |-----------------------------------|");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine($"            |           |           |           |               Player's Score : {scorePlayer}");
                Console.WriteLine($"    M3      |     {a31}     |     {a32}     |     {a33}     |               Computer's Score : {scoreComputer}");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            |           |           |           |");
                Console.WriteLine("            +-----------------------------------+");
                if (turnwho)//Player sırası
                {
                    Console.Write("Select your move from 1 to 6 : ");
                    bool validMoveEntered = false;
                    while (validMoveEntered == false)
                    {
                        if (int.TryParse(Console.ReadLine(), out int move1))
                        {
                            switch (move1)// Hareketlere göre matris değişimi
                            {
                                case 1:
                                    int a14 = a11;
                                    a11 = a13;
                                    a13 = a12;
                                    a12 = a14;
                                    validMoveEntered = true;
                                    break;
                                case 2:
                                    int a24 = a21;
                                    a21 = a23;
                                    a23 = a22;
                                    a22 = a24;
                                    validMoveEntered = true;
                                    break;
                                case 3:
                                    int a34 = a31;
                                    a31 = a33;
                                    a33 = a32;
                                    a32 = a34;
                                    validMoveEntered = true;
                                    break;
                                case 4:
                                    int a41 = a11;
                                    a11 = a31;
                                    a31 = a21;
                                    a21 = a41;
                                    validMoveEntered = true;
                                    break;
                                case 5:
                                    int a42 = a12;
                                    a12 = a32;
                                    a32 = a22;
                                    a22 = a42;
                                    validMoveEntered = true;
                                    break;
                                case 6:
                                    int a43 = a13;
                                    a13 = a33;
                                    a33 = a23;
                                    a23 = a43;
                                    validMoveEntered = true;
                                    break;
                                    //    default:
                                    //    Console.WriteLine("Select number between 1 and 6.\nPress enter to continue. ");
                                    //    Console.ReadLine();
                                    //    continue;
                            }
                        }
                        else
                        {
                            Console.Write("Invalid move number.\nSelect your move from 1 to 6 : ");
                            continue;
                        }
                    }//Geçerli bir hareket girildiyse hareketi yap
                    if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) totalseries++;
                    if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) totalseries++;
                    if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) totalseries++;
                    if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) totalseries++;
                    if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) totalseries++;
                    if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) totalseries++;
                    // Çapraz seri
                    if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) totalseries++;
                    if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) totalseries++;
                    totalboxscore = totalseries * totalseries;
                    if (totalseries > 0)
                    {
                        scorePlayer += totalboxscore;
                        Console.Clear();
                        Console.WriteLine("\n\n                 M4          M5          M6\n");
                        Console.WriteLine("            +-----------------------------------+");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"     M1     |     {a11}     |     {a12}     |     {a13}     |               Round : {round}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"            |-----------------------------------|               Turn : {turn}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"    M2      |     {a21}     |     {a22}     |     {a23}     |               Box Score : {totalseries * totalseries}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |-----------------------------------|");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"            |           |           |           |               Player's Score : {scorePlayer}");
                        Console.WriteLine($"    M3      |     {a31}     |     {a32}     |     {a33}     |               Computer's Score : {scoreComputer}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            +-----------------------------------+");
                        Console.WriteLine($"Round {round} is over! Player won the round. Score is {totalboxscore}\nPress enter to continue.");
                        Console.ReadLine();
                        round++;
                        turn = 1;
                        //Bilgisayar random tablo oluşturuyor
                        Random rnd = new Random();
                        int[] sayi = new int[9];
                        int tutulan;
                        for (int i = 0; i < sayi.Length; i++)
                        {
                            tutulan = rnd.Next(1, 10);
                            if (i == 0)
                            {
                                sayi[i] = tutulan;
                            }
                            for (int j = 0; j < i; j++)
                            {
                                if (sayi[j] == tutulan)
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    sayi[i] = tutulan;
                                }
                            }
                        }
                        a11 = sayi[0];
                        a12 = sayi[1];
                        a13 = sayi[2];
                        a21 = sayi[3];
                        a22 = sayi[4];
                        a23 = sayi[5];
                        a31 = sayi[6];
                        a32 = sayi[7];
                        a33 = sayi[8];
                        // İlk girilen tablonun seri kontrolü. Oldtotalseries demek tahtanın ilk görünümünde seri var mı demek
                        oldtotalseries = 0;
                        if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) oldtotalseries++;
                        if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) oldtotalseries++;
                        if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) oldtotalseries++;
                        if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) oldtotalseries++;
                        if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) oldtotalseries++;
                        if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) oldtotalseries++;
                        // Çapraz seri
                        if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) oldtotalseries++;
                        if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) oldtotalseries++;
                        turnwho = true;
                        continue;
                    }
                    else
                    {
                        turn++;
                        turnwho = false;
                        continue;
                    }
                }//Player sırası
                if (turnwho == false)//Bilgisayarın sırası
                {
                    int bestmove = 0, bestmoveScore = 0;
                    int mov1Score = 0, mov2Score = 0, mov3Score = 0, mov4Score = 0, mov5Score = 0, mov6Score = 0;
                    for (int i = 1; i < 7; i++)//AI is selecting a move
                    {

                        int a11tmp = a11, a12tmp = a12, a13tmp = a13, a21tmp = a21, a22tmp = a22, a23tmp = a23, a31tmp = a31, a32tmp = a32, a33tmp = a33;
                        if (i == 1)//Move1 in getireceği puanı hesaplayacak
                        {
                            temp = a11tmp;
                            a11tmp = a13tmp;
                            a13tmp = a12tmp;
                            a12tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov1Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov1Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov1Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov1Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov1Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov1Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov1Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov1Score++;
                        }
                        if (i == 2)//Move2 nin getireceği puanı hesaplayacak
                        {
                            temp = a21tmp;
                            a21tmp = a23tmp;
                            a23tmp = a22tmp;
                            a22tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov2Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov2Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov2Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov2Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov2Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov2Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov2Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov2Score++;
                        }
                        if (i == 3)//Move3 ün getireceği puanı hesaplayacak
                        {
                            temp = a31tmp;
                            a31tmp = a33tmp;
                            a33tmp = a32tmp;
                            a32tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov3Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov3Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov3Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov3Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov3Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov3Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov3Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov3Score++;
                        }
                        if (i == 4)//Move4 ün getireceği puanı hesaplayacak
                        {
                            temp = a11tmp;
                            a11tmp = a31tmp;
                            a31tmp = a21tmp;
                            a21tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov4Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov4Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov4Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov4Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov4Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov4Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov4Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov4Score++;
                        }
                        if (i == 5)//Move1 in getireceği puanı hesaplayacak
                        {
                            temp = a12tmp;
                            a12tmp = a32tmp;
                            a32tmp = a22tmp;
                            a22tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov5Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov5Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov5Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov5Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov5Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov5Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov5Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov5Score++;
                        }
                        if (i == 6)//Move1 in getireceği puanı hesaplayacak
                        {
                            temp = a13tmp;
                            a13tmp = a33tmp;
                            a33tmp = a23tmp;
                            a23tmp = temp;
                            if (a11tmp == a12tmp + 1 && a12tmp == a13tmp + 1 || a11tmp == a12tmp - 1 && a12tmp == a13tmp - 1) mov6Score++;
                            if (a21tmp == a22tmp + 1 && a22tmp == a23tmp + 1 || a21tmp == a22tmp - 1 && a22tmp == a23tmp - 1) mov6Score++;
                            if (a31tmp == a32tmp + 1 && a32tmp == a33tmp + 1 || a31tmp == a32tmp - 1 && a32tmp == a33tmp - 1) mov6Score++;
                            if (a11tmp == a21tmp + 1 && a21tmp == a31tmp + 1 || a11tmp == a21tmp - 1 && a21tmp == a31tmp - 1) mov6Score++;
                            if (a12tmp == a22tmp + 1 && a22tmp == a32tmp + 1 || a12tmp == a22tmp - 1 && a22tmp == a32tmp - 1) mov6Score++;
                            if (a13tmp == a23tmp + 1 && a23tmp == a33tmp + 1 || a13tmp == a23tmp - 1 && a23tmp == a33tmp - 1) mov6Score++;
                            // Çapraz seri
                            if (a31tmp == a22tmp + 1 && a22tmp == a13tmp + 1 || a31tmp == a22tmp - 1 && a22tmp == a13tmp - 1) mov6Score++;
                            if (a33tmp == a22tmp + 1 && a22tmp == a11tmp + 1 || a33tmp == a22tmp - 1 && a22tmp == a11tmp - 1) mov6Score++;
                        }
                    }
                    if (mov1Score > bestmoveScore)
                    {
                        bestmoveScore = mov1Score;
                        bestmove = 1;
                    }
                    if (mov2Score > bestmoveScore)
                    {
                        bestmoveScore = mov2Score;
                        bestmove = 2;
                    }
                    if (mov3Score > bestmoveScore)
                    {
                        bestmoveScore = mov3Score;
                        bestmove = 3;
                    }
                    if (mov4Score > bestmoveScore)
                    {
                        bestmoveScore = mov4Score;
                        bestmove = 4;
                    }
                    if (mov5Score > bestmoveScore)
                    {
                        bestmoveScore = mov5Score;
                        bestmove = 5;
                    }
                    if (mov6Score > bestmoveScore)
                    {
                        bestmoveScore = mov6Score;
                        bestmove = 6;
                    }
                    if (bestmoveScore == 0)
                    {
                        Random rnd = new Random();
                        bestmove = rnd.Next(1, 7);
                    }
                    Console.WriteLine("Computer's turn. Press enter to see computer's move.");
                    Console.ReadLine();
                    // Hareketlere göre matris değişimi
                    switch (bestmove)
                    {
                        case 1:
                            temp = a11;
                            a11 = a13;
                            a13 = a12;
                            a12 = temp;
                            break;
                        case 2:
                            temp = a21;
                            a21 = a23;
                            a23 = a22;
                            a22 = temp;
                            break;
                        case 3:
                            temp = a31;
                            a31 = a33;
                            a33 = a32;
                            a32 = temp;
                            break;
                        case 4:
                            temp = a11;
                            a11 = a31;
                            a31 = a21;
                            a21 = temp;
                            break;
                        case 5:
                            temp = a12;
                            a12 = a32;
                            a32 = a22;
                            a22 = temp;
                            break;
                        case 6:
                            temp = a13;
                            a13 = a33;
                            a33 = a23;
                            a23 = temp;
                            break;

                    }
                    totalseries = 0;
                    if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) totalseries++;
                    if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) totalseries++;
                    if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) totalseries++;
                    if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) totalseries++;
                    if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) totalseries++;
                    if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) totalseries++;
                    // Çapraz seri
                    if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) totalseries++;
                    if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) totalseries++;
                    totalboxscore = totalseries * totalseries;
                    if (totalseries > 0)
                    {
                        scoreComputer += totalboxscore;
                        Console.Clear();
                        Console.WriteLine("\n\n                 M4          M5          M6\n");
                        Console.WriteLine("            +-----------------------------------+");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"     M1     |     {a11}     |     {a12}     |     {a13}     |               Round : {round}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"            |-----------------------------------|               Turn : {turn}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"    M2      |     {a21}     |     {a22}     |     {a23}     |               Box Score : {totalseries * totalseries}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |-----------------------------------|");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine($"            |           |           |           |               Player's Score : {scorePlayer}");
                        Console.WriteLine($"    M3      |     {a31}     |     {a32}     |     {a33}     |               Computer's Score : {scoreComputer}");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            |           |           |           |");
                        Console.WriteLine("            +-----------------------------------+");
                        Console.WriteLine($"Round {round} is over! Computer won the round. Score is {totalboxscore}\nPress enter to continue.");
                        Console.ReadLine();
                        round++;
                        turn = 1;
                        //Bilgisayar random tablo oluşturuyor
                        Random rnd = new Random();
                        int[] sayi = new int[9];
                        int tutulan;

                        for (int i = 0; i < sayi.Length; i++)
                        {
                            tutulan = rnd.Next(1, 10);
                            if (i == 0)
                            {
                                sayi[i] = tutulan;
                            }
                            for (int j = 0; j < i; j++)
                            {
                                if (sayi[j] == tutulan)
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    sayi[i] = tutulan;
                                }
                            }
                        }//Random tablo oluşturma
                        a11 = sayi[0];
                        a12 = sayi[1];
                        a13 = sayi[2];
                        a21 = sayi[3];
                        a22 = sayi[4];
                        a23 = sayi[5];
                        a31 = sayi[6];
                        a32 = sayi[7];
                        a33 = sayi[8];
                        turnwho = true;
                        // İlk girilen tablonun seri kontrolü. Oldtotalseries demek tahtanın ilk görünümünde seri var mı demek
                        oldtotalseries = 0;
                        if (a11 == a12 + 1 && a12 == a13 + 1 || a11 == a12 - 1 && a12 == a13 - 1) oldtotalseries++;
                        if (a21 == a22 + 1 && a22 == a23 + 1 || a21 == a22 - 1 && a22 == a23 - 1) oldtotalseries++;
                        if (a31 == a32 + 1 && a32 == a33 + 1 || a31 == a32 - 1 && a32 == a33 - 1) oldtotalseries++;
                        if (a11 == a21 + 1 && a31 == a21 + 1 || a11 == a21 - 1 && a31 == a21 - 1) oldtotalseries++;
                        if (a12 == a22 + 1 && a22 == a32 + 1 || a12 == a22 - 1 && a22 == a32 - 1) oldtotalseries++;
                        if (a13 == a23 + 1 && a23 == a33 + 1 || a13 == a23 - 1 && a23 == a33 - 1) oldtotalseries++;
                        // Çapraz seri
                        if (a31 == a22 + 1 && a22 == a13 + 1 || a31 == a22 - 1 && a22 == a13 - 1) oldtotalseries++;
                        if (a33 == a22 + 1 && a22 == a11 + 1 || a33 == a22 - 1 && a22 == a11 - 1) oldtotalseries++;
                        continue;
                    }
                    else
                    {
                        turn++;
                        turnwho = true;
                        continue;
                    }
                }//Computer sırası
            }
            if (round == 6)
            {
                Console.WriteLine("GAME IS OVER!");
                if (scoreComputer < scorePlayer)
                {
                    Console.WriteLine("Congratulations! Player won the game.");
                    Console.Write($"Player : {scorePlayer} Computer : {scoreComputer}");
                }
                else if (scorePlayer < scoreComputer)
                {
                    Console.WriteLine("Computer won the game.");
                    Console.Write($"Player : {scorePlayer} Computer : {scoreComputer}");
                }
                else
                {
                    Console.WriteLine("Draw...");
                    Console.Write($"Player : {scorePlayer} Computer : {scoreComputer}");
                }
                Console.ReadLine();
            }
        }
    }
}