using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falaq_Project
{
    class Logic
    {
        public static int besarAwalorSani(int[] define, int[] define2)
        {
            int result;
            if (define[2] > define2[2])
            {
                result = 1;
            }
            else if (define[2] < define2[2])
            {
                result = 2;
            }
            else if (define[1] > define2[1])
            {
                result = 1;
            }
            else if (define[1] < define2[1])
            {
                result = 2;
            }
            else if (define[0] > define2[0])
            {
                result = 1;
            }
            else if (define[0] < define2[0])
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public static int[,] PerkalianTakdil(int a2, int a1, int b2, int b1)
        {
            int[,] array = new int[1, 3];
            array[0, 0] = a2 * b2;
            int num = a2 * b1;
            int num2 = a1 * b2;
            array[0, 1] = num + num2;
            array[0, 2] = a1 * b1;
            return array;
        }
        public static int[,] LogikaTakdil(int rawabi, int sawalis, int sawani)
        {
            int[,] hasil = new int[1, 3];
            int sawalis1 = rawabi / 60;
            int jaberRawabi = rawabi % 60;
            if (jaberRawabi >= 30 && jaberRawabi < 60)
            {
                sawalis1++;
            }
            int a = sawalis + sawalis1;
            int sawani1 = a / 60;
            int jaberSawalis = a % 60;
            if (jaberSawalis >= 30 && jaberSawalis < 60)
            {
                sawani1++;
            }
            int daqiqoh = sawani + sawani1;
            hasil[0, 0] = daqiqoh % 60;
            hasil[0, 1] = daqiqoh / 60;
            return hasil;

        }
        public static int[] DefineAwalOrSani(int pangkat, int[] define, int[] define2)
        {
            int[] result;
            if (pangkat == 1)
            {
                result = Operation.awalMinSani(define, define2);
            }
            else
            {
                result = Operation.saniMinAwal(define2, define);
            }
            return result;

        }
        public static int[,] additionForTakdil(int sawani, int daqiqoh, int darojah, int buruj)
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
            foreach (var i in hasil)
            {

                Console.Write(i + " , ");
            }
            return hasil;
        }

        public static int[,] subtractForTakdil(int sawani, int sawani2, int daqiqoh, int daqiqoh2, int darojah,
            int darojah2)
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
            }
            int c = darojah - darojah2;
            int[,] hasil = new int[1, 4];
            hasil[0, 0] = a;
            hasil[0, 1] = b;
            hasil[0, 2] = c;
            foreach (var i in hasil)
            {

                Console.Write(i + " , ");
            }
            return hasil;
        }
        public static int[,] TakdilSaniLogic(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] hasilDalilSani)
        {
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = PerkalianTakdil(hasil[0], hasil[1], hasilDalilSani[0, 0], hasilDalilSani[0,1]);
            int[,] araay = LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }
        public static int[,] LogicTakdilSalis(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] dalilsalis)
        {
            Console.Write("\nTakdil Salis : ");
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = PerkalianTakdil(hasil[0], hasil[1], dalilsalis[0, 0], dalilsalis[0,1]);
            int[,] araay = LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }
        public static int[,] LogicTakdilrobi(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] dalilRobi)
        {
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = PerkalianTakdil(hasil[0], hasil[1], dalilRobi[0, 0], dalilRobi[0,1]);
            int[,] araay = LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }
        public static int[,] LogicTakdiluqdah(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] alhaqiqifinal)
        {
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = PerkalianTakdil(hasil[0], hasil[1], alhaqiqifinal[1, 0], alhaqiqifinal[1, 1]);
            int[,] araay = LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }
        public static int[,] LogicTakdilkhomis(int defineAwal_Sani, int[] satrAwal, int[] satrSani, int[,] dalilkhomis)
        {
            int[] hasil = Logic.DefineAwalOrSani(defineAwal_Sani, satrAwal, satrSani);
            int[,] hasilPerkalian = PerkalianTakdil(hasil[0], hasil[1], dalilkhomis[0, 0], dalilkhomis[0,1]);
            int[,] araay = LogikaTakdil(hasilPerkalian[0, 0], hasilPerkalian[0, 1], hasilPerkalian[0, 2]);
            int[,] HasilTakdil = Operation.HasilTakdil(defineAwal_Sani, araay, satrAwal);
            return HasilTakdil;
        }
    }
}
