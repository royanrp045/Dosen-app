using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    class Dosen
    {
        private int ID;
        private string Nama;
        private int Nik;
        private string Gender;
        private string Course;

        public Dosen()
        {
            this.ID = 1;
            this.Nama = "Dosen Pengampu";
            this.Nik = 12345678;
            this.Gender = "Male";
            this.Course = "Pemrograman Berorientasi Objek";
        }

        public void attDosen(string nama, int Nik)
        {
            this.Nama = nama;
            this.Nik = Nik;
        }
        public void addCourse(string nama)
        {
            this.Course += $", {nama}";
        }

        public void display()
        {
            Console.WriteLine($"ID \t: {this.ID}");
            Console.WriteLine($"Nama \t: {this.Nama}");
            Console.WriteLine($"NIK \t: {this.Nik}");
            Console.WriteLine($"Gender \t: {this.Gender}");
            Console.WriteLine($"Course \t: {this.Course}");
        }
    }
}