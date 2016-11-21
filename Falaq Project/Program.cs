using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Falaq_Project
{
    class Program
    {
        static void Main(string[] args)
    {

            Console.Write("Tahun yang di Garap : ");
            int inputTahun = int.Parse(Console.ReadLine());
            Console.Write("Bulan Yang di Garap : ");
            int inputSyahr = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Ayyam : ");
            int inputayyam = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Saah : ");
            int inputsaah = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Daqiqoh : ");
            int inputdaqiqoh = int.Parse(Console.ReadLine());

            int[,] alwastu = Execute.alwastu(inputTahun, inputSyahr, inputayyam);
            int[,] AlwastuBadalghurub = Execute.alwastuBadalGhurub(alwastu, inputsaah, inputdaqiqoh);
            int[,] alhaqiqi = Execute.alhaqiqi(AlwastuBadalghurub);
            int alhaqiqidarojah = alhaqiqi[1, 2];
            int alhaqiqiburuj = alhaqiqi[1, 3];
            int[,] takdilSyams = Execute.takdilSyam(alhaqiqi);
            int[,] tulusSyams = Execute.TulusSyams(alhaqiqi, takdilSyams);
            int[,] TakdilAwal = Execute.TakdilAwal(alhaqiqi, alhaqiqidarojah);
            int[,] MuaddalAwal = Execute.MuaddalAwal(alhaqiqi, TakdilAwal);
            int[,] DalilSani = Execute.DalilSani(alhaqiqi, tulusSyams);
            int[,] TakdilSani = Execute.TakdilSani(DalilSani, alhaqiqi);
            int[,] muaddalSani = Execute.muaddalSani(alhaqiqi, MuaddalAwal, TakdilSani);
            int[,] adalatulUla = Execute.adalatulUla(alhaqiqi, TakdilAwal);
            int[,] adalatussani = Execute.adalatussani(DalilSani[0, 3], adalatulUla, TakdilSani);
            int[,] takdilKhosoh = Execute.takdilKhosoh(alhaqiqi, alhaqiqidarojah, alhaqiqiburuj);
            int[,] dalilSalis = Execute.dalilSalis(alhaqiqiburuj, adalatussani, takdilKhosoh);
            int[,] TakdilSalis = Execute.TakdilSalis(dalilSalis);
            int[,] muaddalsalis = Execute.muaddalsalis(dalilSalis[0, 3], muaddalSani, TakdilSalis);
            int[,] dalilrobi = Execute.dalilRobi(muaddalsalis, tulusSyams);
            int[,] takdilRobi = Execute.TakdilRobi(dalilrobi);
            int[,] muaddalRobi = Execute.muaddalrobi(takdilRobi[0, 3], muaddalsalis, takdilRobi);
            int[,] Takdiluqdah = Execute.Takdiluqdah(alhaqiqi, alhaqiqidarojah, alhaqiqiburuj);
            int[,] mushohah = Execute.mushohah(alhaqiqiburuj, alhaqiqi, Takdiluqdah);
            int[,] dalilkhomis = Execute.dalilkhomis(mushohah, muaddalRobi);
            int[,] takdilKhomis = Execute.takdilkhomis(dalilkhomis);
            int[,] tululQomar = Execute.TululQomar(dalilkhomis[0, 3], muaddalRobi, takdilKhomis);

            int[,] bukdulMutlaq = Execute.BukdulMutlaq(tululQomar, tulusSyams);
            Console.ReadLine();
        }
    }
}
