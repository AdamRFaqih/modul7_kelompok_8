using Modul7_kelompok_8;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210014 dataIsa = new DataMahasiswa1302210014();
        dataIsa.readJSON();

        DataMahasiswa1302210008 adam = new DataMahasiswa1302210008();
        adam.readJSON();

        DataMahasiswa1302210101 max = new DataMahasiswa1302210101();
        max.readJSON();
        
        DataMahasiswa1302210041 data = new DataMahasiswa1302210041();
        data.readJSON();
        
        DataMahasiswa1302210024 habli = new DataMahasiswa1302210024();
        habli.readJSON();
        
        TeamMembers1302210008 tim = new TeamMembers1302210008();
        tim.readJSON();
        
        GlossaryItem1302210014 glossaryIsa = new GlossaryItem1302210014();
        glossaryIsa.readJSON();
    }
}