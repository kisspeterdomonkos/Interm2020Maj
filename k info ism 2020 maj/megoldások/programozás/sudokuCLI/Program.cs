//1. feladat: Készítsen konzolos alkalmazást a következő feladatok megoldására, amelynek projektjét sudokuCLI néven mentse el!
namespace sudokuCLI
{
/*2. feladat: A forráskódba a meglévő osztály elé illessze be az Osztaly.java avagy az Osztaly.cs
    forrásállományból a Feladvany osztályt definiáló kódrészletét! A beillesztett osztály 
    tetszés szerint bővíthető további tagokkal!*/
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
    internal class Program
    {
        /*3. feladat: Olvassa be a feladvanyok.txt állományban lévő adatokat és tárolja el egy olyan 
            adatszerkezetben, ami a további feladatok megoldására alkalmas! Határozza meg és írja ki 
            a képernyőre a minta szerint, hogy hány feladvány található a forrásállományban!*/
        static List<Feladvany> dataList = new List<Feladvany>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                Feladvany data = new Feladvany(sr.ReadLine());
                dataList.Add(data);
            }
            sr.Close();
            Console.WriteLine($"3. feladat: Beolvasva {dataList.Count} feladvány");

            /*4. feladat: Kérjen be a felhasználótól egy 4...9 intervallumba eső (4≤x≤9) egész számot! A beolvasást 
                addig ismételje, amíg a megfelelő értékhatárból érkező számot nem kapjuk! Határozza meg, 
                és írja a képernyőre, hogy ebből a méretből hány feladvány található a forrásállományban!*/
            int x;
            do 
            {
                Console.Write("4. feladat: Kérem a feladvány méretét [4..9]:");
                x = int.Parse(Console.ReadLine());
            }
            while (x < 4 || x > 9);

            int cnt = 0;
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].Meret.Equals(x))
                {
                    cnt++;
                }
            }
            Console.WriteLine($"{x} x {x} méretű feladványból {cnt} van tárolva");

            /*5. feladat: Válasszon ki véletlenszerűen egy feladványt, amely az előző feladatban bekért méretű! 
                A kiválasztott feladványt jelenítse meg a képernyőn a minta szerint! Ha nem sikerült 
                véletlenszerű feladványt kiválasztani, akkor dolgozzon a legelső beolvasott feladvánnyal!*/
            Random rnd = new Random();
            string selected = "";
            int sIdx = 0;
            do
            {
                sIdx = rnd.Next(0, dataList.Count);
                selected = dataList[sIdx].Kezdo;
                
            } while (selected.Length != x * x);
            Console.WriteLine($"5. feladat: A kiválasztott feladvány: \n{selected}");

            /*6. feladat: Határozza meg és írja a képernyőre a kiválasztott feladvány kitöltöttségét %-os formában
                a minta szerint! A kitöltöttségen a kitöltött mezők arányát értjük az összes mező számához
                viszonyítva! A százalékos értéket egész számra kerekítve jelenítse meg!*/
            int fillCnt = 0;
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] != '0')
                {
                    fillCnt++;
                }
            }
            Console.WriteLine($"6. feladat: A feladvány kitöltöttége: {Math.Round(((double)fillCnt/selected.Length) *100, 0)}%");

            //7. feladat: A Feladvany osztály megfelelő metódusát felhasználva jelenítse meg a kiválasztott feladványt a konzolon!
            Console.WriteLine("7. feladat: A feladvány kirajzolva:");
            dataList[sIdx].Kirajzol();

            /*8. feladat: Válogassa ki és írja ki fájlba az adott méretű feladványokat! Ha például a felhasználó a 4-es 
                méretet adta meg, akkor a kimeneten egy sudoku4.txt állományba kerüljenek a 4x4-es 
                méretű feladványok! Az állományban soronként egy feladvány kerüljön!*/
            StreamWriter sw = new StreamWriter($"sudoku{x}.txt");
            List<Feladvany> list = new();
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].Meret.Equals(x))
                {
                    list.Add(dataList[i]);
                    sw.WriteLine(dataList[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine($"8. feladat: sudoku{x}.txt állomány {list.Count} darab feladvánnyal létrehozva");

            Console.ReadKey();
        }
    }
}
