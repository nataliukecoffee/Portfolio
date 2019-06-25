using System;

namespace BibliotekosKnygaStruct
{
    public class BibliotekosKnyga
    {

        public int Id { get; private set; }
        public string Pavadinimas { get; private set; }
        public int PerKiekDienuGrazinti { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime _paemimoData { get; set; }


        public BibliotekosKnyga(int id, string pavadinimas,
            int perKiekDienuGrazinti,
            string skaitytojoVardas,
            DateTime paemimoData)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            PerKiekDienuGrazinti = perKiekDienuGrazinti;
            SkaitytojoVardas = skaitytojoVardas;
            _paemimoData = paemimoData;
        }

        public bool PavelavoGrazintiKnyga()
        {
            
            var pavelavoGrazinti = true;
            var perKiekDienuGrazino = (DateTime.Now.Day - _paemimoData.Day); 

            if (perKiekDienuGrazino < perKiekDienuGrazino)
            {
                pavelavoGrazinti = true;
            }
            else
            {
                pavelavoGrazinti = false;
            }
            return pavelavoGrazinti;
        }

        public bool Save()
        {
            return true;
        }

    }
}
