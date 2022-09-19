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
        private string _årstid;

        enum Årstider
        {
            Vinter,
            Forår,
            Sommer,
            Efterår
        }

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
                CheckMonth(value);
                _fødselsmåned = value;
            }
        }
        public string Årstid
        {
            get { return _årstid; }
            set { _årstid = value; }
        }

        public Studerende(string navn, int fødselsår, int fødselsmåned)
        {
            if(fødselsmåned < 1 || fødselsmåned > 12)
            {
                throw new ArgumentOutOfRangeException("Ugyldig fødselsmåned");
            }
            _navn = navn;
            _fødselsår = fødselsår;
            _fødselsmåned = fødselsmåned;
        }

        public string Aarstid(int fødselsmåned)
        {
            if(fødselsmåned == 12 || fødselsmåned == 1 || fødselsmåned == 2)
            {
                string my_årstid = $"{Årstider.Vinter}";
                return my_årstid;
            }
            else if(fødselsmåned == 3 || fødselsmåned == 4|| fødselsmåned == 5)
            {
                string my_årstid = $"{Årstider.Forår}";
                return my_årstid;
            }
            else if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                string my_årstid = $"{Årstider.Sommer}";
                return my_årstid;
            }
            else if (fødselsmåned == 9 || fødselsmåned == 10 || fødselsmåned == 11)
            {
                string my_årstid = $"{Årstider.Efterår}";
                return my_årstid;
            }
            else
            {
                return null;
            }
        }

        private void CheckMonth(int fødselsmåned)
        {
            if(fødselsmåned > 12 || fødselsmåned < 1)
            {
                throw new ArgumentException(message:"Fødselsmåned skal være mellem 1 og 12");
            }
        }

        public override string ToString()
        {
            return $"Navn = {Navn}, Fødselsmåned = {Fødselsmåned}, Fødsels År = {Fødselsår}, Årstid = {Aarstid(Fødselsmåned)}";
        }
    }
}
