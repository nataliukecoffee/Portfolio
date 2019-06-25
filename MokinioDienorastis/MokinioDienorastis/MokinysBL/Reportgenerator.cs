using System;
using System.Collections.Generic;
using System.Text;

namespace MokinysBL
{
    public class ReportGenerator
    {
        private MokinioRepository _mokinioRepository;

        public ReportGenerator(MokinioRepository mokinioRepository)
        {
            _mokinioRepository = mokinioRepository;
        }


        public string GeneruotiMokiniuAtaskaita()
        {
            string result = "";
            List<Mokinys> visiMokiniai = _mokinioRepository.Retrieve();

            foreach (var mokiniaiPoViena in visiMokiniai)
            {
                result = result + string.Format("ID:{0}, Vardas {1}, {2}", mokiniaiPoViena.Id, mokiniaiPoViena.Vardas, Environment.NewLine);

            }
            return result;
        } 
    }
}
