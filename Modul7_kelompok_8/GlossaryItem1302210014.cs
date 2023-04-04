using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_kelompok_8
{
    public class GlossaryItem1302210014
    {
        GlossaryClass gloss = new GlossaryClass();

        string jsonString = File.ReadAllText(@"./jurnal7_3_1302210014.json");

        public void readJSON()
        {
            gloss = JsonSerializer.Deserialize<GlossaryClass>(jsonString);
            Console.WriteLine("Title: " + gloss.glossary.title);
            Console.WriteLine("GlossDiv: ");
            Console.WriteLine("Title: " + gloss.glossary.GlossDiv.title);
            Console.WriteLine("GlossList: ");
            Console.WriteLine("GlossEntry: ");
            Console.WriteLine("ID: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossTerm: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef: ");
            Console.WriteLine("Para: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            for (int i = 0; i < gloss.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso.Count; i++)
            {
                Console.WriteLine("See Also: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[i]);
                
            }
            Console.WriteLine("See: " + gloss.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);


        }
    }
}
