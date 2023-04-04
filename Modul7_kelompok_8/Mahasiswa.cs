using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_kelompok_8
{
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address { get; set; }
        public List<Courses> courses { get; set; }
        public Mahasiswa() { }
    }
}
