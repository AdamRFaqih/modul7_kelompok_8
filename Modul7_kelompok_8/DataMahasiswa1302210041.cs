using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_kelompok_8
{
    public class DataMahasiswa1302210041
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        String jsonString = File.ReadAllText(@"./jurnal7_1_1302210041.Json");

        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {mahasiswa.firstName + " " + mahasiswa.lastName} dengan gender {mahasiswa.gender} " +
                $"dengan umur {mahasiswa.age} ,beralamat {mahasiswa.address.streetAddress + " " + mahasiswa.address.city +
                " " + mahasiswa.address.state}");
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine($"<{mahasiswa.courses[i].code}> - <{mahasiswa.courses[i].name}>");
            }
        }
    }
}
