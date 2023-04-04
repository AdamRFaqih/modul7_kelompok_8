using System;
using System.Text.Json;

namespace Modul7_kelompok_8
{
    internal class DataMahasiswa1302210024
    {
        Mahasiswa mahasiswa = new Mahasiswa();

        String TextFile = File.ReadAllText(@"./jurnal7_1_1302210024.json");

        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(TextFile);
            Console.WriteLine($"Nama {mahasiswa.firstName + " " 
                + mahasiswa.lastName} berkelamin {mahasiswa.gender} berumur {mahasiswa.age} beralamat di {mahasiswa.address.streetAddress + mahasiswa.address.city + mahasiswa.address.state}");
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine($"<{mahasiswa.courses[i].code}> - <{mahasiswa.courses[i].name}>");
            }
        }
    }
}
