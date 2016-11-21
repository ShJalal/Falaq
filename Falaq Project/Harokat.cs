using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falaq_Project
{
    class Harokat
    {
        public static int majmu = 1410;
        public static int[,] FindingMajmu(int tahun)
        {
            int[,] result;
            if (tahun >= 1410 || tahun == 1440)
            {
                result = new int[,] { { 44, 38, 0, 4 }, { 2, 38, 17, 0 }, { 2, 48, 8, 4 }, { 37, 20, 9, 8 }, { 28, 24, 22, 1 } };
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[,] FindingMabsutoh(int mabsutoh)
        {
            int[,] harokatMabsutoh;
            mabsutoh -= 1;
            int nilai = mabsutoh - Harokat.majmu;
            if (nilai == 1)
            {
                harokatMabsutoh = new int[,] { { 9, 55, 18, 11 }, { 5, 54, 18, 11 }, { 40, 26, 14, 11 }, { 22, 0, 5, 10 }, { 46, 44, 18, 0 } };
            }
            else if (nilai == 2)
            {
                harokatMabsutoh = new int[,] { { 26, 49, 8, 11 }, { 19, 47, 8, 11 }, { 55, 3, 12, 11 }, { 37, 4, 23, 8 }, { 43, 32, 7, 1 } };
            }
            else if (nilai == 3)
            {
                harokatMabsutoh = new int[,] { { 35, 44, 27, 10 }, { 24, 41, 27, 10 }, { 36, 30, 26, 10 }, { 59, 4, 28, 6 }, { 29, 17, 26, 1 } };
            }
            else if (nilai == 4)
            {
                harokatMabsutoh = new int[,] { { 44, 39, 16, 10 }, { 30, 35, 16, 10 }, { 16, 57, 10, 10 }, { 21, 5, 3, 5 }, { 15, 2, 15, 2 } };
            }
            else if (nilai == 5)
            {
                harokatMabsutoh = new int[,] { { 1, 34, 6, 10 }, { 43, 28, 6, 10 }, { 31, 34, 8, 10 }, { 37, 9, 21, 3 }, { 11, 50, 3, 3 } };
            }
            else if (nilai == 6)
            {
                harokatMabsutoh = new int[,] { { 10, 29, 25, 9 }, { 48, 22, 25, 9 }, { 11, 1, 23, 9 }, { 58, 9, 26, 1 }, { 57, 34, 22, 3 } };
            }
            else if (nilai == 7)
            {
                harokatMabsutoh = new int[,] { { 27, 23, 15, 9 }, { 2, 26, 15, 9 }, { 16, 38, 20, 9 }, { 14, 14, 14, 0 }, { 54, 22, 11, 4 } };
            }
            else if (nilai == 8)
            {
                harokatMabsutoh = new int[,] { { 36, 18, 4, 9 }, { 7, 10, 4, 9 }, { 6, 5, 5, 9 }, { 36, 14, 19, 10 }, { 40, 7, 0, 5 } };
            }
            else if (nilai == 9)
            {
                harokatMabsutoh = new int[,] { { 45, 13, 23, 8 }, { 13, 4, 23, 8 }, { 47, 31, 19, 8 }, { 58, 14, 24, 8 }, { 6, 52, 18, 5 } };
            }
            else if (nilai == 10)
            {
                harokatMabsutoh = new int[,] { { 2, 8, 13, 8 }, { 26, 57, 12, 8 }, { 2, 9, 17, 8 }, { 13, 19, 12, 7 }, { 22, 40, 7, 6 } };
            }
            else if (nilai == 11)
            {
                harokatMabsutoh = new int[,] { { 11, 3, 2, 8 }, { 32, 51, 1, 8 }, { 42, 35, 1, 8 }, { 35, 19, 17, 5 }, { 8, 25, 26, 6 } };
            }
            else if (nilai == 12)
            {
                harokatMabsutoh = new int[,] { { 20, 58, 20, 7 }, { 37, 45, 20, 7 }, { 22, 2, 16, 7 }, { 57, 19, 22, 3 }, { 54, 9, 15, 7 } };
            }
            else if (nilai == 13)
            {
                harokatMabsutoh = new int[,] { { 37, 52, 10, 7 }, { 51, 38, 10, 7 }, { 37, 39, 13, 7 }, { 13, 24, 10, 2 }, { 51, 57, 3, 8 } };
            }
            else if (nilai == 14)
            {
                harokatMabsutoh = new int[,] { { 46, 47, 29, 6 }, { 56, 32, 29, 6 }, { 17, 6, 28, 6 }, { 34, 24, 15, 0 }, { 37, 42, 22, 8 } };
            }
            else if (nilai == 15)
            {
                harokatMabsutoh = new int[,] { { 3, 42, 19, 6 }, { 9, 26, 19, 6 }, { 33, 43, 25, 6 }, { 50, 28, 3, 11 }, { 33, 30, 11, 9 } };
            }
            else if (nilai == 16)
            {
                harokatMabsutoh = new int[,] { { 12, 37, 8, 6 }, { 15, 20, 8, 6 }, { 13, 10, 10, 6 }, { 12, 29, 8, 9 }, { 19, 15, 0, 10 } };
            }
            else if (nilai == 17)
            {
                harokatMabsutoh = new int[,] { { 21, 32, 27, 5 }, { 20, 14, 27, 5 }, { 53, 36, 24, 5 }, { 33, 29, 13, 7 }, { 5, 0, 19, 10 } };
            }
            else if (nilai == 18)
            {
                harokatMabsutoh = new int[,] { { 38, 26, 17, 5 }, { 34, 7, 17, 5 }, { 8, 14, 22, 5 }, { 49, 33, 1, 6 }, { 2, 48, 7, 11 } };
            }
            else if (nilai == 19)
            {
                harokatMabsutoh = new int[,] { { 47, 21, 6, 5 }, { 39, 1, 6, 5 }, { 48, 40, 6, 5 }, { 11, 34, 6, 4 }, { 48, 32, 26, 11 } };
            }
            else if (nilai == 20)
            {
                harokatMabsutoh = new int[,] { { 56, 16, 25, 4 }, { 45, 55, 24, 4 }, { 28, 7, 21, 4 }, { 33, 34, 11, 2 }, { 34, 17, 15, 0 } };
            }
            else if (nilai == 21)
            {
                harokatMabsutoh = new int[,] { { 13, 11, 15, 4 }, { 58, 48, 14, 4 }, { 44, 44, 18, 4 }, { 48, 38, 29, 0 }, { 31, 5, 4, 1 } };
            }
            else if (nilai == 22)
            {
                harokatMabsutoh = new int[,] { { 22, 6, 4, 4 }, { 4, 43, 3, 4 }, { 24, 11, 3, 4 }, { 10, 39, 4, 11 }, { 17, 50, 22, 1 } };
            }
            else if (nilai == 23)
            {
                harokatMabsutoh = new int[,] { { 31, 1, 23, 3 }, { 9, 37, 22, 3 }, { 4, 38, 17, 3 }, { 32, 39, 9, 9 }, { 3, 35, 11, 2 } };
            }
            else if (nilai == 24)
            {
                harokatMabsutoh = new int[,] { { 48, 55, 12, 3 }, { 22, 30, 12, 3 }, { 19, 15, 15, 3 }, { 47, 43, 27, 7 }, { 59, 22, 0, 3 } };
            }
            else if (nilai == 25)
            {
                harokatMabsutoh = new int[,] { { 57, 50, 1, 3 }, { 28, 24, 1, 3 }, { 59, 41, 29, 2 }, { 9, 44, 2, 6 }, { 45, 7, 19, 3 } };
            }
            else if (nilai == 26)
            {
                harokatMabsutoh = new int[,] { { 14, 45, 21, 2 }, { 41, 17, 21, 2 }, { 15, 19, 27, 2 }, { 25, 48, 20, 4 }, { 42, 55, 7, 4 } };
            }
            else if (nilai == 27)
            {
                harokatMabsutoh = new int[,] { { 23, 40, 10, 2 }, { 46, 11, 10, 2 }, { 55, 45, 11, 2 }, { 47, 48, 25, 2 }, { 28, 40, 26, 4 } };
            }
            else if (nilai == 28)
            {
                harokatMabsutoh = new int[,] { { 32, 35, 29, 1 }, { 52, 5, 29, 1 }, { 35, 12, 26, 1 }, { 8, 49, 0, 1 }, { 14, 25, 15, 5 } };
            }
            else if (nilai == 29)
            {
                harokatMabsutoh = new int[,] { { 49, 29, 19, 1 }, { 6, 59, 18, 1 }, { 50, 49, 23, 1 }, { 24, 53, 18, 11 }, { 10, 13, 4, 6 } };
            }
            else if (nilai == 30)
            {
                harokatMabsutoh = new int[,] { { 58, 34, 8, 1 }, { 11, 53, 7, 1 }, { 30, 16, 8, 1 }, { 46, 53, 23, 9 }, { 56, 57, 22, 6 } };
            }
            else
            {
                harokatMabsutoh = null;
            }
            return harokatMabsutoh;
        }
        public static int[,] FindingSyahr(int inputBulan)
        {
            int[,] syahr;
            inputBulan -= 2;
            if (inputBulan == 1)//muharrom
            {
                syahr = new int[,] { { 10, 34, 29, 0 }, { 5, 34, 29, 0 }, { 31, 17, 5, 1 }, { 56, 56, 1, 1 }, { 19, 35, 1, 0 } };
            }
            else if (inputBulan == 2)//sofar
            {
                syahr = new int[,] { { 11, 9, 28, 1 }, { 0, 9, 28, 1 }, { 27, 24, 27, 1 }, { 4, 50, 20, 1 }, { 28, 7, 3, 0 } };

            }
            else if (inputBulan == 3)//Robiul awal
            {
                syahr = new int[,] { { 21, 43, 27, 2 }, { 4, 43, 27, 2 }, { 17, 41, 2, 3 }, { 2, 47, 22, 2 }, { 47, 42, 4, 0 } };
            }
            else if (inputBulan == 4)//Robius sani
            {
                syahr = new int[,] { { 23, 18, 26, 3 }, { 2, 18, 26, 3 }, { 53, 48, 24, 3 }, { 7, 40, 11, 3 }, { 55, 14, 6, 0 } };
            }
            else if (inputBulan == 5)//Jumadil awal
            {
                syahr = new int[,] { { 33, 52, 25, 4 }, { 6, 52, 25, 4 }, { 24, 6, 0, 5 }, { 6, 37, 13, 4 }, { 14, 50, 7, 0 } };
            }
            else if (inputBulan == 6)//jumadil akhir
            {
                syahr = new int[,] { { 34, 27, 24, 5 }, { 2, 27, 24, 5 }, { 20, 13, 22, 5 }, { 11, 30, 2, 5 }, { 22, 22, 9, 0 } };
            }
            else if (inputBulan == 7)//rojab
            {
                syahr = new int[,] { { 44, 1, 24, 6 }, { 8, 1, 24, 6 }, { 51, 30, 27, 6 }, { 10, 27, 4, 6 }, { 42, 57, 10, 0 } };
            }
            else if (inputBulan == 8)//syaban
            {
                syahr = new int[,] { { 46, 36, 22, 7 }, { 4, 36, 22, 7 }, { 46, 37, 19, 7 }, { 14, 20, 23, 6 }, { 51, 29, 12, 0 } };
            }
            else if (inputBulan == 9)//romadhon
            {
                syahr = new int[,] { { 56, 10, 22, 8 }, { 8, 60, 32, 8 }, { 17, 55, 24, 5 }, { 13, 17, 25, 7 }, { 10, 5, 14, 0 } };
            }
            else if (inputBulan == 10)//syawal
            {
                syahr = new int[,] { { 57, 45, 20, 9 }, { 4, 45, 20, 9 }, { 13, 2, 17, 9 }, { 18, 10, 14, 8 }, { 18, 37, 15, 0 } };
            }
            else if (inputBulan == 11)//dzul qo'dah
            {
                syahr = new int[,] { { 7, 20, 20, 10 }, { 9, 19, 20, 10 }, { 44, 19, 22, 10 }, { 7, 7, 16, 9 }, { 37, 12, 17, 0 } };
            }
            else if (inputBulan == 12)//dzul hijjah
            {
                syahr = new int[,] { { 9, 55, 18, 11 }, { 5, 54, 18, 11 }, { 40, 26, 14, 11 }, { 22, 0, 5, 10 }, { 46, 44, 18, 0 } };
            }
            else
            {
                syahr = null;
            }
            return syahr;
        }
        public static int[,] FindingAyyam(int inputayyam)
        {
            int[,] ayyam;
            if (inputayyam == 28)
            {
                ayyam = new int[,] { { 53, 35, 27, 0 }, { 48, 35, 27, 0 }, { 21, 56, 8, 0 }, { 11, 49, 5, 0 }, { 58, 28, 1, 0 } };
            }
            else if (inputayyam == 29)
            {
                ayyam = new int[,] { { 2, 35, 28, 0 }, { 57, 34, 28, 0 }, { 56, 6, 22, 0 }, { 5, 53, 18, 0 }, { 9, 32, 1, 0 } };
            }
            else if (inputayyam == 30)
            {
                ayyam = new int[,] { { 10, 34, 29, 0 }, { 5, 34, 29, 0 }, { 31, 17, 5, 1 }, { 59, 56, 1, 1 }, { 19, 35, 1, 0 } };
            }
            else
            {
                ayyam = null;
            }
            return ayyam;
        }
        public static int[,] FindingSaah(int inputsaah)
        {
            int[,] saah;
            if (inputsaah == 1)
            {
                saah = new int[,] { { 28, 2, 0, 0 }, { 28, 3, 0, 0 }, { 56, 32, 0, 0 }, { 59, 32, 0, 0 }, { 8, 0, 0, 0 } };
            }
            else if (inputsaah == 2)
            {
                saah = new int[,] { { 56, 4, 0, 0 }, { 56, 4, 0, 0 }, { 53, 5, 1, 0 }, { 20, 5, 1, 0 }, { 16, 0, 0, 0 } };
            }
            else if (inputsaah == 3)
            {
                saah = new int[,] { { 24, 7, 0, 0 }, { 24, 7, 0, 0 }, { 49, 38, 1, 0 }, { 59, 37, 1, 0 }, { 24, 0, 0, 0 } };
            }
            else if (inputsaah == 4)
            {
                saah = new int[,] { { 51, 9, 0, 0 }, { 51, 9, 0, 0 }, { 46, 11, 2, 0 }, { 39, 10, 2, 0 }, { 32, 0, 0, 0 } };
            }
            else if (inputsaah == 5)
            {
                saah = new int[,] { { 19, 12, 0, 0 }, { 19, 12, 0, 0 }, { 42, 44, 2, 0 }, { 18, 43, 2, 0 }, { 40, 0, 0, 0 } };
            }
            else if (inputsaah == 6)
            {
                saah = new int[,] { { 47, 14, 0, 0 }, { 47, 14, 0, 0 }, { 39, 17, 3, 0 }, { 59, 15, 3, 0 }, { 48, 0, 0, 0 } };
            }
            else if (inputsaah == 7)
            {
                saah = new int[,] { { 15, 17, 0, 0 }, { 15, 17, 0, 0 }, { 35, 50, 3, 0 }, { 38, 48, 3, 0 }, { 56, 0, 0, 0 } };
            }
            else if (inputsaah == 8)
            {
                saah = new int[,] { { 43, 19, 0, 0 }, { 43, 19, 0, 0 }, { 32, 23, 4, 0 }, { 18, 21, 4, 0 }, { 4, 1, 0, 0 } };
            }
            else if (inputsaah == 9)
            {
                saah = new int[,] { { 11, 22, 0, 0 }, { 11, 22, 0, 0 }, { 28, 56, 4, 0 }, { 58, 53, 4, 0 }, { 11, 1, 0, 0 } };
            }
            else if (inputsaah == 10)
            {
                saah = new int[,] { { 38, 24, 0, 0 }, { 38, 24, 0, 0 }, { 25, 29, 5, 0 }, { 38, 26, 5, 0 }, { 19, 1, 0, 0 } };
            }
            else if (inputsaah == 11)
            {
                saah = new int[,] { { 6, 27, 0, 0 }, { 6, 27, 0, 0 }, { 21, 2, 6, 0 }, { 17, 59, 5, 0 }, { 27, 1, 0, 0 } };
            }
            else if (inputsaah == 12)
            {
                saah = new int[,] { { 34, 29, 0, 0 }, { 34, 29, 0, 0 }, { 18, 35, 6, 0 }, { 57, 31, 6, 0 }, { 35, 1, 0, 0 } };
            }
            else if (inputsaah == 13)
            {
                saah = new int[,] { { 2, 32, 0, 0 }, { 2, 32, 0, 0 }, { 14, 8, 7, 0 }, { 37, 4, 7, 0 }, { 43, 1, 0, 0 } };
            }
            else if (inputsaah == 14)
            {
                saah = new int[,] { { 30, 34, 0, 0 }, { 30, 34, 0, 0 }, { 10, 41, 7, 0 }, { 16, 37, 7, 0 }, { 51, 1, 0, 0 } };
            }
            else if (inputsaah == 15)
            {
                saah = new int[,] { { 58, 36, 0, 0 }, { 58, 36, 0, 0 }, { 7, 14, 8, 0 }, { 56, 9, 8, 0 }, { 59, 1, 0, 0 } };
            }
            else if (inputsaah == 16)
            {
                saah = new int[,] { { 26, 39, 0, 0 }, { 26, 39, 0, 0 }, { 3, 47, 8, 0 }, { 36, 42, 8, 0 }, { 7, 2, 0, 0 } };
            }
            else if (inputsaah == 17)
            {
                saah = new int[,] { { 54, 41, 0, 0 }, { 54, 41, 0, 0 }, { 0, 20, 9, 0, }, { 16, 15, 9, 0 }, { 15, 2, 0, 0 } };
            }
            else if (inputsaah == 18)
            {
                saah = new int[,] { { 21, 44, 0, 0 }, { 21, 44, 0, 0 }, { 56, 52, 9, 0 }, { 55, 47, 9, 0 }, { 23, 2, 0, 0 } };
            }
            else if (inputsaah == 19)
            {
                saah = new int[,] { { 49, 46, 0, 0 }, { 49, 46, 0, 0 }, { 53, 25, 10, 0 }, { 35, 20, 10, 0 }, { 31, 2, 0, 0 } };
            }
            else if (inputsaah == 20)
            {
                saah = new int[,] { { 17, 49, 0, 0 }, { 17, 49, 0, 0 }, { 49, 58, 10, 0 }, { 15, 53, 10, 0 }, { 39, 2, 0, 0 } };
            }
            else if (inputsaah == 21)
            {
                saah = new int[,] { { 45, 51, 0, 0 }, { 45, 51, 0, 0 }, { 46, 31, 11, 0 }, { 55, 25, 11, 0 }, { 47, 2, 0, 0 } };
            }
            else if (inputsaah == 22)
            {
                saah = new int[,] { { 13, 54, 0, 0 }, { 13, 54, 0, 0 }, { 42, 4, 12, 0 }, { 34, 58, 11, 0 }, { 55, 2, 0, 0 } };
            }
            else if (inputsaah == 23)
            {
                saah = new int[,] { { 40, 56, 0, 0 }, { 40, 56, 0, 0 }, { 39, 37, 12, 0 }, { 15, 31, 12, 0 }, { 2, 3, 0, 0 } };
            }
            else if (inputsaah == 24)
            {
                saah = new int[,] { { 8, 59, 0, 0 }, { 8, 59, 0, 0 }, { 35, 10, 13, 0 }, { 54, 3, 13, 0 }, { 11, 3, 0, 0 } };
            }
            else
            {
                saah = null;
            }
            return saah;
        }
        public static int[,] FindingDaqiqoh(int inputdaqiqoh)
        {
            int[,] daqiqoh;
            if (inputdaqiqoh == 1)
            {
                daqiqoh = new int[,] { { 2, 0, 0, 0 }, { 2, 0, 0, 0 }, { 33, 0, 0, 0 }, { 32, 0, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 2)
            {
                daqiqoh = new int[,] { { 5, 0, 0, 0 }, { 5, 0, 0, 0 }, { 6, 1, 0, 0 }, { 5, 1, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 3)
            {
                daqiqoh = new int[,] { { 7, 0, 0, 0 }, { 7, 0, 0, 0 }, { 39, 1, 0, 0 }, { 38, 1, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 4)
            {
                daqiqoh = new int[,] { { 10, 0, 0, 0 }, { 10, 0, 0, 0 }, { 12, 2, 0, 0 }, { 11, 2, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 5)
            {
                daqiqoh = new int[,] { { 12, 0, 0, 0 }, { 12, 0, 0, 0 }, { 45, 2, 0, 0 }, { 44, 2, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 6)
            {
                daqiqoh = new int[,] { { 15, 0, 0, 0 }, { 15, 0, 0, 0 }, { 18, 3, 0, 0 }, { 16, 3, 0, 0, }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 7)
            {
                daqiqoh = new int[,] { { 17, 0, 0, 0 }, { 17, 0, 0, 0 }, { 51, 3, 0, 0 }, { 49, 3, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 8)
            {
                daqiqoh = new int[,] { { 20, 0, 0, 0 }, { 20, 0, 0, 0 }, { 24, 4, 0, 0 }, { 22, 4, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 9)
            {
                daqiqoh = new int[,] { { 22, 0, 0, 0 }, { 22, 0, 0, 0 }, { 56, 4, 0, 0 }, { 53, 4, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 10)
            {
                daqiqoh = new int[,] { { 25, 0, 0, 0 }, { 25, 0, 0, 0 }, { 29, 5, 0, 0 }, { 26, 5, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 11)
            {
                daqiqoh = new int[,] { { 27, 0, 0, 0 }, { 27, 0, 0, 0 }, { 2, 6, 0, 0 }, { 59, 5, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 12)
            {
                daqiqoh = new int[,] { { 30, 0, 0, 0 }, { 30, 0, 0, 0 }, { 35, 6, 0, 0 }, { 32, 6, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 13)
            {
                daqiqoh = new int[,] { { 32, 0, 0, 0 }, { 32, 0, 0, 0 }, { 8, 7, 0, 0 }, { 4, 7, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 14)
            {
                daqiqoh = new int[,] { { 35, 0, 0, 0 }, { 35, 0, 0, 0 }, { 41, 7, 0, 0 }, { 37, 7, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 15)
            {
                daqiqoh = new int[,] { { 37, 0, 0, 0 }, { 37, 0, 0, 0 }, { 14, 8, 0, 0 }, { 10, 8, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 16)
            {
                daqiqoh = new int[,] { { 39, 0, 0, 0 }, { 39, 0, 0, 0 }, { 47, 8, 0, 0 }, { 43, 8, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 17)
            {
                daqiqoh = new int[,] { { 42, 0, 0, 0 }, { 42, 0, 0, 0 }, { 20, 9, 0, 0 }, { 15, 9, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 18)
            {
                daqiqoh = new int[,] { { 44, 0, 0, 0 }, { 44, 0, 0, 0 }, { 53, 9, 0, 0 }, { 48, 9, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 19)
            {
                daqiqoh = new int[,] { { 47, 0, 0, 0 }, { 47, 0, 0, 0 }, { 26, 10, 0, 0 }, { 21, 10, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 20)
            {
                daqiqoh = new int[,] { { 49, 0, 0, 0 }, { 49, 0, 0, 0 }, { 59, 10, 0, 0 }, { 53, 10, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 21)
            {
                daqiqoh = new int[,] { { 52, 0, 0, 0 }, { 52, 0, 0, 0 }, { 32, 11, 0, 0 }, { 26, 11, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 22)
            {
                daqiqoh = new int[,] { { 54, 0, 0, 0 }, { 54, 0, 0, 0 }, { 5, 12, 0, 0 }, { 59, 11, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 23)
            {
                daqiqoh = new int[,] { { 57, 0, 0, 0 }, { 57, 0, 0, 0 }, { 38, 12, 0, 0 }, { 32, 12, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 24)
            {
                daqiqoh = new int[,] { { 59, 0, 0, 0 }, { 59, 0, 0, 0 }, { 11, 13, 0, 0 }, { 4, 13, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 25)
            {
                daqiqoh = new int[,] { { 2, 1, 0, 0 }, { 2, 1, 0, 0 }, { 44, 13, 0, 0 }, { 37, 13, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 26)
            {
                daqiqoh = new int[,] { { 4, 1, 0, 0 }, { 4, 1, 0, 0 }, { 16, 14, 0, 0 }, { 9, 14, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 27)
            {
                daqiqoh = new int[,] { { 7, 1, 0, 0 }, { 7, 1, 0, 0 }, { 49, 14, 0, 0 }, { 41, 14, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 28)
            {
                daqiqoh = new int[,] { { 9, 1, 0, 0 }, { 9, 1, 0, 0 }, { 22, 15, 0, 0 }, { 14, 15, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 29)
            {
                daqiqoh = new int[,] { { 11, 1, 0, 0 }, { 11, 1, 0, 0 }, { 55, 15, 0, 0 }, { 47, 15, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 30)
            {
                daqiqoh = new int[,] { { 14, 1, 0, 0 }, { 14, 1, 0, 0 }, { 28, 16, 0, 0 }, { 20, 16, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 31)
            {
                daqiqoh = new int[,] { { 16, 1, 0, 0 }, { 16, 1, 0, 0 }, { 1, 17, 0, 0 }, { 52, 16, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 32)
            {
                daqiqoh = new int[,] { { 19, 1, 0, 0 }, { 19, 1, 0, 0 }, { 34, 17, 0, 0 }, { 25, 17, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 33)
            {
                daqiqoh = new int[,] { { 21, 1, 0, 0 }, { 21, 0, 0, 0 }, { 7, 18, 0, 0 }, { 58, 17, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 34)
            {
                daqiqoh = new int[,] { { 24, 1, 0, 0 }, { 24, 1, 0, 0 }, { 40, 18, 0, 0 }, { 31, 18, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 35)
            {
                daqiqoh = new int[,] { { 26, 1, 0, 0 }, { 26, 1, 0, 0 }, { 13, 19, 0, 0 }, { 3, 19, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 36)
            {
                daqiqoh = new int[,] { { 29, 1, 0, 0 }, { 29, 1, 0, 0 }, { 46, 19, 0, 0 }, { 36, 19, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 37)
            {
                daqiqoh = new int[,] { { 31, 1, 0, 0 }, { 31, 1, 0, 0 }, { 19, 20, 0, 0 }, { 9, 20, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 38)
            {
                daqiqoh = new int[,] { { 34, 1, 0, 0 }, { 34, 1, 0, 0 }, { 52, 20, 0, 0 }, { 41, 20, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 39)
            {
                daqiqoh = new int[,] { { 36, 1, 0, 0 }, { 36, 1, 0, 0 }, { 25, 21, 0, 0 }, { 14, 21, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 40)
            {
                daqiqoh = new int[,] { { 39, 1, 0, 0 }, { 39, 1, 0, 0 }, { 58, 21, 0, 0 }, { 47, 21, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 41)
            {
                daqiqoh = new int[,] { { 41, 1, 0, 0 }, { 41, 1, 0, 0 }, { 31, 22, 0, 0 }, { 20, 22, 0, 0 }, { 5, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 42)
            {
                daqiqoh = new int[,] { { 43, 1, 0, 0 }, { 43, 1, 0, 0 }, { 4, 23, 0, 0 }, { 52, 22, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 43)
            {
                daqiqoh = new int[,] { { 46, 1, 0, 0 }, { 46, 1, 0, 0 }, { 36, 23, 0, 0 }, { 24, 23, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 44)
            {
                daqiqoh = new int[,] { { 48, 1, 0, 0 }, { 48, 1, 0, 0 }, { 9, 24, 0, 0 }, { 57, 23, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 45)
            {
                daqiqoh = new int[,] { { 51, 1, 0, 0 }, { 51, 1, 0, 0 }, { 42, 24, 0, 0 }, { 29, 24, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 46)
            {
                daqiqoh = new int[,] { { 53, 1, 0, 0 }, { 53, 1, 0, 0 }, { 15, 52, 0, 0 }, { 2, 25, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 47)
            {
                daqiqoh = new int[,] { { 56, 1, 0, 0 }, { 56, 1, 0, 0 }, { 48, 25, 0, 0 }, { 35, 25, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 48)
            {
                daqiqoh = new int[,] { { 58, 1, 0, 0 }, { 58, 1, 0, 0 }, { 21, 26, 0, 0 }, { 8, 26, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 49)
            {
                daqiqoh = new int[,] { { 1, 2, 0, 0 }, { 1, 2, 0, 0 }, { 54, 26, 0, 0 }, { 40, 26, 0, 0 }, { 6, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 50)
            {
                daqiqoh = new int[,] { { 3, 2, 0, 0 }, { 3, 2, 0, 0 }, { 27, 27, 0, 0 }, { 13, 27, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 51)
            {
                daqiqoh = new int[,] { { 6, 2, 0, 0 }, { 6, 2, 0, 0 }, { 0, 28, 0, 0 }, { 46, 27, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 52)
            {
                daqiqoh = new int[,] { { 8, 2, 0, 0 }, { 8, 2, 0, 0 }, { 33, 28, 0, 0 }, { 19, 28, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 53)
            {
                daqiqoh = new int[,] { { 11, 2, 0, 0 }, { 11, 2, 0, 0 }, { 6, 29, 0, 0 }, { 51, 28, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 54)
            {
                daqiqoh = new int[,] { { 13, 2, 0, 0 }, { 13, 2, 0, 0 }, { 39, 29, 0, 0 }, { 24, 29, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 55)
            {
                daqiqoh = new int[,] { { 16, 2, 0, 0 }, { 16, 2, 0, 0 }, { 12, 30, 0, 0 }, { 57, 29, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 56)
            {
                daqiqoh = new int[,] { { 18, 2, 0, 0 }, { 18, 2, 0, 0 }, { 45, 30, 0, 0 }, { 29, 30, 0, 0 }, { 7, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 57)
            {
                daqiqoh = new int[,] { { 20, 2, 0, 0 }, { 20, 2, 0, 0 }, { 18, 31, 0, 0 }, { 2, 31, 0, 0 }, { 8, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 58)
            {
                daqiqoh = new int[,] { { 23, 2, 0, 0 }, { 23, 2, 0, 0 }, { 51, 31, 0, 0 }, { 35, 31, 0, 0 }, { 8, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 59)
            {
                daqiqoh = new int[,] { { 25, 2, 0, 0 }, { 25, 2, 0, 0 }, { 24, 32, 0, 0 }, { 8, 32, 0, 0 }, { 8, 0, 0, 0 } };
            }
            else if (inputdaqiqoh == 60)
            {
                daqiqoh = new int[,] { { 28, 2, 0, 0 }, { 28, 2, 0, 0 }, { 56, 32, 0, 0 }, { 39, 32, 0, 0 }, { 8, 0, 0, 0 } };
            }
            else
            {
                daqiqoh = null;
            }
            return daqiqoh;
        }
        public static int[] DaqoiqBuruj(int alwastuBadalGhurubWastusamsiBuruj)
        {
            int[] result = new int[30];
            int[] hamlun = new int[] { 7, 7, 7, 7, 6, 6, 6, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int[] saubun = new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            int[] jauza = new int[] { 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
            int[] syartoni = new int[] { 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
            int[] asad = new int[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 3 };
            int[] enam = new int[] { 3, 2, 2, 2, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 7, 7, 7 };
            int[] mizan = new int[] { 7, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15 };
            int[] aqrob = new int[] { 15, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 15, 15, 15, 15, 15, 14, 14, 14, 14 };
            int[] qus = new int[] { 14, 13, 13, 13, 13, 12, 12, 11, 11, 11, 10, 10, 10, 9, 9, 8, 8, 7, 7, 7, 6, 6, 5, 5, 5, 4, 4, 3, 3, 2, 2 };
            int[] sepuluh = new int[] { 2, 1, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 6, 7, 78, 8, 8, 9, 9, 9, 10, 10, 11, 11, 11 };
            int[] sebelas = new int[] { 11, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14 };
            int[] duabelas = new int[] { 14, 14, 14, 14, 14, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 11, 11, 11, 11, 10, 10, 10, 10, 9, 9, 9, 8, 8, 8, 7 };
            if (alwastuBadalGhurubWastusamsiBuruj == 0)
            {
                result = hamlun;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 1)
            {
                result = saubun;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 2)
            {
                result = jauza;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 3)
            {
                result = syartoni;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 4)
            {
                result = asad;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 5)
            {
                result = enam;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 6)
            {
                result = mizan;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 7)
            {
                result = aqrob;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 8)
            {
                result = qus;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 9)
            {
                result = sepuluh;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 10)
            {
                result = sebelas;
            }
            else if (alwastuBadalGhurubWastusamsiBuruj == 11)
            {
                result = duabelas;
            }
            return result;
        }
        public static int DaqoiqDarojah(int alwastuBadalGhurubWastusamsiDarojah, int alwastuBadalGhurubWastusamsiBuruj)
        {
            int[] array = Harokat.DaqoiqBuruj(alwastuBadalGhurubWastusamsiBuruj);
            int result;
            if (alwastuBadalGhurubWastusamsiDarojah == 0)
            {
                int num = array[0];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 1)
            {
                int num = array[1];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 2)
            {
                int num = array[2];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 3)
            {
                int num = array[3];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 4)
            {
                int num = array[4];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 5)
            {
                int num = array[5];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 6)
            {
                int num = array[6];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 7)
            {
                int num = array[7];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 8)
            {
                int num = array[8];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 9)
            {
                int num = array[9];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 10)
            {
                int num = array[10];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 11)
            {
                int num = array[11];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 12)
            {
                int num = array[12];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 13)
            {
                int num = array[13];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 14)
            {
                int num = array[14];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 15)
            {
                int num = array[15];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 16)
            {
                int num = array[16];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 17)
            {
                int num = array[17];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 18)
            {
                int num = array[18];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 19)
            {
                int num = array[19];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 20)
            {
                int num = array[20];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 21)
            {
                int num = array[21];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 22)
            {
                int num = array[22];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 23)
            {
                int num = array[23];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 24)
            {
                int num = array[24];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 25)
            {
                int num = array[25];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 26)
            {
                int num = array[26];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 27)
            {
                int num = array[27];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 28)
            {
                int num = array[28];
                result = num;
            }
            else if (alwastuBadalGhurubWastusamsiDarojah == 29)
            {
                int num = array[29];
                result = num;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public static int PangkatTafawut(int AlwastuBadalGhurubWastusamsiBuruj)
        {
            int Buruj;
            if (AlwastuBadalGhurubWastusamsiBuruj == 0 || AlwastuBadalGhurubWastusamsiBuruj == 3 || AlwastuBadalGhurubWastusamsiBuruj == 4 || AlwastuBadalGhurubWastusamsiBuruj == 5 || AlwastuBadalGhurubWastusamsiBuruj == 10 || AlwastuBadalGhurubWastusamsiBuruj == 11)
            {
                // Tambah kan
                Buruj = 1;
            }
            else
            {
                // Kurangi
                Buruj = 2;
            }
            return Buruj;
        }
        public static int[,] HarokatTafawut(int AlwastuBadalGhurubWastusamsiDarojah, int AlwastuBadalGhurubWastusamsiBuruj)
        {
            int tafawut = Harokat.DaqoiqDarojah(AlwastuBadalGhurubWastusamsiDarojah, AlwastuBadalGhurubWastusamsiBuruj);
            int[,] HarokatTafawut;
            if (tafawut == 1)
            {
                HarokatTafawut = new int[,] { { 2, 0, 0, 0 }, { 2, 0, 0, 0 }, { 33, 0, 0, 0 }, { 32, 0, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (tafawut == 2)
            {
                HarokatTafawut = new int[,] { { 5, 0, 0, 0 }, { 5, 0, 0, 0 }, { 6, 1, 0, 0 }, { 5, 1, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (tafawut == 3)
            {
                HarokatTafawut = new int[,] { { 7, 0, 0, 0 }, { 7, 0, 0, 0 }, { 39, 1, 0, 0 }, { 38, 1, 0, 0 }, { 0, 0, 0, 0 } };
            }
            else if (tafawut == 4)
            {
                HarokatTafawut = new int[,] { { 10, 0, 0, 0 }, { 10, 0, 0, 0 }, { 12, 2, 0, 0 }, { 11, 2, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 5)
            {
                HarokatTafawut = new int[,] { { 12, 0, 0, 0 }, { 12, 0, 0, 0 }, { 45, 2, 0, 0 }, { 44, 2, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 6)
            {
                HarokatTafawut = new int[,] { { 15, 0, 0, 0 }, { 15, 0, 0, 0 }, { 18, 3, 0, 0 }, { 16, 3, 0, 0, }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 7)
            {
                HarokatTafawut = new int[,] { { 17, 0, 0, 0 }, { 17, 0, 0, 0 }, { 51, 3, 0, 0 }, { 49, 3, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 8)
            {
                HarokatTafawut = new int[,] { { 20, 0, 0, 0 }, { 20, 0, 0, 0 }, { 24, 4, 0, 0 }, { 22, 4, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 9)
            {
                HarokatTafawut = new int[,] { { 22, 0, 0, 0 }, { 22, 0, 0, 0 }, { 56, 4, 0, 0 }, { 53, 4, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 10)
            {
                HarokatTafawut = new int[,] { { 25, 0, 0, 0 }, { 25, 0, 0, 0 }, { 29, 5, 0, 0 }, { 26, 5, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 11)
            {
                HarokatTafawut = new int[,] { { 27, 0, 0, 0 }, { 27, 0, 0, 0 }, { 2, 6, 0, 0 }, { 59, 5, 0, 0 }, { 1, 0, 0, 0 } };
            }
            else if (tafawut == 12)
            {
                HarokatTafawut = new int[,] { { 30, 0, 0, 0 }, { 30, 0, 0, 0 }, { 35, 6, 0, 0 }, { 32, 6, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 13)
            {
                HarokatTafawut = new int[,] { { 32, 0, 0, 0 }, { 32, 0, 0, 0 }, { 8, 7, 0, 0 }, { 4, 7, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 14)
            {
                HarokatTafawut = new int[,] { { 35, 0, 0, 0 }, { 35, 0, 0, 0 }, { 41, 7, 0, 0 }, { 37, 7, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 15)
            {
                HarokatTafawut = new int[,] { { 37, 0, 0, 0 }, { 37, 0, 0, 0 }, { 14, 8, 0, 0 }, { 10, 8, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 16)
            {
                HarokatTafawut = new int[,] { { 39, 0, 0, 0 }, { 39, 0, 0, 0 }, { 47, 8, 0, 0 }, { 43, 8, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 17)
            {
                HarokatTafawut = new int[,] { { 42, 0, 0, 0 }, { 42, 0, 0, 0 }, { 20, 9, 0, 0 }, { 15, 9, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 18)
            {
                HarokatTafawut = new int[,] { { 44, 0, 0, 0 }, { 44, 0, 0, 0 }, { 53, 9, 0, 0 }, { 48, 9, 0, 0 }, { 2, 0, 0, 0 } };
            }
            else if (tafawut == 19)
            {
                HarokatTafawut = new int[,] { { 47, 0, 0, 0 }, { 47, 0, 0, 0 }, { 26, 10, 0, 0 }, { 21, 10, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 20)
            {
                HarokatTafawut = new int[,] { { 49, 0, 0, 0 }, { 49, 0, 0, 0 }, { 59, 10, 0, 0 }, { 53, 10, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 21)
            {
                HarokatTafawut = new int[,] { { 52, 0, 0, 0 }, { 52, 0, 0, 0 }, { 32, 11, 0, 0 }, { 26, 11, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 22)
            {
                HarokatTafawut = new int[,] { { 54, 0, 0, 0 }, { 54, 0, 0, 0 }, { 5, 12, 0, 0 }, { 59, 11, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 23)
            {
                HarokatTafawut = new int[,] { { 57, 0, 0, 0 }, { 57, 0, 0, 0 }, { 38, 12, 0, 0 }, { 32, 12, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 24)
            {
                HarokatTafawut = new int[,] { { 59, 0, 0, 0 }, { 59, 0, 0, 0 }, { 11, 13, 0, 0 }, { 4, 13, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 25)
            {
                HarokatTafawut = new int[,] { { 2, 1, 0, 0 }, { 2, 1, 0, 0 }, { 44, 13, 0, 0 }, { 37, 13, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 26)
            {
                HarokatTafawut = new int[,] { { 4, 1, 0, 0 }, { 4, 1, 0, 0 }, { 16, 14, 0, 0 }, { 9, 14, 0, 0 }, { 3, 0, 0, 0 } };
            }
            else if (tafawut == 27)
            {
                HarokatTafawut = new int[,] { { 7, 1, 0, 0 }, { 7, 1, 0, 0 }, { 49, 14, 0, 0 }, { 41, 14, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (tafawut == 28)
            {
                HarokatTafawut = new int[,] { { 9, 1, 0, 0 }, { 9, 1, 0, 0 }, { 22, 15, 0, 0 }, { 14, 15, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (tafawut == 29)
            {
                HarokatTafawut = new int[,] { { 11, 1, 0, 0 }, { 11, 1, 0, 0 }, { 55, 15, 0, 0 }, { 47, 15, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else if (tafawut == 30)
            {
                HarokatTafawut = new int[,] { { 14, 1, 0, 0 }, { 14, 1, 0, 0 }, { 28, 16, 0, 0 }, { 20, 16, 0, 0 }, { 4, 0, 0, 0 } };
            }
            else
            {
                HarokatTafawut = null;
            }
            Console.Write("\nTafawut : ");
            foreach (var i in HarokatTafawut)
            {
                Console.Write(i + " , ");
            }
            return HarokatTafawut;
        }
        public static int[,] harokatTakdilSyam(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 59, 1, 0 }, { 57, 3, 0 }, { 55, 5, 0 }, { 54, 7, 0 }, { 52, 9, 0 }, { 50, 11, 0 }, { 48, 13, 0 }, { 45, 15, 0 }, { 47, 17, 0 }, { 39, 19, 0 }, { 36, 21, 0 }, { 32, 23, 0 }, { 28, 25, 0 }, { 23, 27, 0 }, { 17, 29, 0 }, { 13, 31, 0 }, { 7, 33, 0 }, { 0, 35, 0 }, { 53, 36, 0 }, { 45, 38, 0 }, { 36, 40, 0 }, { 27, 42, 0 }, { 17, 44, 0 }, { 6, 46, 0 }, { 55, 47, 0 }, { 42, 49, 0 }, { 29, 51, 0 }, { 15, 53, 0 }, { 0, 55, 0 }, { 44, 56, 0 } };
            int[,] satu = new int[,] { { 44, 56, 0 }, { 27, 58, 0 }, { 9, 0, 1 }, { 50, 1, 1 }, { 29, 3, 1 }, { 8, 5, 1 }, { 46, 6, 1 }, { 22, 8, 1 }, { 57, 9, 1 }, { 32, 11, 1 }, { 4, 13, 1 }, { 36, 14, 1 }, { 6, 16, 1 }, { 35, 17, 1 }, { 3, 19, 1 }, { 29, 20, 1 }, { 54, 21, 1 }, { 17, 23, 1 }, { 39, 24, 1 }, { 0, 26, 1 }, { 8, 27, 1 }, { 36, 28, 1 }, { 52, 29, 1 }, { 6, 31, 1 }, { 19, 32, 1 }, { 30, 33, 1 }, { 39, 34, 1 }, { 47, 35, 1 }, { 13, 36, 1 }, { 57, 37, 1 }, { 0, 39, 1 } };
            int[,] dua = new int[,] { { 0, 39, 1 }, { 0, 40, 1 }, { 59, 40, 1 }, { 57, 41, 1 }, { 52, 42, 1 }, { 46, 43, 1 }, { 37, 44, 1 }, { 27, 45, 1 }, { 15, 46, 1 }, { 2, 47, 1 }, { 46, 47, 1 }, { 28, 48, 1 }, { 8, 49, 1 }, { 47, 49, 1 }, { 24, 50, 1 }, { 58, 50, 1 }, { 30, 51, 1 }, { 1, 52, 1 }, { 29, 52, 1 }, { 56, 52, 1 }, { 20, 53, 1 }, { 43, 53, 1 }, { 3, 54, 1 }, { 21, 54, 1 }, { 37, 53, 1 }, { 51, 54, 1 }, { 3, 55, 1 }, { 13, 55, 1 }, { 21, 55, 1 }, { 27, 55, 1 }, { 30, 55, 1 } };
            int[,] tiga = new int[,] { { 30, 55, 1 }, { 32, 55, 1 }, { 31, 55, 1 }, { 28, 55, 1 }, { 23, 55, 1 }, { 17, 55, 1 }, { 8, 55, 1 }, { 56, 54, 1 }, { 43, 54, 1 }, { 27, 54, 1 }, { 10, 54, 1 }, { 50, 53, 1 }, { 28, 53, 1 }, { 5, 53, 1 }, { 39, 52, 1 }, { 11, 52, 1 }, { 41, 51, 1 }, { 8, 51, 1 }, { 34, 50, 1 }, { 58, 49, 1 }, { 19, 49, 1 }, { 38, 48, 1 }, { 56, 47, 1 }, { 12, 47, 1 }, { 26, 46, 1 }, { 37, 45, 1 }, { 47, 44, 1 }, { 54, 43, 1 }, { 0, 43, 1 }, { 4, 42, 1 }, { 6, 41, 1 } };
            int[,] empat = new int[,] { { 6, 41, 1 }, { 6, 40, 1 }, { 4, 39, 1 }, { 0, 38, 1 }, { 54, 36, 1 }, { 46, 35, 1 }, { 37, 34, 1 }, { 26, 33, 1 }, { 13, 32, 1 }, { 58, 30, 1 }, { 42, 29, 1 }, { 24, 28, 1 }, { 4, 27, 1 }, { 43, 25, 1 }, { 19, 24, 1 }, { 55, 22, 1 }, { 28, 21, 1 }, { 1, 20, 1 }, { 31, 18, 1 }, { 0, 17, 1 }, { 28, 15, 1 }, { 54, 13, 1 }, { 19, 12, 1 }, { 42, 10, 1 }, { 4, 9, 1 }, { 25, 7, 1 }, { 44, 5, 1 }, { 3, 4, 1 }, { 19, 2, 1 }, { 35, 0, 1 }, { 50, 58, 0 } };
            int[,] lima = new int[,] { { 50, 58, 0 }, { 3, 57, 0 }, { 15, 55, 0 }, { 27, 53, 0 }, { 37, 51, 0 }, { 46, 49, 0 }, { 54, 47, 0 }, { 2, 46, 0 }, { 8, 44, 0 }, { 14, 42, 0 }, { 18, 40, 0 }, { 22, 38, 0 }, { 25, 36, 0 }, { 28, 34, 0 }, { 30, 32, 0 }, { 31, 30, 0 }, { 32, 28, 0 }, { 32, 26, 0 }, { 31, 24, 0 }, { 30, 22, 0 }, { 29, 20, 0 }, { 27, 18, 0 }, { 25, 16, 0 }, { 23, 14, 0 }, { 20, 12, 0 }, { 18, 10, 0 }, { 14, 8, 0 }, { 11, 6, 0 }, { 7, 4, 0 }, { 4, 2, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 4, 2, 0 }, { 7, 4, 0 }, { 11, 6, 0 }, { 14, 8, 0 }, { 18, 10, 0 }, { 20, 12, 0 }, { 23, 14, 0 }, { 25, 16, 0 }, { 27, 18, 0 }, { 29, 20, 0 }, { 30, 22, 0 }, { 31, 24, 0 }, { 32, 26, 0 }, { 32, 28, 0 }, { 31, 30, 0 }, { 30, 32, 0 }, { 28, 34, 0 }, { 25, 36, 0 }, { 22, 38, 0 }, { 18, 40, 0 }, { 14, 42, 0 }, { 8, 44, 0 }, { 2, 46, 0 }, { 54, 47, 0 }, { 46, 49, 0 }, { 37, 51, 0 }, { 27, 53, 0 }, { 15, 55, 0 }, { 3, 57, 0 }, { 50, 58, 0 } };
            int[,] tujuh = new int[,] { { 50, 58, 0 }, { 35, 0, 1 }, { 19, 2, 1 }, { 3, 4, 1 }, { 44, 5, 1 }, { 25, 7, 1 }, { 4, 9, 1 }, { 42, 10, 1 }, { 19, 12, 1 }, { 54, 13, 1 }, { 28, 15, 1 }, { 0, 17, 1 }, { 31, 18, 1 }, { 1, 20, 1 }, { 28, 21, 1 }, { 55, 22, 1 }, { 19, 24, 1 }, { 43, 25, 1 }, { 4, 27, 1 }, { 24, 28, 1 }, { 42, 29, 1 }, { 58, 30, 1 }, { 13, 32, 1 }, { 26, 33, 1 }, { 37, 34, 1 }, { 46, 35, 1 }, { 54, 36, 1 }, { 0, 38, 1 }, { 4, 39, 1 }, { 6, 40, 1 }, { 6, 41, 1 } };
            int[,] delapan = new int[,] { { 6, 41, 1 }, { 4, 42, 1 }, { 0, 43, 1 }, { 54, 43, 1 }, { 47, 44, 1 }, { 37, 45, 1 }, { 26, 46, 1 }, { 12, 47, 1 }, { 56, 47, 1 }, { 38, 48, 1 }, { 19, 49, 1 }, { 58, 49, 1 }, { 34, 50, 1 }, { 8, 51, 1 }, { 41, 51, 1 }, { 11, 52, 1 }, { 39, 52, 1 }, { 5, 53, 1 }, { 28, 53, 1 }, { 50, 53, 1 }, { 10, 54, 1 }, { 27, 54, 1 }, { 43, 54, 1 }, { 56, 54, 1 }, { 8, 55, 1 }, { 17, 55, 1 }, { 23, 55, 1 }, { 28, 55, 1 }, { 31, 55, 1 }, { 32, 55, 1 }, { 30, 55, 1 } };
            int[,] sembilan = new int[,] { { 30, 55, 1 }, { 27, 55, 1 }, { 21, 55, 1 }, { 13, 55, 1 }, { 3, 55, 1 }, { 51, 54, 1 }, { 37, 53, 1 }, { 21, 54, 1 }, { 3, 54, 1 }, { 43, 53, 1 }, { 20, 53, 1 }, { 56, 52, 1 }, { 29, 52, 1 }, { 1, 52, 1 }, { 30, 51, 1 }, { 58, 50, 1 }, { 24, 50, 1 }, { 47, 49, 1 }, { 8, 49, 1 }, { 28, 48, 1 }, { 46, 47, 1 }, { 2, 47, 1 }, { 15, 46, 1 }, { 27, 45, 1 }, { 37, 44, 1 }, { 46, 43, 1 }, { 52, 42, 1 }, { 57, 41, 1 }, { 59, 40, 1 }, { 0, 40, 1 }, { 0, 39, 1 } };
            int[,] sepuluh = new int[,] { { 0, 39, 1 }, { 57, 37, 1 }, { 13, 36, 1 }, { 47, 35, 1 }, { 39, 34, 1 }, { 30, 33, 1 }, { 19, 32, 1 }, { 6, 31, 1 }, { 52, 29, 1 }, { 36, 28, 1 }, { 8, 27, 1 }, { 0, 26, 1 }, { 39, 24, 1 }, { 17, 23, 1 }, { 54, 21, 1 }, { 29, 20, 1 }, { 3, 19, 1 }, { 35, 17, 1 }, { 6, 16, 1 }, { 36, 14, 1 }, { 4, 13, 1 }, { 32, 11, 1 }, { 57, 9, 1 }, { 22, 8, 1 }, { 46, 6, 1 }, { 8, 5, 1 }, { 29, 3, 1 }, { 50, 1, 1 }, { 9, 0, 1 }, { 27, 58, 0 }, { 44, 56, 0 } };
            int[,] sebelas = new int[,] { { 44, 56, 0 }, { 0, 55, 0 }, { 15, 53, 0 }, { 29, 51, 0 }, { 42, 49, 0 }, { 55, 47, 0 }, { 6, 46, 0 }, { 17, 44, 0 }, { 27, 42, 0 }, { 36, 40, 0 }, { 45, 38, 0 }, { 53, 36, 0 }, { 0, 35, 0 }, { 7, 33, 0 }, { 13, 31, 0 }, { 17, 29, 0 }, { 23, 27, 0 }, { 28, 25, 0 }, { 32, 23, 0 }, { 36, 21, 0 }, { 39, 19, 0 }, { 47, 17, 0 }, { 45, 15, 0 }, { 48, 13, 0 }, { 50, 11, 0 }, { 52, 9, 0 }, { 54, 7, 0 }, { 55, 5, 0 }, { 57, 3, 0 }, { 59, 1, 0 }, { 0, 0, 0 } };

            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilsyamdarojah(int alhaqiqiKhosotuha_darojah, int alhaqiqiKhosotuha_buruj)
        {
            int[,] array = Harokat.harokatTakdilSyam(alhaqiqiKhosotuha_buruj);
            int[] result;
            if (alhaqiqiKhosotuha_darojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 2)
            {
                int[] num = new int[] { array[0, 0], array[1, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiKhosotuha_darojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = new int[] { 0 };
            }
            return result;
        }
        public static int pangkatTakdilSyam(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 0 && alhaqiqiBuruj <= 5)
            {
                buruj = 1;
            }
            else
            {
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokaTakdilAwal(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 12, 0, 0 }, { 23, 0, 0 }, { 35, 0, 0 }, { 47, 0, 0 }, { 58, 0, 0 }, { 10, 1, 0 }, { 21, 1, 0 }, { 33, 1, 0 }, { 45, 1, 0 }, { 56, 1, 0 }, { 7, 2, 0 }, { 19, 2, 0 }, { 30, 2, 0 }, { 42, 2, 0 }, { 53, 2, 0 }, { 4, 3, 0 }, { 15, 3, 0 }, { 26, 3, 0 }, { 38, 3, 0 }, { 49, 3, 0 }, { 59, 3, 0 }, { 10, 4, 0 }, { 21, 4, 0 }, { 32, 4, 0 }, { 43, 4, 0 }, { 53, 4, 0 }, { 4, 5, 0 }, { 14, 5, 0 }, { 24, 5, 0 }, { 35, 5, 0 } };
            int[,] satu = new int[,] { { 35, 5, 0 }, { 45, 5, 0 }, { 54, 5, 0 }, { 4, 6, 0 }, { 14, 6, 0 }, { 24, 6, 0 }, { 33, 6, 0 }, { 43, 6, 0 }, { 52, 6, 0 }, { 1, 7, 0 }, { 10, 7, 0 }, { 19, 7, 0 }, { 28, 7, 0 }, { 37, 7, 0 }, { 46, 7, 0 }, { 54, 7, 0 }, { 2, 8, 0 }, { 10, 8, 0 }, { 18, 8, 0 }, { 26, 8, 0 }, { 34, 8, 0 }, { 41, 8, 0 }, { 49, 8, 0 }, { 56, 8, 0 }, { 3, 9, 0 }, { 10, 9, 0 }, { 16, 9, 0 }, { 23, 9, 0 }, { 30, 9, 0 }, { 36, 9, 0 }, { 46, 9, 0 } };
            int[,] dua = new int[,] { { 42, 9, 0 }, { 48, 9, 0 }, { 54, 9, 0 }, { 59, 9, 0 }, { 5, 10, 0 }, { 10, 10, 0 }, { 14, 10, 0 }, { 19, 10, 0 }, { 24, 10, 0 }, { 28, 10, 0 }, { 33, 10, 0 }, { 37, 10, 0 }, { 41, 10, 0 }, { 44, 10, 0 }, { 48, 10, 0 }, { 51, 10, 0 }, { 54, 10, 0 }, { 57, 10, 0 }, { 59, 10, 0 }, { 2, 11, 0 }, { 4, 11, 0 }, { 6, 11, 0 }, { 8, 11, 0 }, { 10, 11, 0 }, { 11, 11, 0 }, { 13, 11, 0 }, { 14, 11, 0 }, { 15, 11, 0 }, { 15, 11, 0 }, { 16, 11, 0 }, { 16, 11, 0 } };
            int[,] tiga = new int[,] { { 16, 11, 0 }, { 16, 11, 0 }, { 16, 11, 0 }, { 15, 11, 0 }, { 14, 11, 0 }, { 14, 11, 0 }, { 13, 11, 0 }, { 12, 11, 0 }, { 11, 11, 0 }, { 9, 11, 0 }, { 7, 11, 0 }, { 5, 11, 0 }, { 3, 11, 0 }, { 0, 11, 0 }, { 58, 10, 0 }, { 55, 10, 0 }, { 52, 10, 0 }, { 49, 10, 0 }, { 45, 10, 0 }, { 42, 10, 0 }, { 38, 10, 0 }, { 34, 10, 0 }, { 30, 10, 0 }, { 25, 10, 0 }, { 21, 10, 0 }, { 16, 10, 0 }, { 11, 10, 0 }, { 6, 10, 0 }, { 0, 10, 0 }, { 55, 9, 0 }, { 49, 9, 0 } };
            int[,] empat = new int[,] { { 49, 9, 0 }, { 43, 9, 0 }, { 37, 9, 0 }, { 31, 9, 0 }, { 24, 9, 0 }, { 18, 9, 0 }, { 11, 9, 0 }, { 4, 9, 0 }, { 57, 8, 0 }, { 49, 8, 0 }, { 42, 8, 0 }, { 34, 8, 0 }, { 26, 8, 0 }, { 18, 8, 0 }, { 10, 8, 0 }, { 2, 8, 0 }, { 54, 7, 0 }, { 45, 7, 0 }, { 36, 7, 0 }, { 27, 7, 0 }, { 18, 7, 0 }, { 9, 7, 0 }, { 0, 7, 0 }, { 51, 6, 0 }, { 41, 6, 0 }, { 32, 6, 0 }, { 22, 6, 0 }, { 12, 6, 0 }, { 2, 6, 0 }, { 52, 5, 0 }, { 42, 5, 0 } };
            int[,] lima = new int[,] { { 42, 5, 0 }, { 31, 5, 0 }, { 21, 5, 0 }, { 10, 5, 0 }, { 59, 4, 0 }, { 49, 5, 0 }, { 38, 4, 0 }, { 27, 4, 0 }, { 16, 4, 0 }, { 5, 4, 0 }, { 54, 3, 0 }, { 43, 3, 0 }, { 31, 3, 0 }, { 20, 3, 0 }, { 8, 3, 0 }, { 57, 2, 0 }, { 49, 2, 0 }, { 33, 2, 0 }, { 21, 2, 0 }, { 10, 2, 0 }, { 59, 1, 0 }, { 47, 1, 0 }, { 35, 1, 0 }, { 23, 1, 0 }, { 11, 1, 0 }, { 0, 1, 0 }, { 48, 0, 0 }, { 36, 0, 0 }, { 24, 0, 0 }, { 12, 0, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 12, 0, 0 }, { 24, 0, 0 }, { 36, 0, 0 }, { 48, 0, 0 }, { 0, 1, 0 }, { 11, 1, 0 }, { 23, 1, 0 }, { 35, 1, 0 }, { 47, 1, 0 }, { 59, 1, 0 }, { 10, 2, 0 }, { 21, 2, 0 }, { 33, 2, 0 }, { 49, 2, 0 }, { 57, 2, 0 }, { 8, 3, 0 }, { 20, 3, 0 }, { 31, 3, 0 }, { 43, 3, 0 }, { 54, 3, 0 }, { 5, 4, 0 }, { 16, 4, 0 }, { 27, 4, 0 }, { 38, 4, 0 }, { 49, 5, 0 }, { 59, 4, 0 }, { 10, 5, 0 }, { 21, 5, 0 }, { 31, 5, 0 }, { 42, 5, 0 } };
            int[,] tujuh = new int[,] { { 42, 5, 0 }, { 52, 5, 0 }, { 2, 6, 0 }, { 12, 6, 0 }, { 22, 6, 0 }, { 32, 6, 0 }, { 41, 6, 0 }, { 51, 6, 0 }, { 0, 7, 0 }, { 9, 7, 0 }, { 18, 7, 0 }, { 27, 7, 0 }, { 36, 7, 0 }, { 45, 7, 0 }, { 54, 7, 0 }, { 2, 8, 0 }, { 10, 8, 0 }, { 18, 8, 0 }, { 26, 8, 0 }, { 34, 8, 0 }, { 42, 8, 0 }, { 49, 8, 0 }, { 57, 8, 0 }, { 4, 9, 0 }, { 11, 9, 0 }, { 18, 9, 0 }, { 24, 9, 0 }, { 31, 9, 0 }, { 37, 9, 0 }, { 43, 9, 0 }, { 49, 9, 0 } };
            int[,] delapan = new int[,] { { 49, 9, 0 }, { 55, 9, 0 }, { 0, 10, 0 }, { 6, 10, 0 }, { 11, 10, 0 }, { 16, 10, 0 }, { 21, 10, 0 }, { 25, 10, 0 }, { 30, 10, 0 }, { 34, 10, 0 }, { 38, 10, 0 }, { 42, 10, 0 }, { 45, 10, 0 }, { 49, 10, 0 }, { 52, 10, 0 }, { 55, 10, 0 }, { 58, 10, 0 }, { 0, 11, 0 }, { 3, 11, 0 }, { 5, 11, 0 }, { 7, 11, 0 }, { 9, 11, 0 }, { 11, 11, 0 }, { 12, 11, 0 }, { 13, 11, 0 }, { 14, 11, 0 }, { 14, 11, 0 }, { 15, 11, 0 }, { 16, 11, 0 }, { 16, 11, 0 }, { 16, 11, 0 } };
            int[,] sembilan = new int[,] { { 16, 11, 0 }, { 16, 11, 0 }, { 15, 11, 0 }, { 15, 11, 0 }, { 14, 11, 0 }, { 13, 11, 0 }, { 11, 11, 0 }, { 10, 11, 0 }, { 8, 11, 0 }, { 6, 11, 0 }, { 4, 11, 0 }, { 2, 11, 0 }, { 59, 10, 0 }, { 57, 10, 0 }, { 54, 10, 0 }, { 51, 10, 0 }, { 48, 10, 0 }, { 44, 10, 0 }, { 41, 10, 0 }, { 37, 10, 0 }, { 33, 10, 0 }, { 28, 10, 0 }, { 24, 10, 0 }, { 19, 10, 0 }, { 14, 10, 0 }, { 10, 10, 0 }, { 5, 10, 0 }, { 59, 9, 0 }, { 54, 9, 0 }, { 48, 9, 0 }, { 42, 9, 0 } };
            int[,] sepuluh = new int[,] { { 46, 9, 0 }, { 36, 9, 0 }, { 30, 9, 0 }, { 23, 9, 0 }, { 16, 9, 0 }, { 10, 9, 0 }, { 3, 9, 0 }, { 56, 8, 0 }, { 49, 8, 0 }, { 41, 8, 0 }, { 34, 8, 0 }, { 26, 8, 0 }, { 18, 8, 0 }, { 10, 8, 0 }, { 2, 8, 0 }, { 54, 7, 0 }, { 46, 7, 0 }, { 37, 7, 0 }, { 28, 7, 0 }, { 19, 7, 0 }, { 10, 7, 0 }, { 1, 7, 0 }, { 52, 6, 0 }, { 43, 6, 0 }, { 33, 6, 0 }, { 24, 6, 0 }, { 14, 6, 0 }, { 4, 6, 0 }, { 54, 5, 0 }, { 45, 5, 0 }, { 35, 5, 0 } };
            int[,] sebelas = new int[,] { { 35, 5, 0 }, { 24, 5, 0 }, { 14, 5, 0 }, { 4, 5, 0 }, { 53, 4, 0 }, { 43, 4, 0 }, { 32, 4, 0 }, { 21, 4, 0 }, { 10, 4, 0 }, { 59, 3, 0 }, { 49, 3, 0 }, { 38, 3, 0 }, { 26, 3, 0 }, { 15, 3, 0 }, { 4, 3, 0 }, { 53, 2, 0 }, { 42, 2, 0 }, { 30, 2, 0 }, { 19, 2, 0 }, { 7, 2, 0 }, { 56, 1, 0 }, { 45, 1, 0 }, { 33, 1, 0 }, { 21, 1, 0 }, { 10, 1, 0 }, { 58, 0, 0 }, { 47, 0, 0 }, { 35, 0, 0 }, { 23, 0, 0 }, { 12, 0, 0 }, { 0, 0, 0 } };
            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilawaldarojah(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokaTakdilAwal(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkatTakdilAwal(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 6 && alhaqiqiBuruj <= 11)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokaTakdilsani(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 23, 1, 0 }, { 46, 2, 0 }, { 9, 4, 0 }, { 32, 5, 0 }, { 55, 6, 0 }, { 18, 8, 0 }, { 40, 9, 0 }, { 3, 11, 0 }, { 25, 12, 0 }, { 47, 13, 0 }, { 9, 15, 0 }, { 30, 16, 0 }, { 51, 17, 0 }, { 12, 19, 0 }, { 33, 20, 0 }, { 53, 21, 0 }, { 13, 23, 0 }, { 32, 24, 0 }, { 51, 25, 0 }, { 10, 27, 0 }, { 28, 28, 0 }, { 45, 29, 0 }, { 2, 31, 0 }, { 19, 32, 0 }, { 35, 33, 0 }, { 50, 34, 0 }, { 5, 36, 0 }, { 19, 37, 0 }, { 33, 38, 0 }, { 46, 39, 0 } };
            int[,] satu = new int[,] { { 46, 39, 0 }, { 58, 40, 0 }, { 9, 42, 0 }, { 20, 43, 0 }, { 30, 44, 0 }, { 39, 45, 0 }, { 48, 46, 0 }, { 54, 47, 0 }, { 1, 49, 0 }, { 7, 50, 0 }, { 12, 51, 0 }, { 16, 52, 0 }, { 19, 53, 0 }, { 21, 54, 0 }, { 22, 55, 0 }, { 22, 56, 0 }, { 21, 57, 0 }, { 19, 58, 0 }, { 16, 59, 0 }, { 12, 0, 1 }, { 7, 1, 1 }, { 1, 2, 1 }, { 54, 2, 1 }, { 46, 3, 1 }, { 37, 4, 1 }, { 26, 5, 1 }, { 14, 6, 1 }, { 1, 7, 1 }, { 47, 7, 1 }, { 32, 8, 1 }, { 15, 9, 1 } };
            int[,] dua = new int[,] { { 15, 9, 1 }, { 57, 9, 1 }, { 38, 10, 1 }, { 18, 11, 1 }, { 56, 11, 1 }, { 33, 12, 1 }, { 9, 13, 1 }, { 43, 13, 1 }, { 16, 14, 1 }, { 48, 14, 1 }, { 19, 15, 1 }, { 49, 15, 1 }, { 17, 16, 1 }, { 43, 16, 1 }, { 8, 17, 1 }, { 31, 17, 1 }, { 53, 17, 1 }, { 14, 18, 1 }, { 33, 18, 1 }, { 51, 18, 1 }, { 8, 19, 1 }, { 23, 19, 1 }, { 38, 19, 1 }, { 50, 19, 1 }, { 0, 20, 1 }, { 9, 20, 1 }, { 16, 20, 1 }, { 22, 20, 1 }, { 27, 20, 1 }, { 31, 20, 1 }, { 33, 20, 1 } };
            int[,] tiga = new int[,] { { 33, 20, 1 }, { 34, 20, 1 }, { 23, 20, 1 }, { 31, 20, 1 }, { 21, 20, 1 }, { 21, 20, 1 }, { 24, 20, 1 }, { 5, 20, 1 }, { 55, 19, 1 }, { 44, 19, 1 }, { 32, 19, 1 }, { 11, 19, 1 }, { 2, 19, 1 }, { 45, 18, 1 }, { 26, 18, 1 }, { 6, 18, 1 }, { 54, 17, 1 }, { 21, 17, 1 }, { 57, 16, 1 }, { 31, 16, 1 }, { 4, 16, 1 }, { 35, 15, 1 }, { 5, 15, 1 }, { 34, 14, 1 }, { 1, 14, 1 }, { 27, 13, 1 }, { 52, 12, 1 }, { 15, 12, 1 }, { 37, 11, 1 }, { 57, 10, 1 }, { 16, 10, 1 } };
            int[,] empat = new int[,] { { 16, 10, 1 }, { 34, 9, 1 }, { 51, 8, 1 }, { 6, 8, 1 }, { 20, 7, 1 }, { 32, 6, 1 }, { 43, 5, 1 }, { 53, 4, 1 }, { 2, 4, 1 }, { 10, 3, 1 }, { 17, 2, 1 }, { 23, 1, 1 }, { 27, 0, 1 }, { 30, 59, 0 }, { 32, 58, 0 }, { 33, 57, 0 }, { 33, 56, 0 }, { 32, 55, 0 }, { 30, 54, 0 }, { 26, 53, 0 }, { 21, 52, 0 }, { 15, 51, 0 }, { 8, 50, 0 }, { 1, 49, 0 }, { 53, 47, 0 }, { 44, 46, 0 }, { 34, 45, 0 }, { 23, 44, 0 }, { 12, 43, 0 }, { 0, 42, 0 }, { 47, 40, 0 } };
            int[,] lima = new int[,] { { 41, 40, 0 }, { 33, 39, 0 }, { 18, 38, 0 }, { 3, 37, 0 }, { 47, 35, 0 }, { 30, 34, 0 }, { 13, 33, 0 }, { 55, 31, 0 }, { 36, 30, 0 }, { 16, 29, 0 }, { 56, 27, 0 }, { 35, 26, 0 }, { 14, 25, 0 }, { 53, 23, 0 }, { 31, 22, 0 }, { 9, 21, 0 }, { 46, 19, 0 }, { 23, 11, 0 }, { 59, 16, 0 }, { 35, 15, 0 }, { 11, 14, 0 }, { 47, 12, 0 }, { 22, 11, 0 }, { 57, 9, 0 }, { 32, 1, 0 }, { 7, 7, 0 }, { 42, 5, 0 }, { 17, 4, 0 }, { 51, 2, 0 }, { 26, 1, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 26, 1, 0 }, { 51, 2, 0 }, { 17, 4, 0 }, { 42, 5, 0 }, { 7, 7, 0 }, { 32, 1, 0 }, { 57, 9, 0 }, { 22, 11, 0 }, { 47, 12, 0 }, { 11, 14, 0 }, { 35, 15, 0 }, { 59, 16, 0 }, { 23, 11, 0 }, { 46, 19, 0 }, { 9, 21, 0 }, { 31, 22, 0 }, { 53, 23, 0 }, { 14, 25, 0 }, { 35, 26, 0 }, { 56, 27, 0 }, { 16, 29, 0 }, { 36, 30, 0 }, { 55, 31, 0 }, { 13, 33, 0 }, { 30, 34, 0 }, { 47, 35, 0 }, { 3, 37, 0 }, { 18, 38, 0 }, { 33, 39, 0 }, { 41, 40, 0 } };
            int[,] tujuh = new int[,] { { 47, 40, 0 }, { 0, 42, 0 }, { 12, 43, 0 }, { 23, 44, 0 }, { 34, 45, 0 }, { 44, 46, 0 }, { 53, 47, 0 }, { 1, 49, 0 }, { 8, 50, 0 }, { 15, 51, 0 }, { 21, 52, 0 }, { 26, 53, 0 }, { 30, 54, 0 }, { 32, 55, 0 }, { 33, 56, 0 }, { 33, 57, 0 }, { 32, 58, 0 }, { 30, 59, 0 }, { 27, 0, 1 }, { 23, 1, 1 }, { 17, 2, 1 }, { 10, 3, 1 }, { 2, 4, 1 }, { 53, 4, 1 }, { 43, 5, 1 }, { 32, 6, 1 }, { 20, 7, 1 }, { 6, 8, 1 }, { 51, 8, 1 }, { 34, 9, 1 }, { 16, 10, 1 } };
            int[,] delapan = new int[,] { { 16, 10, 1 }, { 57, 10, 1 }, { 37, 11, 1 }, { 15, 12, 1 }, { 52, 12, 1 }, { 27, 13, 1 }, { 1, 14, 1 }, { 34, 14, 1 }, { 5, 15, 1 }, { 35, 15, 1 }, { 4, 16, 1 }, { 31, 16, 1 }, { 57, 16, 1 }, { 21, 17, 1 }, { 54, 17, 1 }, { 6, 18, 1 }, { 26, 18, 1 }, { 45, 18, 1 }, { 2, 19, 1 }, { 11, 19, 1 }, { 32, 19, 1 }, { 44, 19, 1 }, { 55, 19, 1 }, { 5, 20, 1 }, { 24, 20, 1 }, { 21, 20, 1 }, { 21, 20, 1 }, { 31, 20, 1 }, { 23, 20, 1 }, { 34, 20, 1 }, { 33, 20, 1 } };
            int[,] sembilan = new int[,] { { 33, 20, 1 }, { 31, 20, 1 }, { 27, 20, 1 }, { 22, 20, 1 }, { 16, 20, 1 }, { 9, 20, 1 }, { 0, 20, 1 }, { 50, 19, 1 }, { 38, 19, 1 }, { 23, 19, 1 }, { 8, 19, 1 }, { 51, 18, 1 }, { 33, 18, 1 }, { 14, 18, 1 }, { 53, 17, 1 }, { 31, 17, 1 }, { 8, 17, 1 }, { 43, 16, 1 }, { 17, 16, 1 }, { 49, 15, 1 }, { 19, 15, 1 }, { 48, 14, 1 }, { 16, 14, 1 }, { 43, 13, 1 }, { 9, 13, 1 }, { 33, 12, 1 }, { 56, 11, 1 }, { 18, 11, 1 }, { 38, 10, 1 }, { 57, 9, 1 }, { 15, 9, 1 } };
            int[,] sepuluh = new int[,] { { 15, 9, 1 }, { 32, 8, 1 }, { 47, 7, 1 }, { 1, 7, 1 }, { 14, 6, 1 }, { 26, 5, 1 }, { 37, 4, 1 }, { 46, 3, 1 }, { 54, 2, 1 }, { 1, 2, 1 }, { 7, 1, 1 }, { 12, 0, 1 }, { 16, 59, 0 }, { 19, 58, 0 }, { 21, 57, 0 }, { 22, 56, 0 }, { 22, 55, 0 }, { 21, 54, 0 }, { 19, 53, 0 }, { 16, 52, 0 }, { 12, 51, 0 }, { 7, 50, 0 }, { 1, 49, 0 }, { 54, 47, 0 }, { 48, 46, 0 }, { 39, 45, 0 }, { 30, 44, 0 }, { 20, 43, 0 }, { 9, 42, 0 }, { 58, 40, 0 }, { 46, 39, 0 } };
            int[,] sebelas = new int[,] { { 46, 39, 0 }, { 33, 38, 0 }, { 19, 37, 0 }, { 5, 36, 0 }, { 50, 34, 0 }, { 35, 33, 0 }, { 19, 32, 0 }, { 2, 31, 0 }, { 45, 29, 0 }, { 28, 28, 0 }, { 10, 27, 0 }, { 51, 25, 0 }, { 32, 24, 0 }, { 13, 23, 0 }, { 53, 21, 0 }, { 33, 20, 0 }, { 12, 19, 0 }, { 51, 17, 0 }, { 30, 16, 0 }, { 9, 15, 0 }, { 47, 13, 0 }, { 25, 12, 0 }, { 3, 11, 0 }, { 40, 9, 0 }, { 18, 8, 0 }, { 55, 6, 0 }, { 32, 5, 0 }, { 9, 4, 0 }, { 46, 2, 0 }, { 23, 1, 0 }, { 0, 0, 0 } };
            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilSaniDarojah(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokaTakdilsani(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkatTakdilsani(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 0 && alhaqiqiBuruj <= 5)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokatTakdilHossoh(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 24, 0, 0 }, { 39, 0, 0 }, { 13, 1, 0 }, { 37, 1, 0 }, { 1, 2, 0 }, { 25, 2, 0 }, { 48, 2, 0 }, { 12, 3, 0 }, { 36, 3, 0 }, { 59, 3, 0 }, { 22, 4, 0 }, { 47, 4, 0 }, { 11, 5, 0 }, { 34, 5, 0 }, { 57, 5, 0 }, { 20, 6, 0 }, { 43, 6, 0 }, { 6, 7, 0 }, { 29, 7, 0 }, { 52, 7, 0 }, { 14, 8, 0 }, { 37, 8, 0 }, { 59, 8, 0 }, { 21, 9, 0 }, { 43, 9, 0 }, { 5, 10, 0 }, { 27, 10, 0 }, { 47, 10, 0 }, { 10, 11, 0 }, { 31, 11, 0 } };
            int[,] satu = new int[,] { { 31, 11, 0 }, { 52, 11, 0 }, { 12, 12, 0 }, { 33, 12, 0 }, { 53, 12, 0 }, { 13, 13, 0 }, { 32, 13, 0 }, { 52, 13, 0 }, { 11, 14, 0 }, { 30, 14, 0 }, { 49, 14, 0 }, { 8, 15, 0 }, { 26, 15, 0 }, { 44, 15, 0 }, { 1, 16, 0 }, { 17, 16, 0 }, { 35, 16, 0 }, { 51, 16, 0 }, { 8, 17, 0 }, { 24, 17, 0 }, { 40, 17, 0 }, { 55, 17, 0 }, { 10, 18, 0 }, { 26, 18, 0 }, { 40, 18, 0 }, { 54, 18, 0 }, { 7, 19, 0 }, { 21, 19, 0 }, { 35, 19, 0 }, { 43, 19, 0 }, { 1, 20, 0 } };
            int[,] dua = new int[,] { { 1, 20, 0 }, { 13, 20, 0 }, { 23, 20, 0 }, { 36, 20, 0 }, { 47, 20, 0 }, { 57, 20, 0 }, { 7, 21, 0 }, { 16, 21, 0 }, { 26, 21, 0 }, { 35, 21, 0 }, { 44, 21, 0 }, { 52, 21, 0 }, { 0, 22, 0 }, { 7, 22, 0 }, { 15, 22, 0 }, { 22, 22, 0 }, { 28, 22, 0 }, { 34, 22, 0 }, { 39, 22, 0 }, { 44, 22, 0 }, { 49, 22, 0 }, { 53, 22, 0 }, { 57, 22, 0 }, { 0, 23, 0 }, { 3, 23, 0 }, { 6, 23, 0 }, { 8, 23, 0 }, { 10, 23, 0 }, { 11, 23, 0 }, { 11, 23, 0 }, { 12, 23, 0 } };
            int[,] tiga = new int[,] { { 12, 23, 0 }, { 12, 23, 0 }, { 11, 23, 0 }, { 10, 23, 0 }, { 9, 23, 0 }, { 7, 23, 0 }, { 5, 23, 0 }, { 2, 23, 0 }, { 59, 22, 0 }, { 56, 22, 0 }, { 53, 22, 0 }, { 49, 22, 0 }, { 44, 22, 0 }, { 39, 22, 0 }, { 34, 22, 0 }, { 28, 22, 0 }, { 21, 22, 0 }, { 14, 22, 0 }, { 7, 22, 0 }, { 0, 22, 0 }, { 52, 21, 0 }, { 44, 21, 0 }, { 35, 21, 0 }, { 26, 21, 0 }, { 16, 21, 0 }, { 6, 21, 0 }, { 56, 20, 0 }, { 45, 20, 0 }, { 34, 20, 0 }, { 23, 20, 0 }, { 11, 20, 0 } };
            int[,] empat = new int[,] { { 11, 20, 0 }, { 59, 19, 0 }, { 46, 19, 0 }, { 33, 19, 0 }, { 20, 19, 0 }, { 6, 19, 0 }, { 52, 18, 0 }, { 37, 18, 0 }, { 22, 18, 0 }, { 7, 18, 0 }, { 52, 17, 0 }, { 36, 17, 0 }, { 20, 17, 0 }, { 4, 17, 0 }, { 47, 16, 0 }, { 30, 16, 0 }, { 12, 16, 0 }, { 54, 15, 0 }, { 36, 15, 0 }, { 18, 15, 0 }, { 0, 15, 0 }, { 41, 14, 0 }, { 22, 14, 0 }, { 3, 14, 0 }, { 44, 13, 0 }, { 24, 13, 0 }, { 4, 13, 0 }, { 44, 12, 0 }, { 23, 12, 0 }, { 2, 12, 0 }, { 41, 11, 0 } };
            int[,] lima = new int[,] { { 41, 11, 0 }, { 20, 11, 0 }, { 59, 10, 0 }, { 37, 10, 0 }, { 15, 10, 0 }, { 53, 9, 0 }, { 31, 9, 0 }, { 9, 9, 0 }, { 46, 8, 0 }, { 23, 8, 0 }, { 0, 8, 0 }, { 37, 7, 0 }, { 13, 7, 0 }, { 50, 6, 0 }, { 27, 6, 0 }, { 3, 6, 0 }, { 40, 5, 0 }, { 16, 5, 0 }, { 52, 4, 0 }, { 28, 4, 0 }, { 4, 4, 0 }, { 40, 3, 0 }, { 16, 3, 0 }, { 51, 2, 0 }, { 27, 2, 0 }, { 2, 2, 0 }, { 38, 1, 0 }, { 14, 1, 0 }, { 49, 0, 0 }, { 25, 0, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 25, 0, 0 }, { 49, 0, 0 }, { 14, 1, 0 }, { 38, 1, 0 }, { 2, 2, 0 }, { 27, 2, 0 }, { 51, 2, 0 }, { 16, 3, 0 }, { 40, 3, 0 }, { 4, 4, 0 }, { 28, 4, 0 }, { 52, 4, 0 }, { 16, 5, 0 }, { 40, 5, 0 }, { 3, 6, 0 }, { 27, 6, 0 }, { 50, 6, 0 }, { 13, 7, 0 }, { 37, 7, 0 }, { 0, 8, 0 }, { 23, 8, 0 }, { 46, 8, 0 }, { 9, 9, 0 }, { 31, 9, 0 }, { 53, 9, 0 }, { 15, 10, 0 }, { 37, 10, 0 }, { 59, 10, 0 }, { 20, 11, 0 }, { 41, 11, 0 } };
            int[,] tujuh = new int[,] { { 41, 11, 0 }, { 2, 12, 0 }, { 23, 12, 0 }, { 44, 12, 0 }, { 4, 13, 0 }, { 24, 13, 0 }, { 44, 13, 0 }, { 3, 14, 0 }, { 22, 14, 0 }, { 41, 14, 0 }, { 0, 15, 0 }, { 18, 15, 0 }, { 36, 15, 0 }, { 54, 15, 0 }, { 12, 16, 0 }, { 30, 16, 0 }, { 47, 16, 0 }, { 4, 17, 0 }, { 20, 17, 0 }, { 36, 17, 0 }, { 52, 17, 0 }, { 7, 18, 0 }, { 22, 18, 0 }, { 37, 18, 0 }, { 52, 18, 0 }, { 6, 19, 0 }, { 20, 19, 0 }, { 33, 19, 0 }, { 46, 19, 0 }, { 59, 19, 0 }, { 11, 20, 0 } };
            int[,] delapan = new int[,] { { 11, 20, 0 }, { 23, 20, 0 }, { 34, 20, 0 }, { 45, 20, 0 }, { 56, 20, 0 }, { 6, 21, 0 }, { 16, 21, 0 }, { 26, 21, 0 }, { 35, 21, 0 }, { 44, 21, 0 }, { 52, 21, 0 }, { 0, 22, 0 }, { 7, 22, 0 }, { 14, 22, 0 }, { 21, 22, 0 }, { 28, 22, 0 }, { 34, 22, 0 }, { 39, 22, 0 }, { 44, 22, 0 }, { 49, 22, 0 }, { 53, 22, 0 }, { 56, 22, 0 }, { 59, 22, 0 }, { 2, 23, 0 }, { 5, 23, 0 }, { 7, 23, 0 }, { 9, 23, 0 }, { 10, 23, 0 }, { 11, 23, 0 }, { 12, 23, 0 }, { 12, 23, 0 } };
            int[,] sembilan = new int[,] { { 12, 23, 0 }, { 11, 23, 0 }, { 11, 23, 0 }, { 10, 23, 0 }, { 8, 23, 0 }, { 6, 23, 0 }, { 3, 23, 0 }, { 0, 23, 0 }, { 57, 22, 0 }, { 53, 22, 0 }, { 49, 22, 0 }, { 44, 22, 0 }, { 39, 22, 0 }, { 34, 22, 0 }, { 28, 22, 0 }, { 22, 22, 0 }, { 15, 22, 0 }, { 7, 22, 0 }, { 0, 22, 0 }, { 52, 21, 0 }, { 44, 21, 0 }, { 35, 21, 0 }, { 26, 21, 0 }, { 16, 21, 0 }, { 7, 21, 0 }, { 57, 20, 0 }, { 47, 20, 0 }, { 36, 20, 0 }, { 23, 20, 0 }, { 13, 20, 0 }, { 1, 20, 0 } };
            int[,] sepuluh = new int[,] { { 1, 20, 0 }, { 43, 19, 0 }, { 35, 19, 0 }, { 21, 19, 0 }, { 7, 19, 0 }, { 54, 18, 0 }, { 40, 18, 0 }, { 26, 18, 0 }, { 10, 18, 0 }, { 55, 17, 0 }, { 40, 17, 0 }, { 24, 17, 0 }, { 8, 17, 0 }, { 51, 16, 0 }, { 35, 16, 0 }, { 17, 16, 0 }, { 1, 16, 0 }, { 44, 15, 0 }, { 26, 15, 0 }, { 8, 15, 0 }, { 49, 14, 0 }, { 30, 14, 0 }, { 11, 14, 0 }, { 52, 13, 0 }, { 32, 13, 0 }, { 13, 13, 0 }, { 53, 12, 0 }, { 33, 12, 0 }, { 12, 12, 0 }, { 52, 11, 0 }, { 31, 11, 0 } };
            int[,] sebelas = new int[,] { { 31, 11, 0 }, { 10, 11, 0 }, { 47, 10, 0 }, { 27, 10, 0 }, { 5, 10, 0 }, { 43, 9, 0 }, { 21, 9, 0 }, { 59, 8, 0 }, { 37, 8, 0 }, { 14, 8, 0 }, { 52, 7, 0 }, { 29, 7, 0 }, { 6, 7, 0 }, { 43, 6, 0 }, { 20, 6, 0 }, { 57, 5, 0 }, { 34, 5, 0 }, { 11, 5, 0 }, { 47, 4, 0 }, { 22, 4, 0 }, { 59, 3, 0 }, { 36, 3, 0 }, { 12, 3, 0 }, { 48, 2, 0 }, { 25, 2, 0 }, { 1, 2, 0 }, { 37, 1, 0 }, { 13, 1, 0 }, { 39, 0, 0 }, { 24, 0, 0 }, { 0, 0, 0 } };

            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilHossoh(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokatTakdilHossoh(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {

                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkattakdilHossoh(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 6 && alhaqiqiBuruj <= 11)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokatTakdilsalis(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 11, 6, 0 }, { 22, 12, 0 }, { 32, 18, 0 }, { 42, 24, 0 }, { 52, 30, 0 }, { 1, 37, 0 }, { 9, 43, 0 }, { 17, 49, 0 }, { 24, 55, 0 }, { 31, 1, 1 }, { 37, 7, 1 }, { 42, 13, 1 }, { 45, 19, 1 }, { 47, 25, 1 }, { 48, 31, 1 }, { 47, 37, 1 }, { 45, 43, 1 }, { 42, 49, 1 }, { 37, 55, 1 }, { 31, 1, 2 }, { 23, 7, 2 }, { 13, 13, 2 }, { 0, 19, 2 }, { 45, 24, 2 }, { 28, 30, 2 }, { 8, 36, 2 }, { 46, 41, 2 }, { 22, 47, 2 }, { 56, 52, 2 }, { 27, 58, 2 } };
            int[,] satu = new int[,] { { 27, 58, 2 }, { 55, 3, 3 }, { 20, 9, 3 }, { 42, 14, 3 }, { 2, 20, 3 }, { 19, 25, 3 }, { 32, 30, 3 }, { 43, 35, 3 }, { 49, 40, 3 }, { 52, 45, 3 }, { 51, 50, 3 }, { 47, 55, 3 }, { 39, 0, 4 }, { 28, 5, 4 }, { 13, 10, 4 }, { 54, 14, 4 }, { 31, 19, 4 }, { 4, 24, 4 }, { 32, 28, 4 }, { 56, 32, 4 }, { 16, 37, 4 }, { 31, 41, 4 }, { 42, 45, 4 }, { 49, 49, 4 }, { 51, 53, 4 }, { 48, 57, 4 }, { 40, 1, 5 }, { 27, 5, 5 }, { 10, 9, 5 }, { 48, 12, 5 }, { 21, 16, 5 } };
            int[,] dua = new int[,] { { 21, 16, 5 }, { 49, 19, 5 }, { 11, 23, 5 }, { 28, 26, 5 }, { 39, 29, 5 }, { 44, 32, 5 }, { 44, 35, 5 }, { 39, 38, 5 }, { 28, 41, 5 }, { 11, 44, 5 }, { 48, 46, 5 }, { 19, 49, 5 }, { 45, 51, 5 }, { 5, 54, 5 }, { 19, 56, 5 }, { 27, 58, 5 }, { 29, 0, 6 }, { 24, 2, 6 }, { 13, 4, 6 }, { 56, 5, 6 }, { 33, 7, 6 }, { 3, 9, 6 }, { 27, 10, 6 }, { 44, 11, 6 }, { 54, 12, 6 }, { 58, 13, 6 }, { 55, 14, 6 }, { 46, 15, 6 }, { 30, 16, 6 }, { 7, 17, 6 }, { 28, 17, 6 } };
            int[,] tiga = new int[,] { { 38, 17, 6 }, { 2, 18, 6 }, { 17, 18, 6 }, { 29, 18, 6 }, { 32, 18, 6 }, { 28, 18, 6 }, { 17, 18, 6 }, { 0, 18, 6 }, { 34, 17, 6 }, { 2, 17, 6 }, { 24, 16, 6 }, { 38, 15, 6 }, { 49, 14, 6 }, { 45, 13, 6 }, { 38, 12, 6 }, { 24, 11, 6 }, { 3, 10, 6 }, { 35, 8, 6 }, { 0, 7, 6 }, { 17, 5, 6 }, { 27, 3, 6 }, { 30, 1, 6 }, { 27, 59, 5 }, { 16, 57, 5 }, { 59, 54, 5 }, { 35, 52, 5 }, { 4, 50, 5 }, { 26, 47, 5 }, { 41, 44, 5 }, { 48, 41, 5 }, { 48, 38, 5 } };
            int[,] empat = new int[,] { { 48, 38, 5 }, { 42, 35, 5 }, { 29, 32, 5 }, { 10, 29, 5 }, { 44, 25, 5 }, { 12, 22, 5 }, { 43, 18, 5 }, { 49, 14, 5 }, { 56, 10, 5 }, { 57, 6, 5 }, { 52, 2, 5 }, { 41, 58, 4 }, { 24, 54, 4 }, { 0, 50, 4 }, { 30, 45, 4 }, { 54, 40, 4 }, { 12, 36, 4 }, { 25, 31, 4 }, { 32, 26, 4 }, { 34, 21, 4 }, { 30, 16, 4 }, { 20, 11, 4 }, { 5, 6, 4 }, { 44, 0, 4 }, { 19, 55, 3 }, { 48, 49, 3 }, { 12, 44, 3 }, { 31, 38, 3 }, { 46, 32, 3 }, { 56, 26, 3 }, { 2, 21, 3 } };
            int[,] lima = new int[,] { { 2, 21, 3 }, { 3, 15, 3 }, { 0, 9, 3 }, { 53, 2, 3 }, { 12, 56, 2 }, { 27, 50, 2 }, { 8, 44, 2 }, { 46, 37, 2 }, { 20, 31, 3 }, { 51, 24, 2 }, { 18, 18, 2 }, { 42, 11, 2 }, { 3, 5, 2 }, { 22, 58, 1 }, { 38, 51, 1 }, { 52, 44, 1 }, { 4, 38, 1 }, { 13, 31, 1 }, { 20, 24, 1 }, { 25, 17, 1 }, { 28, 10, 1 }, { 30, 3, 1 }, { 30, 56, 0 }, { 29, 49, 0 }, { 27, 42, 0 }, { 24, 35, 0 }, { 20, 28, 0 }, { 16, 21, 0 }, { 11, 14, 0 }, { 6, 7, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 6, 7, 0 }, { 11, 14, 0 }, { 16, 21, 0 }, { 20, 28, 0 }, { 24, 35, 0 }, { 27, 42, 0 }, { 29, 49, 0 }, { 30, 56, 0 }, { 30, 3, 1 }, { 28, 10, 1 }, { 25, 17, 1 }, { 20, 24, 1 }, { 13, 31, 1 }, { 4, 38, 1 }, { 52, 44, 1 }, { 38, 51, 1 }, { 22, 58, 1 }, { 3, 5, 2 }, { 42, 11, 2 }, { 18, 18, 2 }, { 51, 24, 2 }, { 20, 31, 3 }, { 46, 37, 2 }, { 8, 44, 2 }, { 27, 50, 2 }, { 12, 56, 2 }, { 53, 2, 3 }, { 0, 9, 3 }, { 3, 15, 3 }, { 2, 21, 3 } };
            int[,] tujuh = new int[,] { { 2, 21, 3 }, { 56, 26, 3 }, { 46, 32, 3 }, { 31, 38, 3 }, { 12, 44, 3 }, { 48, 49, 3 }, { 19, 55, 3 }, { 44, 0, 4 }, { 5, 6, 4 }, { 20, 11, 4 }, { 30, 16, 4 }, { 34, 21, 4 }, { 32, 26, 4 }, { 25, 31, 4 }, { 12, 36, 4 }, { 54, 40, 4 }, { 30, 45, 4 }, { 0, 50, 4 }, { 24, 54, 4 }, { 41, 58, 4 }, { 52, 2, 5 }, { 57, 6, 5 }, { 56, 10, 5 }, { 49, 14, 5 }, { 43, 18, 5 }, { 12, 22, 5 }, { 44, 25, 5 }, { 10, 29, 5 }, { 29, 32, 5 }, { 42, 35, 5 }, { 48, 38, 5 } };
            int[,] delapan = new int[,] { { 48, 38, 5 }, { 48, 41, 5 }, { 41, 44, 5 }, { 26, 47, 5 }, { 4, 50, 5 }, { 35, 52, 5 }, { 59, 54, 5 }, { 16, 57, 5 }, { 27, 59, 5 }, { 30, 1, 6 }, { 27, 3, 6 }, { 17, 5, 6 }, { 0, 7, 6 }, { 35, 8, 6 }, { 3, 10, 6 }, { 24, 11, 6 }, { 38, 12, 6 }, { 45, 13, 6 }, { 49, 14, 6 }, { 38, 15, 6 }, { 24, 16, 6 }, { 2, 17, 6 }, { 34, 17, 6 }, { 0, 18, 6 }, { 17, 18, 6 }, { 28, 18, 6 }, { 32, 18, 6 }, { 29, 18, 6 }, { 17, 18, 6 }, { 2, 18, 6 }, { 38, 17, 6 } };
            int[,] sembilan = new int[,] { { 28, 17, 6 }, { 7, 17, 6 }, { 30, 16, 6 }, { 46, 15, 6 }, { 55, 14, 6 }, { 58, 13, 6 }, { 54, 12, 6 }, { 44, 11, 6 }, { 27, 10, 6 }, { 3, 9, 6 }, { 33, 7, 6 }, { 56, 5, 6 }, { 13, 4, 6 }, { 24, 2, 6 }, { 29, 0, 6 }, { 27, 58, 5 }, { 19, 56, 5 }, { 5, 54, 5 }, { 45, 51, 5 }, { 19, 49, 5 }, { 48, 46, 5 }, { 11, 44, 5 }, { 28, 41, 5 }, { 39, 38, 5 }, { 44, 35, 5 }, { 44, 32, 5 }, { 39, 29, 5 }, { 28, 26, 5 }, { 11, 23, 5 }, { 49, 19, 5 }, { 21, 16, 5 } };
            int[,] sepuluh = new int[,] { { 21, 16, 5 }, { 48, 12, 5 }, { 10, 9, 5 }, { 27, 5, 5 }, { 40, 1, 5 }, { 48, 57, 4 }, { 51, 53, 4 }, { 49, 49, 4 }, { 42, 45, 4 }, { 31, 41, 4 }, { 16, 37, 4 }, { 56, 32, 4 }, { 32, 28, 4 }, { 4, 24, 4 }, { 31, 19, 4 }, { 54, 14, 4 }, { 13, 10, 4 }, { 28, 5, 4 }, { 39, 0, 4 }, { 47, 55, 3 }, { 51, 50, 3 }, { 52, 45, 3 }, { 49, 40, 3 }, { 43, 35, 3 }, { 32, 30, 3 }, { 19, 25, 3 }, { 2, 20, 3 }, { 42, 14, 3 }, { 20, 9, 3 }, { 55, 3, 3 }, { 27, 58, 2 } };
            int[,] sebelas = new int[,] { { 27, 58, 2 }, { 56, 52, 2 }, { 22, 47, 2 }, { 46, 41, 2 }, { 8, 36, 2 }, { 28, 30, 2 }, { 45, 24, 2 }, { 0, 19, 2 }, { 13, 13, 2 }, { 23, 7, 2 }, { 31, 1, 2 }, { 37, 55, 1 }, { 42, 49, 1 }, { 45, 43, 1 }, { 47, 37, 1 }, { 48, 31, 1 }, { 47, 25, 1 }, { 45, 19, 1 }, { 42, 13, 1 }, { 37, 7, 1 }, { 31, 1, 1 }, { 24, 55, 0 }, { 17, 49, 0 }, { 9, 43, 0 }, { 1, 37, 0 }, { 52, 30, 0 }, { 42, 24, 0 }, { 32, 18, 0 }, { 22, 12, 0 }, { 11, 6, 0 }, { 0, 0, 0 } };
            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilsalis(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokatTakdilsalis(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkattakdilSalis(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 0 && alhaqiqiBuruj <= 5)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokatTakdilrobi(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 14, 1, 0 }, { 27, 2, 0 }, { 40, 3, 0 }, { 53, 4, 0 }, { 6, 6, 0 }, { 18, 7, 0 }, { 30, 8, 0 }, { 41, 9, 0 }, { 52, 10, 0 }, { 1, 12, 0 }, { 9, 13, 0 }, { 16, 14, 0 }, { 22, 15, 0 }, { 28, 16, 0 }, { 33, 17, 0 }, { 36, 18, 0 }, { 37, 19, 0 }, { 36, 20, 0 }, { 32, 21, 0 }, { 30, 22, 0 }, { 25, 23, 0 }, { 18, 24, 0 }, { 9, 25, 0 }, { 58, 25, 0 }, { 45, 26, 0 }, { 30, 27, 0 }, { 13, 28, 0 }, { 54, 28, 0 }, { 33, 29, 0 }, { 10, 30, 0 } };
            int[,] satu = new int[,] { { 10, 30, 0 }, { 44, 30, 0 }, { 16, 31, 0 }, { 45, 31, 0 }, { 12, 37, 0 }, { 36, 32, 0 }, { 58, 32, 0 }, { 18, 33, 0 }, { 35, 33, 0 }, { 49, 33, 0 }, { 1, 34, 0 }, { 10, 34, 0 }, { 17, 34, 0 }, { 21, 34, 0 }, { 23, 34, 0 }, { 22, 34, 0 }, { 18, 34, 0 }, { 12, 34, 0 }, { 3, 34, 0 }, { 52, 33, 0 }, { 39, 33, 0 }, { 23, 33, 0 }, { 4, 33, 0 }, { 43, 32, 0 }, { 19, 32, 0 }, { 52, 31, 0 }, { 22, 31, 0 }, { 52, 30, 0 }, { 19, 30, 0 }, { 44, 29, 0 }, { 6, 29, 0 } };
            int[,] dua = new int[,] { { 6, 29, 0 }, { 26, 28, 0 }, { 44, 27, 0 }, { 0, 27, 0 }, { 14, 26, 0 }, { 25, 25, 0 }, { 35, 24, 0 }, { 43, 23, 0 }, { 49, 22, 0 }, { 54, 21, 0 }, { 57, 20, 0 }, { 58, 19, 0 }, { 58, 18, 0 }, { 56, 17, 0 }, { 53, 16, 0 }, { 49, 15, 0 }, { 44, 14, 0 }, { 37, 13, 0 }, { 29, 12, 0 }, { 20, 11, 0 }, { 10, 10, 0 }, { 0, 9, 0 }, { 49, 7, 0 }, { 37, 6, 0 }, { 25, 5, 0 }, { 12, 4, 0 }, { 59, 2, 0 }, { 45, 1, 0 }, { 31, 0, 0 }, { 43, 0, 0 }, { 57, 1, 0 } };
            int[,] tiga = new int[,] { { 57, 1, 0 }, { 11, 3, 0 }, { 25, 4, 0 }, { 38, 5, 0 }, { 52, 6, 0 }, { 5, 8, 0 }, { 17, 9, 0 }, { 29, 10, 0 }, { 40, 11, 0 }, { 51, 12, 0 }, { 1, 14, 0 }, { 10, 15, 0 }, { 18, 16, 0 }, { 25, 17, 0 }, { 30, 18, 0 }, { 34, 19, 0 }, { 37, 20, 0 }, { 39, 21, 0 }, { 39, 22, 0 }, { 38, 23, 0 }, { 36, 24, 0 }, { 32, 25, 0 }, { 26, 26, 0 }, { 18, 27, 0 }, { 8, 28, 0 }, { 56, 28, 0 }, { 42, 29, 0 }, { 26, 30, 0 }, { 8, 31, 0 }, { 48, 31, 0 }, { 26, 32, 0 } };
            int[,] empat = new int[,] { { 26, 32, 0 }, { 2, 33, 0 }, { 35, 33, 0 }, { 35, 34, 0 }, { 35, 34, 0 }, { 1, 35, 0 }, { 25, 35, 0 }, { 46, 35, 0 }, { 5, 36, 0 }, { 21, 36, 0 }, { 34, 36, 0 }, { 45, 36, 0 }, { 54, 36, 0 }, { 0, 37, 0 }, { 3, 37, 0 }, { 7, 37, 0 }, { 2, 37, 0 }, { 58, 36, 0 }, { 51, 36, 0 }, { 41, 36, 0 }, { 28, 36, 0 }, { 13, 36, 0 }, { 55, 35, 0 }, { 35, 35, 0 }, { 12, 35, 0 }, { 46, 34, 0 }, { 18, 34, 0 }, { 47, 33, 0 }, { 14, 33, 0 }, { 39, 32, 0 }, { 2, 33, 0 } };
            int[,] lima = new int[,] { { 2, 32, 0 }, { 33, 31, 0 }, { 41, 30, 0 }, { 57, 29, 0 }, { 10, 29, 0 }, { 21, 28, 0 }, { 30, 27, 0 }, { 37, 26, 0 }, { 42, 25, 0 }, { 45, 23, 0 }, { 47, 23, 0 }, { 47, 22, 0 }, { 45, 21, 0 }, { 42, 20, 0 }, { 37, 19, 0 }, { 30, 18, 0 }, { 22, 17, 0 }, { 13, 16, 0 }, { 3, 15, 0 }, { 52, 13, 0 }, { 40, 12, 0 }, { 27, 11, 0 }, { 13, 10, 0 }, { 58, 8, 0 }, { 42, 7, 0 }, { 26, 6, 0 }, { 9, 5, 0 }, { 52, 3, 0 }, { 35, 2, 0 }, { 18, 1, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 18, 1, 0 }, { 35, 2, 0 }, { 52, 3, 0 }, { 9, 5, 0 }, { 26, 6, 0 }, { 42, 7, 0 }, { 58, 8, 0 }, { 13, 10, 0 }, { 27, 11, 0 }, { 40, 12, 0 }, { 52, 13, 0 }, { 3, 15, 0 }, { 13, 16, 0 }, { 22, 17, 0 }, { 30, 18, 0 }, { 37, 19, 0 }, { 42, 20, 0 }, { 45, 21, 0 }, { 47, 22, 0 }, { 47, 23, 0 }, { 45, 23, 0 }, { 42, 25, 0 }, { 37, 26, 0 }, { 30, 27, 0 }, { 21, 28, 0 }, { 10, 29, 0 }, { 57, 29, 0 }, { 41, 30, 0 }, { 33, 31, 0 }, { 2, 32, 0 } };
            int[,] tujuh = new int[,] { { 2, 33, 0 }, { 39, 32, 0 }, { 14, 33, 0 }, { 47, 33, 0 }, { 18, 34, 0 }, { 46, 34, 0 }, { 12, 35, 0 }, { 35, 35, 0 }, { 55, 35, 0 }, { 13, 36, 0 }, { 28, 36, 0 }, { 41, 36, 0 }, { 51, 36, 0 }, { 58, 36, 0 }, { 2, 37, 0 }, { 7, 37, 0 }, { 3, 37, 0 }, { 0, 37, 0 }, { 54, 36, 0 }, { 45, 36, 0 }, { 34, 36, 0 }, { 21, 36, 0 }, { 5, 36, 0 }, { 46, 35, 0 }, { 25, 35, 0 }, { 1, 35, 0 }, { 35, 34, 0 }, { 35, 34, 0 }, { 35, 33, 0 }, { 2, 33, 0 }, { 26, 32, 0 } };
            int[,] delapan = new int[,] { { 26, 32, 0 }, { 48, 31, 0 }, { 8, 31, 0 }, { 26, 30, 0 }, { 42, 29, 0 }, { 56, 28, 0 }, { 8, 28, 0 }, { 18, 27, 0 }, { 26, 26, 0 }, { 32, 25, 0 }, { 36, 24, 0 }, { 38, 23, 0 }, { 39, 22, 0 }, { 39, 21, 0 }, { 37, 20, 0 }, { 34, 19, 0 }, { 30, 18, 0 }, { 25, 17, 0 }, { 18, 16, 0 }, { 10, 15, 0 }, { 1, 14, 0 }, { 51, 12, 0 }, { 40, 11, 0 }, { 29, 10, 0 }, { 17, 9, 0 }, { 5, 8, 0 }, { 52, 6, 0 }, { 38, 5, 0 }, { 25, 4, 0 }, { 11, 3, 0 }, { 57, 1, 0 } };
            int[,] sembilan = new int[,] { { 57, 1, 0 }, { 43, 0, 0 }, { 31, 0, 0 }, { 45, 1, 0 }, { 59, 2, 0 }, { 12, 4, 0 }, { 25, 5, 0 }, { 37, 6, 0 }, { 49, 7, 0 }, { 0, 9, 0 }, { 10, 10, 0 }, { 20, 11, 0 }, { 29, 12, 0 }, { 37, 13, 0 }, { 44, 14, 0 }, { 49, 15, 0 }, { 53, 16, 0 }, { 56, 17, 0 }, { 58, 18, 0 }, { 58, 19, 0 }, { 57, 20, 0 }, { 54, 21, 0 }, { 49, 22, 0 }, { 43, 23, 0 }, { 35, 24, 0 }, { 25, 25, 0 }, { 14, 26, 0 }, { 0, 27, 0 }, { 44, 27, 0 }, { 26, 28, 0 }, { 6, 29, 0 } };
            int[,] sepuluh = new int[,] { { 6, 29, 0 }, { 44, 29, 0 }, { 19, 30, 0 }, { 52, 30, 0 }, { 22, 31, 0 }, { 52, 31, 0 }, { 19, 32, 0 }, { 43, 32, 0 }, { 4, 33, 0 }, { 23, 33, 0 }, { 39, 33, 0 }, { 52, 33, 0 }, { 3, 34, 0 }, { 12, 34, 0 }, { 18, 34, 0 }, { 22, 34, 0 }, { 23, 34, 0 }, { 21, 34, 0 }, { 17, 34, 0 }, { 10, 34, 0 }, { 1, 34, 0 }, { 49, 33, 0 }, { 35, 33, 0 }, { 18, 33, 0 }, { 58, 32, 0 }, { 36, 32, 0 }, { 12, 37, 0 }, { 45, 31, 0 }, { 16, 31, 0 }, { 44, 30, 0 }, { 10, 30, 0 } };
            int[,] sebelas = new int[,] { { 10, 30, 0 }, { 33, 29, 0 }, { 54, 28, 0 }, { 13, 28, 0 }, { 30, 27, 0 }, { 45, 26, 0 }, { 58, 25, 0 }, { 9, 25, 0 }, { 18, 24, 0 }, { 25, 23, 0 }, { 30, 22, 0 }, { 32, 21, 0 }, { 36, 20, 0 }, { 37, 19, 0 }, { 36, 18, 0 }, { 33, 17, 0 }, { 28, 16, 0 }, { 22, 15, 0 }, { 16, 14, 0 }, { 9, 13, 0 }, { 1, 12, 0 }, { 52, 10, 0 }, { 41, 9, 0 }, { 30, 8, 0 }, { 18, 7, 0 }, { 6, 6, 0 }, { 53, 4, 0 }, { 40, 3, 0 }, { 27, 2, 0 }, { 14, 1, 0 }, { 0, 0, 0 } };

            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilrobi(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokatTakdilrobi(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkattakdilrobi(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 6 && alhaqiqiBuruj <= 11)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokatTakdiluqdah(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifir = new int[,] { { 0, 0, 0 }, { 9, 0, 0 }, { 19, 0, 0 }, { 38, 0, 0 }, { 37, 0, 0 }, { 56, 0, 0 }, { 55, 0, 0 }, { 4, 1, 0 }, { 13, 1, 0 }, { 22, 1, 0 }, { 31, 1, 0 }, { 40, 1, 0 }, { 49, 1, 0 }, { 58, 1, 0 }, { 7, 2, 0 }, { 16, 2, 0 }, { 25, 2, 0 }, { 33, 2, 0 }, { 42, 2, 0 }, { 51, 2, 0 }, { 0, 3, 0 }, { 8, 3, 0 }, { 17, 3, 0 }, { 26, 3, 0 }, { 34, 3, 0 }, { 42, 3, 0 }, { 50, 3, 0 }, { 59, 3, 0 }, { 7, 4, 0 }, { 15, 4, 0 }, { 23, 4, 0 } };
            int[,] satu = new int[,] { { 23, 4, 0 }, { 31, 4, 0 }, { 39, 4, 0 }, { 47, 4, 0 }, { 54, 4, 0 }, { 2, 5, 0 }, { 10, 5, 0 }, { 17, 5, 0 }, { 25, 5, 0 }, { 32, 5, 0 }, { 39, 5, 0 }, { 46, 5, 0 }, { 53, 5, 0 }, { 0, 6, 0 }, { 6, 6, 0 }, { 13, 6, 0 }, { 19, 6, 0 }, { 26, 6, 0 }, { 32, 6, 0 }, { 38, 6, 0 }, { 44, 6, 0 }, { 50, 6, 0 }, { 55, 6, 0 }, { 1, 7, 0 }, { 6, 7, 0 }, { 12, 7, 0 }, { 17, 7, 0 }, { 22, 7, 0 }, { 27, 7, 0 }, { 32, 7, 0 }, { 37, 7, 0 } };
            int[,] dua = new int[,] { { 37, 7, 0 }, { 41, 7, 0 }, { 46, 7, 0 }, { 50, 7, 0 }, { 55, 7, 0 }, { 59, 7, 0 }, { 3, 8, 0 }, { 7, 8, 0 }, { 10, 8, 0 }, { 14, 8, 0 }, { 17, 8, 0 }, { 20, 8, 0 }, { 23, 8, 0 }, { 26, 8, 0 }, { 29, 8, 0 }, { 31, 8, 0 }, { 34, 8, 0 }, { 36, 8, 0 }, { 37, 8, 0 }, { 40, 8, 0 }, { 41, 8, 0 }, { 43, 8, 0 }, { 44, 8, 0 }, { 46, 8, 0 }, { 47, 8, 0 }, { 48, 8, 0 }, { 48, 8, 0 }, { 49, 8, 0 }, { 49, 8, 0 }, { 50, 8, 0 }, { 50, 8, 0 } };
            int[,] tiga = new int[,] { { 50, 8, 0 }, { 50, 8, 0 }, { 50, 8, 0 }, { 49, 8, 0 }, { 49, 8, 0 }, { 48, 8, 0 }, { 47, 8, 0 }, { 46, 8, 0 }, { 45, 8, 0 }, { 44, 8, 0 }, { 43, 8, 0 }, { 41, 8, 0 }, { 39, 8, 0 }, { 37, 8, 0 }, { 35, 8, 0 }, { 33, 8, 0 }, { 30, 8, 0 }, { 28, 8, 0 }, { 25, 8, 0 }, { 22, 8, 0 }, { 19, 8, 0 }, { 16, 8, 0 }, { 13, 8, 0 }, { 9, 8, 0 }, { 7, 8, 0 }, { 2, 8, 0 }, { 58, 7, 0 }, { 54, 7, 0 }, { 50, 7, 0 }, { 46, 7, 0 }, { 41, 7, 0 } };
            int[,] empat = new int[,] { { 41, 7, 0 }, { 36, 7, 0 }, { 31, 7, 0 }, { 26, 7, 0 }, { 21, 7, 0 }, { 16, 7, 0 }, { 10, 7, 0 }, { 5, 7, 0 }, { 59, 6, 0 }, { 54, 6, 0 }, { 48, 6, 0 }, { 42, 6, 0 }, { 36, 6, 0 }, { 30, 6, 0 }, { 23, 6, 0 }, { 17, 6, 0 }, { 10, 6, 0 }, { 4, 6, 0 }, { 57, 5, 0 }, { 50, 5, 0 }, { 43, 5, 0 }, { 36, 5, 0 }, { 29, 5, 0 }, { 21, 5, 0 }, { 14, 5, 0 }, { 6, 5, 0 }, { 48, 4, 0 }, { 51, 4, 0 }, { 43, 4, 0 }, { 35, 4, 0 }, { 27, 4, 0 } };
            int[,] lima = new int[,] { { 27, 4, 0 }, { 19, 4, 0 }, { 11, 4, 0 }, { 3, 4, 0 }, { 55, 3, 0 }, { 46, 3, 0 }, { 38, 3, 0 }, { 29, 3, 0 }, { 21, 3, 0 }, { 12, 3, 0 }, { 3, 3, 0 }, { 54, 2, 0 }, { 45, 2, 0 }, { 36, 2, 0 }, { 27, 2, 0 }, { 18, 2, 0 }, { 9, 2, 0 }, { 0, 2, 0 }, { 52, 1, 0 }, { 42, 1, 0 }, { 33, 1, 0 }, { 24, 1, 0 }, { 15, 1, 0 }, { 5, 1, 0 }, { 56, 0, 0 }, { 47, 0, 0 }, { 38, 0, 0 }, { 28, 0, 0 }, { 19, 0, 0 }, { 10, 0, 0 }, { 0, 0, 0 } };
            int[,] enam = new int[,] { { 0, 0, 0 }, { 10, 0, 0 }, { 19, 0, 0 }, { 28, 0, 0 }, { 38, 0, 0 }, { 47, 0, 0 }, { 56, 0, 0 }, { 5, 1, 0 }, { 15, 1, 0 }, { 24, 1, 0 }, { 33, 1, 0 }, { 42, 1, 0 }, { 52, 1, 0 }, { 0, 2, 0 }, { 9, 2, 0 }, { 18, 2, 0 }, { 27, 2, 0 }, { 36, 2, 0 }, { 45, 2, 0 }, { 54, 2, 0 }, { 3, 3, 0 }, { 12, 3, 0 }, { 21, 3, 0 }, { 29, 3, 0 }, { 38, 3, 0 }, { 46, 3, 0 }, { 55, 3, 0 }, { 3, 4, 0 }, { 11, 4, 0 }, { 19, 4, 0 }, { 27, 4, 0 } };
            int[,] tujuh = new int[,] { { 27, 4, 0 }, { 35, 4, 0 }, { 43, 4, 0 }, { 51, 4, 0 }, { 48, 4, 0 }, { 6, 5, 0 }, { 14, 5, 0 }, { 21, 5, 0 }, { 29, 5, 0 }, { 36, 5, 0 }, { 43, 5, 0 }, { 50, 5, 0 }, { 57, 5, 0 }, { 4, 6, 0 }, { 10, 6, 0 }, { 17, 6, 0 }, { 23, 6, 0 }, { 30, 6, 0 }, { 36, 6, 0 }, { 42, 6, 0 }, { 48, 6, 0 }, { 54, 6, 0 }, { 59, 6, 0 }, { 5, 7, 0 }, { 10, 7, 0 }, { 16, 7, 0 }, { 21, 7, 0 }, { 26, 7, 0 }, { 31, 7, 0 }, { 36, 7, 0 }, { 41, 7, 0 } };
            int[,] delapan = new int[,] { { 41, 7, 0 }, { 46, 7, 0 }, { 50, 7, 0 }, { 54, 7, 0 }, { 58, 7, 0 }, { 2, 8, 0 }, { 7, 8, 0 }, { 9, 8, 0 }, { 13, 8, 0 }, { 16, 8, 0 }, { 19, 8, 0 }, { 22, 8, 0 }, { 25, 8, 0 }, { 28, 8, 0 }, { 30, 8, 0 }, { 33, 8, 0 }, { 35, 8, 0 }, { 37, 8, 0 }, { 39, 8, 0 }, { 41, 8, 0 }, { 43, 8, 0 }, { 44, 8, 0 }, { 45, 8, 0 }, { 46, 8, 0 }, { 47, 8, 0 }, { 48, 8, 0 }, { 49, 8, 0 }, { 49, 8, 0 }, { 50, 8, 0 }, { 50, 8, 0 }, { 50, 8, 0 } };
            int[,] sembilan = new int[,] { { 50, 8, 0 }, { 50, 8, 0 }, { 49, 8, 0 }, { 49, 8, 0 }, { 48, 8, 0 }, { 48, 8, 0 }, { 47, 8, 0 }, { 46, 8, 0 }, { 44, 8, 0 }, { 43, 8, 0 }, { 41, 8, 0 }, { 40, 8, 0 }, { 37, 8, 0 }, { 36, 8, 0 }, { 34, 8, 0 }, { 31, 8, 0 }, { 29, 8, 0 }, { 26, 8, 0 }, { 23, 8, 0 }, { 20, 8, 0 }, { 17, 8, 0 }, { 14, 8, 0 }, { 10, 8, 0 }, { 7, 8, 0 }, { 3, 8, 0 }, { 59, 7, 0 }, { 55, 7, 0 }, { 50, 7, 0 }, { 46, 7, 0 }, { 41, 7, 0 }, { 37, 7, 0 } };
            int[,] sepuluh = new int[,] { { 37, 7, 0 }, { 32, 7, 0 }, { 27, 7, 0 }, { 22, 7, 0 }, { 17, 7, 0 }, { 12, 7, 0 }, { 6, 7, 0 }, { 1, 7, 0 }, { 55, 6, 0 }, { 50, 6, 0 }, { 44, 6, 0 }, { 38, 6, 0 }, { 32, 6, 0 }, { 26, 6, 0 }, { 19, 6, 0 }, { 13, 6, 0 }, { 6, 6, 0 }, { 0, 6, 0 }, { 53, 5, 0 }, { 46, 5, 0 }, { 39, 5, 0 }, { 32, 5, 0 }, { 25, 5, 0 }, { 17, 5, 0 }, { 10, 5, 0 }, { 2, 5, 0 }, { 54, 4, 0 }, { 47, 4, 0 }, { 39, 4, 0 }, { 31, 4, 0 }, { 23, 4, 0 } };
            int[,] sebelas = new int[,] { { 23, 4, 0 }, { 15, 4, 0 }, { 7, 4, 0 }, { 59, 3, 0 }, { 50, 3, 0 }, { 42, 3, 0 }, { 34, 3, 0 }, { 26, 3, 0 }, { 17, 3, 0 }, { 8, 3, 0 }, { 0, 3, 0 }, { 51, 2, 0 }, { 42, 2, 0 }, { 33, 2, 0 }, { 25, 2, 0 }, { 16, 2, 0 }, { 7, 2, 0 }, { 58, 1, 0 }, { 49, 1, 0 }, { 40, 1, 0 }, { 31, 1, 0 }, { 22, 1, 0 }, { 13, 1, 0 }, { 4, 1, 0 }, { 55, 0, 0 }, { 56, 0, 0 }, { 37, 0, 0 }, { 38, 0, 0 }, { 19, 0, 0 }, { 9, 0, 0 }, { 0, 0, 0 } };

            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifir;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satu;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = dua;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tiga;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empat;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = lima;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = enam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = tujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = delapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = sembilan;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = sepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = sebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdiluqdah(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokatTakdiluqdah(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkattakdiluqdah(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj >= 0 && alhaqiqiBuruj <= 6)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
        public static int[,] harokatTakdilkhomis(int alhaqiqiKhosotuha_buruj)
        {
            int[,] sifirEnam = new int[,] { { 0, 0, 0 }, { 14, 0, 0 }, { 28, 0, 0 }, { 42, 0, 0 }, { 56, 0, 0 }, { 10, 1, 0 }, { 24, 1, 0 }, { 37, 1, 0 }, { 51, 1, 0 }, { 4, 2, 0 }, { 18, 2, 0 }, { 31, 2, 0 }, { 44, 2, 0 }, { 56, 2, 0 }, { 9, 3, 0 }, { 21, 3, 0 }, { 33, 3, 0 }, { 45, 3, 0 }, { 57, 3, 0 }, { 8, 4, 0 }, { 19, 4, 0 }, { 29, 4, 0 }, { 40, 4, 0 }, { 50, 4, 0 }, { 59, 4, 0 }, { 8, 5, 0 }, { 17, 5, 0 }, { 26, 5, 0 }, { 34, 5, 0 }, { 41, 5, 0 }, { 49, 5, 0 } };
            int[,] satuTujuh = new int[,] { { 49, 5, 0 }, { 56, 5, 0 }, { 2, 6, 0 }, { 8, 6, 0 }, { 14, 6, 0 }, { 19, 6, 0 }, { 23, 6, 0 }, { 27, 6, 0 }, { 31, 6, 0 }, { 34, 6, 0 }, { 37, 6, 0 }, { 39, 6, 0 }, { 41, 6, 0 }, { 42, 6, 0 }, { 43, 6, 0 }, { 43, 6, 0 }, { 43, 6, 0 }, { 42, 6, 0 }, { 41, 6, 0 }, { 39, 6, 0 }, { 37, 6, 0 }, { 34, 6, 0 }, { 31, 6, 0 }, { 28, 6, 0 }, { 24, 6, 0 }, { 19, 6, 0 }, { 14, 6, 0 }, { 8, 6, 0 }, { 3, 6, 0 }, { 56, 5, 0 }, { 49, 5, 0 } };
            int[,] duaDelapan = new int[,] { { 49, 5, 0 }, { 42, 5, 0 }, { 34, 5, 0 }, { 26, 5, 0 }, { 18, 5, 0 }, { 9, 5, 0 }, { 0, 5, 0 }, { 50, 4, 0 }, { 40, 4, 0 }, { 30, 4, 0 }, { 19, 4, 0 }, { 8, 4, 0 }, { 57, 3, 0 }, { 46, 3, 0 }, { 34, 3, 0 }, { 24, 3, 0 }, { 9, 3, 0 }, { 57, 2, 0 }, { 44, 2, 0 }, { 31, 2, 0 }, { 8, 2, 0 }, { 5, 2, 0 }, { 51, 1, 0 }, { 38, 1, 0 }, { 24, 1, 0 }, { 10, 1, 0 }, { 57, 0, 0 }, { 42, 0, 0 }, { 28, 0, 0 }, { 14, 0, 0 }, { 0, 0, 0 } };
            int[,] tigaSembilang = new int[,] { { 0, 0, 0 }, { 14, 0, 0 }, { 28, 0, 0 }, { 42, 0, 0 }, { 57, 0, 0 }, { 10, 1, 0 }, { 24, 1, 0 }, { 38, 1, 0 }, { 51, 1, 0 }, { 5, 2, 0 }, { 8, 2, 0 }, { 31, 2, 0 }, { 44, 2, 0 }, { 57, 2, 0 }, { 9, 3, 0 }, { 24, 3, 0 }, { 34, 3, 0 }, { 46, 3, 0 }, { 57, 3, 0 }, { 8, 4, 0 }, { 19, 4, 0 }, { 30, 4, 0 }, { 40, 4, 0 }, { 50, 4, 0 }, { 0, 5, 0 }, { 9, 5, 0 }, { 18, 5, 0 }, { 26, 5, 0 }, { 34, 5, 0 }, { 42, 5, 0 }, { 49, 5, 0 } };
            int[,] empatSepuluh = new int[,] { { 49, 5, 0 }, { 56, 5, 0 }, { 3, 6, 0 }, { 8, 6, 0 }, { 14, 6, 0 }, { 19, 6, 0 }, { 24, 6, 0 }, { 28, 6, 0 }, { 31, 6, 0 }, { 34, 6, 0 }, { 37, 6, 0 }, { 39, 6, 0 }, { 41, 6, 0 }, { 42, 6, 0 }, { 43, 6, 0 }, { 43, 6, 0 }, { 43, 6, 0 }, { 42, 6, 0 }, { 41, 6, 0 }, { 39, 6, 0 }, { 37, 6, 0 }, { 34, 6, 0 }, { 31, 6, 0 }, { 27, 6, 0 }, { 23, 6, 0 }, { 19, 6, 0 }, { 14, 6, 0 }, { 8, 6, 0 }, { 2, 6, 0 }, { 56, 5, 0 }, { 49, 5, 0 } };
            int[,] limaSebelas = new int[,] { { 49, 5, 0 }, { 41, 5, 0 }, { 34, 5, 0 }, { 26, 5, 0 }, { 17, 5, 0 }, { 8, 5, 0 }, { 59, 4, 0 }, { 50, 4, 0 }, { 40, 4, 0 }, { 29, 4, 0 }, { 19, 4, 0 }, { 8, 4, 0 }, { 57, 3, 0 }, { 45, 3, 0 }, { 33, 3, 0 }, { 21, 3, 0 }, { 9, 3, 0 }, { 56, 2, 0 }, { 44, 2, 0 }, { 31, 2, 0 }, { 18, 2, 0 }, { 4, 2, 0 }, { 51, 1, 0 }, { 37, 1, 0 }, { 24, 1, 0 }, { 10, 1, 0 }, { 56, 0, 0 }, { 42, 0, 0 }, { 28, 0, 0 }, { 14, 0, 0 }, { 0, 0, 0 } };

            int[,] result;
            if (alhaqiqiKhosotuha_buruj == 0)
            {
                result = sifirEnam;
            }
            else if (alhaqiqiKhosotuha_buruj == 1)
            {
                result = satuTujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 2)
            {
                result = duaDelapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 3)
            {
                result = tigaSembilang;
            }
            else if (alhaqiqiKhosotuha_buruj == 4)
            {
                result = empatSepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 5)
            {
                result = limaSebelas;
            }
            else if (alhaqiqiKhosotuha_buruj == 6)
            {
                result = sifirEnam;
            }
            else if (alhaqiqiKhosotuha_buruj == 7)
            {
                result = satuTujuh;
            }
            else if (alhaqiqiKhosotuha_buruj == 8)
            {
                result = duaDelapan;
            }
            else if (alhaqiqiKhosotuha_buruj == 9)
            {
                result = tigaSembilang;
            }
            else if (alhaqiqiKhosotuha_buruj == 10)
            {
                result = empatSepuluh;
            }
            else if (alhaqiqiKhosotuha_buruj == 11)
            {
                result = limaSebelas;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int[] takdilkhomis(int alhaqiqiDarojah, int alhaqiqiBuruj)
        {
            int[,] array = Harokat.harokatTakdilkhomis(alhaqiqiBuruj);
            int[] result;
            if (alhaqiqiDarojah == 0)
            {
                int[] num = new int[] { array[0, 0], array[0, 1], array[0, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 1)
            {
                int[] num = new int[] { array[1, 0], array[1, 1], array[1, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 2)
            {
                int[] num = new int[] { array[2, 0], array[2, 1], array[2, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 3)
            {
                int[] num = new int[] { array[3, 0], array[3, 1], array[3, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 4)
            {
                int[] num = new int[] { array[4, 0], array[4, 1], array[4, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 5)
            {
                int[] num = new int[] { array[5, 0], array[5, 1], array[5, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 6)
            {
                int[] num = new int[] { array[6, 0], array[6, 1], array[6, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 7)
            {
                int[] num = new int[] { array[7, 0], array[7, 1], array[7, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 8)
            {
                int[] num = new int[] { array[8, 0], array[8, 1], array[8, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 9)
            {
                int[] num = new int[] { array[9, 0], array[9, 1], array[9, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 10)
            {
                int[] num = new int[] { array[10, 0], array[10, 1], array[10, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 11)
            {
                int[] num = new int[] { array[11, 0], array[11, 1], array[11, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 12)
            {
                int[] num = new int[] { array[12, 0], array[12, 1], array[12, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 13)
            {
                int[] num = new int[] { array[13, 0], array[13, 1], array[13, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 14)
            {
                int[] num = new int[] { array[14, 0], array[14, 1], array[14, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 15)
            {
                int[] num = new int[] { array[15, 0], array[15, 1], array[15, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 16)
            {
                int[] num = new int[] { array[16, 0], array[16, 1], array[16, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 17)
            {
                int[] num = new int[] { array[17, 0], array[17, 1], array[17, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 18)
            {
                int[] num = new int[] { array[18, 0], array[18, 1], array[18, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 19)
            {
                int[] num = new int[] { array[19, 0], array[19, 1], array[19, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 20)
            {
                int[] num = new int[] { array[20, 0], array[20, 1], array[20, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 21)
            {
                int[] num = new int[] { array[21, 0], array[21, 1], array[21, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 22)
            {
                int[] num = new int[] { array[22, 0], array[22, 1], array[22, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 23)
            {
                int[] num = new int[] { array[23, 0], array[23, 1], array[23, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 24)
            {
                int[] num = new int[] { array[24, 0], array[24, 1], array[24, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 25)
            {
                int[] num = new int[] { array[25, 0], array[25, 1], array[25, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 26)
            {
                int[] num = new int[] { array[26, 0], array[26, 1], array[26, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 27)
            {
                int[] num = new int[] { array[27, 0], array[27, 1], array[27, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 28)
            {
                int[] num = new int[] { array[28, 0], array[28, 1], array[28, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 29)
            {
                int[] num = new int[] { array[29, 0], array[29, 1], array[29, 2] };
                result = num;
            }
            else if (alhaqiqiDarojah == 30)
            {
                int[] num = new int[] { array[30, 0], array[30, 1], array[30, 2] };
                result = num;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static int pangkattakdilkhomis(int alhaqiqiBuruj)
        {
            int buruj;
            if (alhaqiqiBuruj == 0 || alhaqiqiBuruj == 6 || alhaqiqiBuruj == 1 || alhaqiqiBuruj == 7 || alhaqiqiBuruj == 2 || alhaqiqiBuruj == 8)
            {
                //Kurangi
                buruj = 1;
            }
            else
            {
                //Tambah
                buruj = 2;
            }
            return buruj;
        }
    }
}
