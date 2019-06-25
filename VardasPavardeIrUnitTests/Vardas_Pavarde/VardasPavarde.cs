using System;

namespace VardasPavardeBL

{
    public class VardasPavarde
    {
        public VardasPavarde()
        {

        }

        public VardasPavarde(string vardas, string pavarde, DateTime gimimoMetai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;
        }
        

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime GimimoMetai { get; private set; }
        public int GetAge()
        {
            int age = DateTime.Now.Year - GimimoMetai.Year;

            if (age < 0)
            {
                age = 0;  
            }
          
            return age;
        }
       
    }
}
