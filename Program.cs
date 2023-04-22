using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa01 = new Mahasiswa("Ikhsan", "22.11.4824", 18);
            Mahasiswa mahasiswa02 = new Mahasiswa("Iqbal", "22.11.4850", 20);
            Mahasiswa mahasiswa03 = new Mahasiswa("Naji", "22.11.4818", 19);

            int totalMahasiswa = Mahasiswa.totalMhs;

            Console.WriteLine("Total Mahasiwa : {0}", totalMahasiswa);
            Console.WriteLine("+-----------------------------------------------------------------+");

            Console.WriteLine("Mahasiswa 1 : {0} dengan nim {1}, berusia {2} tahun.", mahasiswa01.namaMhs, mahasiswa01.nimMhs, mahasiswa01.umurMhs);
            Console.WriteLine("Mahasiswa 2 : {0} dengan nim {1}, berusia {2} tahun.", mahasiswa02.namaMhs, mahasiswa02.nimMhs, mahasiswa02.umurMhs);
            Console.WriteLine("Mahasiswa 3 : {0} dengan nim {1}, berusia {2} tahun.", mahasiswa03.namaMhs, mahasiswa03.nimMhs, mahasiswa03.umurMhs);

            Console.ReadKey();
        }
    }
}