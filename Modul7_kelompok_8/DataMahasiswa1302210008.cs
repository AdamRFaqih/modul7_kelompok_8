using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Modul7_kelompok_8
{
    public class DataMahasiswa1302210008
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        public DataMahasiswa1302210008() { }
        string text = File.ReadAllText(@"./jurnal7_1_1302210008.json");
        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);
            Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Jenis Kelamin: {mahasiswa.gender}");
            Console.WriteLine($"Umur: {mahasiswa.age}");
            Console.WriteLine($"Alamat: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
            for(int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine($"<{mahasiswa.courses[i].code}> - <{mahasiswa.courses[i].name}>");
            }
        }

    }
}
