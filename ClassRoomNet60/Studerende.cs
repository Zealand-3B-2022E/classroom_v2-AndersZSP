using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsår;
        private int _fødselsmåned;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public int Fødselsår
        {
            get { return _fødselsår; }
            set { _fødselsår = value; }
        }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set
            {
                _fødselsmåned = value;
            }
        }

        public Studerende(string navn, int fødselsår, int fødselsmåned)
        {
            _navn = navn;
            _fødselsår = fødselsår;
            _fødselsmåned = fødselsmåned;
        }
    }
}
