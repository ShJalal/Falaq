using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falaq_Project
{
    class Operation
    {
        public static int[,] addition(int sawani, int daqiqoh, int darojah, int buruj)
        {
            int a = sawani % 60;
            if (a == 60)
            {
                a = 0;
            }
            int devide = sawani / 60;
            int b = (daqiqoh % 60) + devide;
            if (b == 60)
            {
                b = 0;
            }
            int devide2 = daqiqoh / 60;
            int d = (darojah % 30) + devide2;
            if (d == 30)
            {
                d = 0;
            }
            int devide3 = darojah / 30;
            int e = buruj % 12 + devide3;
            if (e == 12)
            {
                e = 0;
            }
            int devide4 = buruj / 12;
            int[,] hasil = new int[1, 4];
            hasil[0, 0] = a;
            hasil[0, 1] = b;
            hasil[0, 2] = d;
            hasil[0, 3] = e;
            foreach (var VARIABLE in hasil)
            {
                Console.Write(VARIABLE + " , ");
            }
            return hasil;
        }

        public static int[,] subtract(int sawani, int sawani2, int daqiqoh, int daqiqoh2, int darojah,
            int darojah2, int buruj, int buruj2)
        {
            if (sawani < sawani2)
            {
                sawani += 60;
                daqiqoh -= 1;
            }
            int a = sawani - sawani2;
            if (daqiqoh < daqiqoh2)
            {
                daqiqoh += 60;
                darojah -= 1;
            }
            int b = daqiqoh - daqiqoh2;

            if (darojah < darojah2)
            {
                darojah += 30;
                buruj -= 1;
            }
            int c = darojah - darojah2;

            if (buruj < buruj2)
            {
                buruj += 12;
            }
            int d = buruj - buruj2;
            int[,] hasil = new int[1, 4];
            hasil[0, 0] = a;
            hasil[0, 1] = b;
            hasil[0, 2] = c;
            hasil[0, 3] = d;
            foreach (var VARIABLE in hasil)
            {
                Console.Write(VARIABLE + " , ");
            }
            return hasil;
        }

        public static int[] awalMinSani(int[] awal, int[] sani)
        {
            if (awal[0] < sani[0])
            {
                awal[0] += 60;
                awal[1] -= 1;
            }
            int a = awal[0] - sani[0];
            if (awal[1] < sani[1])
            {
                awal[1] += 30;
                awal[2] -= 1;
            }
            int b = awal[1] - sani[1];
            if (awal[2] < sani[2])
            {
                awal[2] += 12;
            }
            int c = awal[2] - sani[2];
            int[] hasil = new[] { a, b, c };
            return hasil;
        }

        public static int[] saniMinAwal(int[] sani, int[] awal)
        {
            if (sani[0] < awal[0])
            {
                sani[0] += 60;
                sani[1] -= 1;
            }
            int a = sani[0] - awal[0];
            if (sani[1] < awal[1])
            {
                sani[1] += 30;
                sani[2] -= 1;
            }
            int b = sani[1] - awal[1];
            if (sani[2] < awal[2])
            {
                sani[2] += 12;
            }
            int c = sani[2] - awal[2];
            int[] hasil = new[] { a, b, c };
            return hasil;
        }
        public static int[,] HasilTakdil(int besarAwalOrSani, int[,] araay, int[] satrAwal)
        {
            int[,] hasilTakdilSyams = new int[1, 4];
            if (besarAwalOrSani == 1)
            {

                hasilTakdilSyams = Logic.subtractForTakdil(satrAwal[0], araay[0, 0], satrAwal[1], araay[0, 1],
                    satrAwal[2], araay[0, 2]);
            }
            else
            {

                int sawan = araay[0, 0] + satrAwal[0];
                int b = araay[0, 1] + satrAwal[1];
                int c = araay[0, 2] + satrAwal[2];
                hasilTakdilSyams = Logic.additionForTakdil(sawan, b, c, hasilTakdilSyams[0, 3]);
            }
            return hasilTakdilSyams;
        }
        public static int[,] Takdil(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] alhaqiqifinal)
        {
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = Logic.PerkalianTakdil(hasil[0], hasil[1], alhaqiqifinal[1, 0], alhaqiqifinal[1, 1]);
            int[,] araay = Logic.LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }


       
    }
}
