using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Modul7_kelompok_8
{
    internal class TeamMembers1302210008
    {
        ListOfMembers listOfMembers { get; set; }
        public TeamMembers1302210008() { }
        public void readJSON()
        {
            string text = File.ReadAllText(@"./jurnal7_2_1302210008.json");
            listOfMembers = JsonSerializer.Deserialize<ListOfMembers>(text);
            Console.WriteLine("Team Member List: ");
            for(int i = 0; i < listOfMembers.members.Count; i++)
            {
                Console.WriteLine($"<{listOfMembers.members[i].nim}><{listOfMembers.members[i].firstName} {listOfMembers.members[i].lastName}> (<{listOfMembers.members[i].age}><{listOfMembers.members[i].gender}>)");
            }
        }
    }
}
