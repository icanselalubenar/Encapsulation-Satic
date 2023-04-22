using System;
namespace Encapsulation
{
    internal class Mahasiswa
    {
        public static int jumlahMahasiswa = 0;
        public string nama;
        public string nim;
        public int umur;

        public Mahasiswa(string a, string b, int c)
        {
            this.nama = a;
            this.nim = b;
            this.umur = c;
            jumlahMahasiswa++;
        }

        public static int totalMhs
        {
            get { return jumlahMahasiswa; }
            set { jumlahMahasiswa = value; }
        }
        public string namaMhs
        {
            get { return nama; }
            set { nama = value; }
        }
        public string nimMhs
        {
            get { return nim; }
            set { nim = value; }
        }
        public int umurMhs
        {
            get { return umur; }
            set { umur = value; }
        }
    }
}

