using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_kelompok_8
{
    public class DataMahasiswa1302210014
    {
        Mahasiswa mahasiswa = new Mahasiswa();

        String jsonString = File.ReadAllText(@"./jurnal7_1_1302210014.json");

        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {mahasiswa.firstName + " " + mahasiswa.lastName} seorang {mahasiswa.gender} berumur {mahasiswa.age} dari {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {mahasiswa.courses[i].code} - {mahasiswa.courses[i].name}");
            }
        }
    }
}
