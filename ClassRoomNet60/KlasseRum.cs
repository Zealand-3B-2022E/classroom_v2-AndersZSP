using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class KlasseRum
    {
        private string _klasseNavn;
        private List<Studerende> _klasseListe;
        private DateTime _semesterStart;



        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }
        public List<Studerende> KlasseListe
        {
            get { return _klasseListe; }
            set { _klasseListe = value; }
        }
        public DateTime SemesterStart 
        { 
            get { return _semesterStart; }
            set { _semesterStart = value; } 
        }

        public KlasseRum()
        {

        }
        public override string ToString()
        {
            return $"Klasse Navn = {KlasseNavn}, Klasse Liste = {KlasseListe}, Semester start = {SemesterStart}";
        }
    }
}
