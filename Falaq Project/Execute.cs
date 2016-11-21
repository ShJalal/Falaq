using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falaq_Project
{
    internal class Execute
    {
        public static int[,] alwastu(int tahun, int syahr, int ayyam)
        {
            int[,] result = new int[5, 4];
            int[,] Tahun = Harokat.FindingMajmu(tahun);
            int[,] Mabsutoh = Harokat.FindingMabsutoh(tahun);
            int[,] Syahr = Harokat.FindingSyahr(syahr);
            int[,] Ayyam = Harokat.FindingAyyam(ayyam);
            Console.Write("Alwastu : ");
            int sawani = Tahun[0, 0] + Mabsutoh[0, 0] + Syahr[0, 0] + Ayyam[0, 0];
            int daqiqoah = Tahun[0, 1] + Mabsutoh[0, 1] + Syahr[0, 1] + Ayyam[0, 1];
            int darojah = Tahun[0, 2] + Mabsutoh[0, 2] + Syahr[0, 2] + Ayyam[0, 2];
            int buruj = Tahun[0, 3] + Mabsutoh[0, 3] + Syahr[0, 3] + Ayyam[0, 3];
            int[,] alwastuwastuha = Operation.addition(sawani, daqiqoah, darojah, buruj);
            result[0, 0] = alwastuwastuha[0, 0];
            result[0, 1] = alwastuwastuha[0, 1];
            result[0, 2] = alwastuwastuha[0, 2];
            result[0, 3] = alwastuwastuha[0, 3];
            int sawani2 = Tahun[1, 0] + Mabsutoh[1, 0] + Syahr[1, 0] + Ayyam[1, 0];
            int daqiqoah2 = Tahun[1, 1] + Mabsutoh[1, 1] + Syahr[1, 1] + Ayyam[1, 1];
            int darojah2 = Tahun[1, 2] + Mabsutoh[1, 2] + Syahr[1, 2] + Ayyam[1, 2];
            int buruj2 = Tahun[1, 3] + Mabsutoh[1, 3] + Syahr[1, 3] + Ayyam[1, 3];
            int[,] alwastukhosotuha = Operation.addition(sawani2, daqiqoah2, darojah2, buruj2);
            result[1, 0] = alwastukhosotuha[0, 0];
            result[1, 1] = alwastukhosotuha[0, 1];
            result[1, 2] = alwastukhosotuha[0, 2];
            result[1, 3] = alwastukhosotuha[0, 3];
            int sawani3 = Tahun[2, 0] + Mabsutoh[2, 0] + Syahr[2, 0] + Ayyam[2, 0];
            int daqiqoah3 = Tahun[2, 1] + Mabsutoh[2, 1] + Syahr[2, 1] + Ayyam[2, 1];
            int darojah3 = Tahun[2, 2] + Mabsutoh[2, 2] + Syahr[2, 2] + Ayyam[2, 2];
            int buruj3 = Tahun[2, 3] + Mabsutoh[2, 3] + Syahr[2, 3] + Ayyam[2, 3];
            int[,] alwastuwastuhu = Operation.addition(sawani3, daqiqoah3, darojah3, buruj3);
            result[2, 0] = alwastuwastuhu[0, 0];
            result[2, 1] = alwastuwastuhu[0, 1];
            result[2, 2] = alwastuwastuhu[0, 2];
            result[2, 3] = alwastuwastuhu[0, 3];
            int sawani4 = Tahun[3, 0] + Mabsutoh[3, 0] + Syahr[3, 0] + Ayyam[3, 0];
            int daqiqoah4 = Tahun[3, 1] + Mabsutoh[3, 1] + Syahr[3, 1] + Ayyam[3, 1];
            int darojah4 = Tahun[3, 2] + Mabsutoh[3, 2] + Syahr[3, 2] + Ayyam[3, 2];
            int buruj4 = Tahun[3, 3] + Mabsutoh[3, 3] + Syahr[3, 3] + Ayyam[3, 3];
            int[,] alwastukhosotuhu = Operation.addition(sawani4, daqiqoah4, darojah4, buruj4);
            result[3, 0] = alwastukhosotuhu[0, 0];
            result[3, 1] = alwastukhosotuhu[0, 1];
            result[3, 2] = alwastukhosotuhu[0, 2];
            result[3, 3] = alwastukhosotuhu[0, 3];
            int sawani5 = Tahun[4, 0] + Mabsutoh[4, 0] + Syahr[4, 0] + Ayyam[4, 0];
            int daqiqoah5 = Tahun[4, 1] + Mabsutoh[4, 1] + Syahr[4, 1] + Ayyam[4, 1];
            int darojah5 = Tahun[4, 2] + Mabsutoh[4, 2] + Syahr[4, 2] + Ayyam[4, 2];
            int buruj5 = Tahun[4, 3] + Mabsutoh[4, 3] + Syahr[4, 3] + Ayyam[4, 3];
            int[,] alwastuuqdatuhu = Operation.addition(sawani5, daqiqoah5, darojah5, buruj5);
            result[4, 0] = alwastuuqdatuhu[0, 0];
            result[4, 1] = alwastuuqdatuhu[0, 1];
            result[4, 2] = alwastuuqdatuhu[0, 2];
            result[4, 3] = alwastuuqdatuhu[0, 3];
            return result;
        }
        public static int[,] alwastuBadalGhurub(int[,] alwastu, int saah, int daqiqoh)
        {
            int[,] result = new int[5, 4];
            int[,] Saah = Harokat.FindingSaah(saah);
            int[,] Daqiqoh = Harokat.FindingDaqiqoh(daqiqoh);
            Console.Write("\nABG : ");
            int sawani = alwastu[0, 0] + Saah[0, 0] + Daqiqoh[0, 0];
            int daqiqoah = alwastu[0, 1] + Saah[0, 1] + Daqiqoh[0, 1];
            int darojah = alwastu[0, 2] + Saah[0, 2];
            int buruj = alwastu[0, 3] + Saah[0, 3];
            int[,] alwastubadalghurubwastuha = Operation.addition(sawani, daqiqoah, darojah, buruj);
            result[0, 0] = alwastubadalghurubwastuha[0, 0];
            result[0, 1] = alwastubadalghurubwastuha[0, 1];
            result[0, 2] = alwastubadalghurubwastuha[0, 2];
            result[0, 3] = alwastubadalghurubwastuha[0, 3];
            int sawani2 = alwastu[1, 0] + Saah[1, 0] + Daqiqoh[1, 0];
            int daqiqoah2 = alwastu[1, 1] + Saah[1, 1] + Daqiqoh[1, 1];
            int darojah2 = alwastu[1, 2] + Saah[1, 2];
            int buruj2 = alwastu[1, 3] + Saah[1, 3];
            int[,] alwastubadalghurubkhosotuha = Operation.addition(sawani2, daqiqoah2, darojah2, buruj2);
            result[1, 0] = alwastubadalghurubkhosotuha[0, 0];
            result[1, 1] = alwastubadalghurubkhosotuha[0, 1];
            result[1, 2] = alwastubadalghurubkhosotuha[0, 2];
            result[1, 3] = alwastubadalghurubkhosotuha[0, 3];
            int sawani3 = alwastu[2, 0] + Saah[2, 0] + Daqiqoh[2, 0];
            int daqiqoah3 = alwastu[2, 1] + Saah[2, 1] + Daqiqoh[2, 1];
            int darojah3 = alwastu[2, 2] + Saah[2, 2];
            int buruj3 = alwastu[2, 3] + Saah[2, 3];
            int[,] alwastubadalghurubwastuhu = Operation.addition(sawani3, daqiqoah3, darojah3, buruj3);
            result[2, 0] = alwastubadalghurubwastuhu[0, 0];
            result[2, 1] = alwastubadalghurubwastuhu[0, 1];
            result[2, 2] = alwastubadalghurubwastuhu[0, 2];
            result[2, 3] = alwastubadalghurubwastuhu[0, 3];
            int sawani4 = alwastu[3, 0] + Saah[3, 0] + Daqiqoh[3, 0];
            int daqiqoah4 = alwastu[3, 1] + Saah[3, 1] + Daqiqoh[3, 1];
            int darojah4 = alwastu[3, 2] + Saah[3, 2];
            int buruj4 = alwastu[3, 3] + Saah[3, 3];
            int[,] alwastubadalghurubkhosotuhu = Operation.addition(sawani4, daqiqoah4, darojah4, buruj4);
            result[3, 0] = alwastubadalghurubkhosotuhu[0, 0];
            result[3, 1] = alwastubadalghurubkhosotuhu[0, 1];
            result[3, 2] = alwastubadalghurubkhosotuhu[0, 2];
            result[3, 3] = alwastubadalghurubkhosotuhu[0, 3];
            int sawani5 = alwastu[4, 0] + Saah[4, 0] + Daqiqoh[4, 0];
            int daqiqoah5 = alwastu[4, 1] + Saah[4, 1] + Daqiqoh[4, 1];
            int darojah5 = alwastu[4, 2] + Saah[4, 2];
            int buruj5 = alwastu[4, 3] + Saah[4, 3];
            int[,] alwastubadalghurubuqdatuhu = Operation.addition(sawani5, daqiqoah5, darojah5, buruj5);
            result[4, 0] = alwastubadalghurubuqdatuhu[0, 0];
            result[4, 1] = alwastubadalghurubuqdatuhu[0, 1];
            result[4, 2] = alwastubadalghurubuqdatuhu[0, 2];
            result[4, 3] = alwastubadalghurubuqdatuhu[0, 3];
            return result;
        }
        public static int[,] alhaqiqi(int[,] alwastuBadalGhurub)
        {
            int pangkat = Harokat.PangkatTafawut(alwastuBadalGhurub[0, 3]);
            int[,] tafawut = Harokat.HarokatTafawut(alwastuBadalGhurub[0, 2], alwastuBadalGhurub[0, 3]);
            Console.Write("\nAlhaqiqi : ");
            int[,] result = new int[5, 4];
            if (pangkat == 1)
            {
                int sawani = alwastuBadalGhurub[0, 0] + tafawut[0, 0];
                int daqiqoah = alwastuBadalGhurub[0, 1] + tafawut[0, 1];
                int darojah = alwastuBadalGhurub[0, 2] + tafawut[0, 2];
                int buruj = alwastuBadalGhurub[0, 3] + tafawut[0, 3];
                int[,] alhaqiqi1 = Operation.addition(sawani, daqiqoah, darojah, buruj);
                result[0, 0] = alhaqiqi1[0, 0];
                result[0, 1] = alhaqiqi1[0, 1];
                result[0, 2] = alhaqiqi1[0, 2];
                result[0, 3] = alhaqiqi1[0, 3];
                int sawani2 = alwastuBadalGhurub[1, 0] + tafawut[1, 0];
                int daqiqoah2 = alwastuBadalGhurub[1, 1] + tafawut[1, 1];
                int darojah2 = alwastuBadalGhurub[1, 2] + tafawut[1, 2];
                int buruj2 = alwastuBadalGhurub[1, 3] + tafawut[1, 3];
                int[,] alhaqiqi2 = Operation.addition(sawani2, daqiqoah2, darojah2, buruj2);
                result[1, 0] = alhaqiqi2[0, 0];
                result[1, 1] = alhaqiqi2[0, 1];
                result[1, 2] = alhaqiqi2[0, 2];
                result[1, 3] = alhaqiqi2[0, 3];
                int sawani3 = alwastuBadalGhurub[2, 0] + tafawut[2, 0];
                int daqiqoah3 = alwastuBadalGhurub[2, 1] + tafawut[2, 1];
                int darojah3 = alwastuBadalGhurub[2, 2] + tafawut[2, 2];
                int buruj3 = alwastuBadalGhurub[2, 3] + tafawut[2, 3];
                int[,] alhaqiqi3 = Operation.addition(sawani3, daqiqoah3, darojah3, buruj3);
                result[2, 0] = alhaqiqi3[0, 0];
                result[2, 1] = alhaqiqi3[0, 1];
                result[2, 2] = alhaqiqi3[0, 2];
                result[2, 3] = alhaqiqi3[0, 3];
                int sawani4 = alwastuBadalGhurub[3, 0] + tafawut[3, 0];
                int daqiqoah4 = alwastuBadalGhurub[3, 1] + tafawut[3, 1];
                int darojah4 = alwastuBadalGhurub[3, 2] + tafawut[3, 2];
                int buruj4 = alwastuBadalGhurub[3, 3] + tafawut[3, 3];
                int[,] alhaqiqi4 = Operation.addition(sawani4, daqiqoah4, darojah4, buruj4);
                result[3, 0] = alhaqiqi4[0, 0];
                result[3, 1] = alhaqiqi4[0, 1];
                result[3, 2] = alhaqiqi4[0, 2];
                result[3, 3] = alhaqiqi4[0, 3];
                int sawani5 = alwastuBadalGhurub[4, 0] + tafawut[4, 0];
                int daqiqoah5 = alwastuBadalGhurub[4, 1] + tafawut[4, 1];
                int darojah5 = alwastuBadalGhurub[4, 2] + tafawut[4, 2];
                int buruj5 = alwastuBadalGhurub[4, 3] + tafawut[4, 3];
                int[,] alhaqiqi5 = Operation.addition(sawani5, daqiqoah5, darojah5, buruj5);
                result[4, 0] = alhaqiqi5[0, 0];
                result[4, 1] = alhaqiqi5[0, 1];
                result[4, 2] = alhaqiqi5[0, 2];
                result[4, 3] = alhaqiqi5[0, 3];

            }
            else
            {
                int[,] alhaqiqi1 = Operation.subtract(alwastuBadalGhurub[0, 0], tafawut[0, 0],
                  alwastuBadalGhurub[0, 1], tafawut[0, 1], alwastuBadalGhurub[0, 2], tafawut[0, 2],
                   alwastuBadalGhurub[0, 3], tafawut[0, 3]);
                result[0, 0] = alhaqiqi1[0, 0];
                result[0, 1] = alhaqiqi1[0, 1];
                result[0, 2] = alhaqiqi1[0, 2];
                result[0, 3] = alhaqiqi1[0, 3];
                int[,] alhaqiqi2 = Operation.subtract(alwastuBadalGhurub[1, 0], tafawut[1, 0],
                   alwastuBadalGhurub[1, 1], tafawut[1, 1], alwastuBadalGhurub[1, 2], tafawut[1, 2],
                  alwastuBadalGhurub[1, 3], tafawut[1, 3]);
                result[1, 0] = alhaqiqi2[0, 0];
                result[1, 1] = alhaqiqi2[0, 1];
                result[1, 2] = alhaqiqi2[0, 2];
                result[1, 3] = alhaqiqi2[0, 3];
                int[,] alhaqiqi3 = Operation.subtract(alwastuBadalGhurub[2, 0], tafawut[2, 0],
                   alwastuBadalGhurub[2, 1], tafawut[2, 1], alwastuBadalGhurub[2, 2], tafawut[2, 2],
                   alwastuBadalGhurub[2, 3], tafawut[2, 3]);
                result[2, 0] = alhaqiqi3[0, 0];
                result[2, 1] = alhaqiqi3[0, 1];
                result[2, 2] = alhaqiqi3[0, 2];
                result[2, 3] = alhaqiqi3[0, 3];
                int[,] alhaqiqi4 = Operation.subtract(alwastuBadalGhurub[3, 0], tafawut[3, 0],
                    alwastuBadalGhurub[3, 1], tafawut[3, 1], alwastuBadalGhurub[3, 2], tafawut[3, 2],
                    alwastuBadalGhurub[3, 3], tafawut[3, 3]);
                result[3, 0] = alhaqiqi4[0, 0];
                result[3, 1] = alhaqiqi4[0, 1];
                result[3, 2] = alhaqiqi4[0, 2];
                result[3, 3] = alhaqiqi4[0, 3];
                int[,] alhaqiqi5 = Operation.subtract(alwastuBadalGhurub[4, 0], tafawut[4, 0],
                    alwastuBadalGhurub[4, 1], tafawut[4, 1], alwastuBadalGhurub[4, 2], tafawut[4, 2],
                    alwastuBadalGhurub[4, 3], tafawut[4, 3]);
                result[4, 0] = alhaqiqi5[0, 0];
                result[4, 1] = alhaqiqi5[0, 1];
                result[4, 2] = alhaqiqi5[0, 2];
                result[4, 3] = alhaqiqi5[0, 3];
            }
            return result;
        }
        public static int[,] TulusSyams(int[,] alhaqiqifinal, int[,] hasilTakdil)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nTulus Syams : ");
            int pangkatTakdilSyams = Harokat.pangkatTakdilSyam(alhaqiqifinal[1, 3]);
            if (pangkatTakdilSyams == 1)
            {

                result = Operation.subtract(alhaqiqifinal[0, 0], hasilTakdil[0, 0], alhaqiqifinal[0, 1],
                    hasilTakdil[0, 1], alhaqiqifinal[0, 2], hasilTakdil[0, 2], alhaqiqifinal[0, 3], hasilTakdil[0, 3]);
            }
            else
            {
                int sawani = alhaqiqifinal[0, 0] + hasilTakdil[0, 0];
                int daqiqoh = alhaqiqifinal[0, 1] + hasilTakdil[0, 1];
                int darojah = alhaqiqifinal[0, 2] + hasilTakdil[0, 2];
                int buruj = alhaqiqifinal[0, 3] + hasilTakdil[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] DalilSani(int[,] alhaqiqifinal, int[,] tulusSyams)
        {
            Console.Write("\nAl baqi : ");
            int[,] Albaqi = Operation.subtract(alhaqiqifinal[2, 0], tulusSyams[0, 0], alhaqiqifinal[2, 1],
                tulusSyams[0, 1], alhaqiqifinal[2, 2], tulusSyams[0, 2], alhaqiqifinal[2, 3], tulusSyams[0, 3]);
            Console.Write("\nMislahu : ");
            int[,] mislahu = Operation.subtract(alhaqiqifinal[2, 0], tulusSyams[0, 0], alhaqiqifinal[2, 1],
                tulusSyams[0, 1], alhaqiqifinal[2, 2], tulusSyams[0, 2], alhaqiqifinal[2, 3], tulusSyams[0, 3]);
            Console.Write("\nDofuhu : ");
            int sawani = Albaqi[0, 0] + mislahu[0, 0];
            int daqiqoh = Albaqi[0, 1] + mislahu[0, 1];
            int darojah = Albaqi[0, 2] + mislahu[0, 2];
            int buruj = Albaqi[0, 3] + mislahu[0, 3];
            int[,] dofuhu = Operation.addition(sawani, daqiqoh, darojah, buruj);
            Console.Write("\nDalil Sani : ");
            int[,] hasilDalilSani = Operation.subtract(dofuhu[0, 0], alhaqiqifinal[3, 0], dofuhu[0, 1],
                alhaqiqifinal[3, 1],
                dofuhu[0, 2], alhaqiqifinal[3, 2], dofuhu[0, 3], alhaqiqifinal[3, 3]);

            return hasilDalilSani;
        }
        public static int[,] takdilSyam(int[,] alhaqiqifinal)
        {
            Console.Write("\nTakdil Syams : ");
            int[] satrAwal = Harokat.takdilsyamdarojah(alhaqiqifinal[1, 2], alhaqiqifinal[1, 3]);
            int[] satrSani = Harokat.takdilsyamdarojah(++alhaqiqifinal[1, 2], alhaqiqifinal[1, 3]);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Operation.Takdil(defineAwal_Sani, satrAwal, satrSani, alhaqiqifinal);
            return hasilTakdil;
        }
        public static int[,] TakdilAwal(int[,] alhaqiqifinal, int alhaqiqiburuj)
        {
            int[] satrAwalDalilAwal = Harokat.takdilawaldarojah(alhaqiqiburuj, alhaqiqifinal[1, 3]);
            int[] satrSaniDalilAwal = Harokat.takdilawaldarojah(++alhaqiqiburuj, alhaqiqifinal[1, 3]);
            int defineAwalSani = Logic.besarAwalorSani(satrAwalDalilAwal, satrSaniDalilAwal);
            int[] hasil = Logic.DefineAwalOrSani(defineAwalSani, satrAwalDalilAwal, satrSaniDalilAwal);
            Console.Write("\nTakdil Awal : ");
            int[,] hasilTakdilAwal = Operation.Takdil(defineAwalSani, satrAwalDalilAwal, satrSaniDalilAwal,
                alhaqiqifinal);
            return hasilTakdilAwal;
        }

        public static int[,] TakdilSani(int[,] hasilDalilSani, int[,] alhaqiqifinal)
        {
            int[] satrAwal = Harokat.takdilSaniDarojah(hasilDalilSani[0, 2], hasilDalilSani[0, 3]);
            int[] satrSani = Harokat.takdilSaniDarojah(++hasilDalilSani[0, 2], hasilDalilSani[0, 3]);
            int defineAwalSani = Logic.besarAwalorSani(satrAwal, satrSani);
            Console.Write("\nTakdil Sani : ");
            int[,] hasilTakdilSani = Logic.TakdilSaniLogic(defineAwalSani, satrAwal, satrSani, hasilDalilSani);
            return hasilTakdilSani;
        }
        public static int[,] adalatulUla(int[,] alhaqiqifinal, int[,] takdilAwal)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nAdalatul Ula : ");
            int pangkatTakdilawal = Harokat.pangkatTakdilAwal(alhaqiqifinal[1, 3]);
            if (pangkatTakdilawal == 1)
            {
                result = Operation.subtract(alhaqiqifinal[3, 0], takdilAwal[0, 0], alhaqiqifinal[3, 1],
                    takdilAwal[0, 1], alhaqiqifinal[3, 2], takdilAwal[0, 2], alhaqiqifinal[3, 3], takdilAwal[0, 3]);
            }
            else
            {
                int sawani = alhaqiqifinal[3, 0] + takdilAwal[0, 0];
                int daqiqoh = alhaqiqifinal[3, 1] + takdilAwal[0, 1];
                int darojah = alhaqiqifinal[3, 2] + takdilAwal[0, 2];
                int buruj = alhaqiqifinal[3, 3] + takdilAwal[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] adalatussani(int a, int[,] adalatulUla, int[,] takdilsani)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nadalatus sani : ");
            int pangkatTakdilsani = Harokat.pangkatTakdilsani(a);
            if (pangkatTakdilsani == 1)
            {
                result = Operation.subtract(adalatulUla[0, 0], takdilsani[0, 0], adalatulUla[0, 1],
                    takdilsani[0, 1], adalatulUla[0, 2], takdilsani[0, 2], adalatulUla[0, 3], takdilsani[0, 3]);
            }
            else
            {
                int sawani = adalatulUla[0, 0] + takdilsani[0, 0];
                int daqiqoh = adalatulUla[0, 1] + takdilsani[0, 1];
                int darojah = adalatulUla[0, 2] + takdilsani[0, 2];
                int buruj = adalatulUla[0, 3] + takdilsani[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] takdilKhosoh(int[,] alhaqiqifinal, int alhaqiqidarojah, int alhaqiqiburuj)
        {
            Console.Write("\nTakdil Khosoh : ");
            int[] satrAwal = Harokat.takdilHossoh(alhaqiqidarojah, alhaqiqiburuj);
            int[] satrSani = Harokat.takdilHossoh(++alhaqiqidarojah, alhaqiqiburuj);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Operation.Takdil(defineAwal_Sani, satrAwal, satrSani, alhaqiqifinal);
            return hasilTakdil;
        }
        public static int[,] dalilSalis(int pangkat, int[,] adalatussani, int[,] takdilKhosoh)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nDalil Salis : ");
            int pangkatTakdilawal = Harokat.pangkattakdilHossoh(pangkat);
            if (pangkatTakdilawal == 1)
            {
                result = Operation.subtract(adalatussani[0, 0], takdilKhosoh[0, 0], adalatussani[0, 1],
                    takdilKhosoh[0, 1], adalatussani[0, 2], takdilKhosoh[0, 2], adalatussani[0, 3], takdilKhosoh[0, 3]);
            }
            else
            {
                int sawani = adalatussani[0, 0] + takdilKhosoh[0, 0];
                int daqiqoh = adalatussani[0, 1] + takdilKhosoh[0, 1];
                int darojah = adalatussani[0, 2] + takdilKhosoh[0, 2];
                int buruj = adalatussani[0, 3] + takdilKhosoh[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] MuaddalAwal(int[,] alhaqiqifinal, int[,] hasilTakdil)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nMuaddal Awal : ");
            int pangkatTakdilSyams = Harokat.pangkatTakdilAwal(alhaqiqifinal[1, 3]);
            if (pangkatTakdilSyams == 1)
            {

                result = Operation.subtract(alhaqiqifinal[2, 0], hasilTakdil[0, 0], alhaqiqifinal[2, 1],
                    hasilTakdil[0, 1], alhaqiqifinal[2, 2], hasilTakdil[0, 2], alhaqiqifinal[2, 3], hasilTakdil[0, 3]);
            }
            else
            {
                int sawani = alhaqiqifinal[2, 0] + hasilTakdil[0, 0];
                int daqiqoh = alhaqiqifinal[2, 1] + hasilTakdil[0, 1];
                int darojah = alhaqiqifinal[2, 2] + hasilTakdil[0, 2];
                int buruj = alhaqiqifinal[2, 3] + hasilTakdil[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] muaddalSani(int[,] alhaqiqifinal, int[,] muaddalAwal, int[,] takdilSani)
        {
            int[,] result = new int[1, 4];
            int pangkatTakdilSani = Harokat.pangkatTakdilsani(alhaqiqifinal[1, 3]);
            Console.Write("\nMuaddal Sani : ");
            if (pangkatTakdilSani == 1)
            {

                result = Operation.subtract(muaddalAwal[0, 0], takdilSani[0, 0], muaddalAwal[0, 1], takdilSani[0, 1],
                    muaddalAwal[0, 2], takdilSani[0, 2], muaddalAwal[0, 3], takdilSani[0, 3]);
            }
            else
            {
                int sawani = muaddalAwal[0, 0] + takdilSani[0, 0];
                int daqiqoh = muaddalAwal[0, 1] + takdilSani[0, 1];
                int darojah = muaddalAwal[0, 2] + takdilSani[0, 2];
                int buruj = muaddalAwal[0, 3] + takdilSani[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] TakdilSalis(int[,] dalilSalis)
        {
            int[] satrAwal = Harokat.takdilsalis(dalilSalis[0, 2], dalilSalis[0, 3]);
            int[] satrSani = Harokat.takdilsalis(++dalilSalis[0, 2], dalilSalis[0, 3]);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Logic.LogicTakdilSalis(defineAwal_Sani, satrAwal, satrSani, dalilSalis);
            return hasilTakdil;
        }
        public static int[,] muaddalsalis(int a, int[,] muaddalsani, int[,] takdilsalis)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nMuaddal Salis : ");
            int pangkatTakdilSani = Harokat.pangkattakdilSalis(a);
            if (pangkatTakdilSani == 1)
            {

                result = Operation.subtract(muaddalsani[0, 0], takdilsalis[0, 0], muaddalsani[0, 1], takdilsalis[0, 1],
                    muaddalsani[0, 2], takdilsalis[0, 2], muaddalsani[0, 3], takdilsalis[0, 3]);
            }
            else
            {
                int sawani = muaddalsani[0, 0] + takdilsalis[0, 0];
                int daqiqoh = muaddalsani[0, 1] + takdilsalis[0, 1];
                int darojah = muaddalsani[0, 2] + takdilsalis[0, 2];
                int buruj = muaddalsani[0, 3] + takdilsalis[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] TakdilRobi(int[,] dalilRobi)
        {
            Console.Write("\nTakdil Robi : ");
            int[] satrAwal = Harokat.takdilrobi(dalilRobi[0, 2], dalilRobi[0, 3]);
            int[] satrSani = Harokat.takdilrobi(++dalilRobi[0, 2], dalilRobi[0, 3]);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Logic.LogicTakdilrobi(defineAwal_Sani, satrAwal, satrSani, dalilRobi);
            return hasilTakdil;
        }
        public static int[,] dalilRobi(int[,] muaddalsalis, int[,] tulusSyams)
        {
            Console.Write("\ndalil Robi : ");
            int[,] result = Operation.subtract(muaddalsalis[0, 0], tulusSyams[0, 0], muaddalsalis[0, 1],
                tulusSyams[0, 1], muaddalsalis[0, 2], tulusSyams[0, 2], muaddalsalis[0, 3], tulusSyams[0, 3]);
            return result;
        }
        public static int[,] muaddalrobi(int a, int[,] muaddalsalis, int[,] TakdilRobi)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nMuaddal Robi : ");
            int pangkatTakdilSani = Harokat.pangkattakdilrobi(a);
            if (pangkatTakdilSani == 1)
            {

                result = Operation.subtract(muaddalsalis[0, 0], TakdilRobi[0, 0], muaddalsalis[0, 1], TakdilRobi[0, 1],
                    muaddalsalis[0, 2], TakdilRobi[0, 2], muaddalsalis[0, 3], TakdilRobi[0, 3]);
            }
            else
            {
                int sawani = muaddalsalis[0, 0] + TakdilRobi[0, 0];
                int daqiqoh = muaddalsalis[0, 1] + TakdilRobi[0, 1];
                int darojah = muaddalsalis[0, 2] + TakdilRobi[0, 2];
                int buruj = muaddalsalis[0, 3] + TakdilRobi[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;

        }
        public static int[,] Takdiluqdah(int[,] alhaqiqifinal, int alhaqiqiburuj, int alhaqiqidarojah)
        {
            Console.Write("\nTakdil Uqdah : ");
            int[] satrAwal = Harokat.takdiluqdah(alhaqiqiburuj, alhaqiqidarojah);
            int[] satrSani = Harokat.takdiluqdah(++alhaqiqiburuj, alhaqiqidarojah);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Logic.LogicTakdiluqdah(defineAwal_Sani, satrAwal, satrSani, alhaqiqifinal);
            return hasilTakdil;
        }
        public static int[,] mushohah(int a, int[,] alhaqiqifinal, int[,] takdiluqdah)
        {
            int[,] result = new int[1, 4];
            Console.Write("\nMushohah : ");
            int pangkatTakdil = Harokat.pangkattakdiluqdah(a);
            if (pangkatTakdil == 1)
            {

                result = Operation.subtract(alhaqiqifinal[4, 0], takdiluqdah[0, 0], alhaqiqifinal[4, 1], takdiluqdah[0, 1],
                    alhaqiqifinal[4, 2], takdiluqdah[0, 2], alhaqiqifinal[4, 3], takdiluqdah[0, 3]);
            }
            else
            {
                int sawani = alhaqiqifinal[4, 0] + takdiluqdah[0, 0];
                int daqiqoh = alhaqiqifinal[4, 1] + takdiluqdah[0, 1];
                int darojah = alhaqiqifinal[4, 2] + takdiluqdah[0, 2];
                int buruj = alhaqiqifinal[4, 3] + takdiluqdah[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;
        }
        public static int[,] dalilkhomis(int[,] mushohah, int[,] muaddalrobi)
        {
            Console.Write("\nDalil Khomis : ");
            int sawani = mushohah[0, 0] + muaddalrobi[0, 0];
            int daqiqoh = mushohah[0, 1] + muaddalrobi[0, 1];
            int darojah = mushohah[0, 2] + muaddalrobi[0, 2];
            int buruj = mushohah[0, 3] + muaddalrobi[0, 3];
            int[,] dalilkhomis = Operation.addition(sawani, daqiqoh, darojah, buruj);
            return dalilkhomis;
        }
        public static int[,] takdilkhomis(int[,] dalilkhomis)
        {
            Console.Write("\nTakdil Khomis : ");
            int[] satrAwal = Harokat.takdilkhomis(dalilkhomis[0, 2], dalilkhomis[0, 3]);
            int[] satrSani = Harokat.takdilkhomis(++dalilkhomis[0, 2], dalilkhomis[0, 3]);
            int defineAwal_Sani = Logic.besarAwalorSani(satrAwal, satrSani);
            int[,] hasilTakdil = Logic.LogicTakdilkhomis(defineAwal_Sani, satrAwal, satrSani, dalilkhomis);
            return hasilTakdil;
        }
        public static int[,] TululQomar(int a, int[,] muaddalrobi, int[,] takdilKhomis)
        {
            Console.Write("\nTulul Qomar : ");
            int[,] result = new int[1, 4];
            int pangkatTakdilSani = Harokat.pangkattakdilkhomis(a);
            if (pangkatTakdilSani == 1)
            {

                result = Operation.subtract(muaddalrobi[0, 0], takdilKhomis[0, 0], muaddalrobi[0, 1], takdilKhomis[0, 1],
                    muaddalrobi[0, 2], takdilKhomis[0, 2], muaddalrobi[0, 3], takdilKhomis[0, 3]);
            }
            else
            {
                int sawani = muaddalrobi[0, 0] + takdilKhomis[0, 0];
                int daqiqoh = muaddalrobi[0, 1] + takdilKhomis[0, 1];
                int darojah = muaddalrobi[0, 2] + takdilKhomis[0, 2];
                int buruj = muaddalrobi[0, 3] + takdilKhomis[0, 3];
                result = Operation.addition(sawani, daqiqoh, darojah, buruj);
            }
            return result;// 

        }
        public static int[,] BukdulMutlaq(int[,] TululQomar, int[,] tulusSyams)
        {
            Console.Write("\nbukdulMutlaq : ");
            int[,] result = Operation.subtract(TululQomar[0, 0], tulusSyams[0, 0], TululQomar[0,1], tulusSyams[0,1],
                    TululQomar[0,2], tulusSyams[0,2], TululQomar[0,3], tulusSyams[0,3]);
            return result;
        }
        public static int defineQomar_Syams(int[,] Qomar, int[,] Syams)
        {
            int result;
            if (Qomar[3, 0] > Syams[3, 0])
            {
                result = 1;
            }
            else if (Qomar[3, 0] < Syams[3, 0])
            {
                result = 2;
            }
            else if (Qomar[2, 0] > Syams[2, 0])
            {
                result = 1;
            }
            else if (Qomar[2, 0] < Syams[2, 0])
            {
                result = 2;
            }
            else if (Qomar[1, 0] > Syams[1, 0])
            {
                result = 1;
            }
            else if (Qomar[1, 0] < Syams[1, 0])
            {
                result = 2;
            }
            else if (Qomar[0, 0] > Syams[0, 0])
            {
                result = 1;
            }
            else if (Qomar[0, 0] < Syams[0, 0])
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}

