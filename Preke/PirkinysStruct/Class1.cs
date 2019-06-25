using System;

namespace PrekeStruct
{
    public struct Preke

    {
    
        public string _pavadinimas;
        public decimal _kiekis;
        public decimal _kainaVieneto;


        public string Pavadinimas
        {
            get
            {
                return _pavadinimas;
            }
            private set
            {
                _pavadinimas = value;
            }
        }

        public decimal Kiekis
        {
            get
            {
                return _kiekis;
            }
            private set
            {
                _kiekis = value;
            }
        }
        public decimal KainaVieneto
        {
            get
            {
                return _kainaVieneto;
            }
            private set
            {
                _kainaVieneto = value;
            }
        }
        public decimal KainaViso
        {
            get
            {
                return (_kiekis * _kainaVieneto);

            }
        }
        public Preke(string pavadinimas, decimal kiekis, decimal kainaVieneto)
        {
            _pavadinimas = pavadinimas;
            _kiekis = kiekis;
            _kainaVieneto = kainaVieneto;
        }


        public string GetPavadinimas()
        {
            return _pavadinimas;
        }

        public decimal GetKiekis()
        {
            return _kiekis;
        }


    }
}