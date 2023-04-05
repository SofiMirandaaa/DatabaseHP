using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHP
{
    public class Database
    {
        public void Handphone()
        {
            string[] kd_barang = new string[12];
            string[] nm_barang = new string[50];
            string[] kd_active = new string[2];
            string[] hrg_jual = new string[2];
            string[] hrg_beli = new string[2];

            int a, b = 0;

            Console.WriteLine("------------------------------");
            Console.WriteLine("||        INPUT DATA        ||");
            Console.WriteLine("------------------------------");
            Console.Write("Jumlah Handphone = ");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (a = 1; a <= b; a++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Masukkan Data Handphone" + a);
                Console.WriteLine("-------------------------");
                Console.Write("\n");

                Console.Write("Masukkan Kode Brg           = ");
                kd_barang[a] = Console.ReadLine();
                Console.Write("Masukkan Nama Brg           = ");
                nm_barang[a] = Console.ReadLine();
                Console.Write("Masukkan Kode Active        = ");
                kd_active[a] = Console.ReadLine();
                Console.Write("Masukkan Hrg Beli           = ");
                hrg_beli[a] = Console.ReadLine();
                Console.Write("Masukkan Hrg Jual           = ");
                hrg_jual[a] = Console.ReadLine();
            }
            Console.WriteLine("ENTER TO CONTINUE...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("|                                  DATA HP                                    |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(" No. --  Kode Brg  --   Nama   --  Kode Active  --    Hrg Beli    --   Hrg Jual");
            Console.WriteLine("-------------------------------------------------------------------------------");

            for (a = 1; a <= b; a++)
            {
                Console.WriteLine(" " + a + ".\t" + kd_barang[a] + "\t  " + nm_barang[a] + "\t     " + kd_active[a] + "\t\t" + hrg_beli[a] + "\t\t" +
                                hrg_jual[a]);
            }
            Console.WriteLine();
            Console.Write("ENTER To Exit...");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Database data = new Database();
            data.Handphone();
        }
    }
}