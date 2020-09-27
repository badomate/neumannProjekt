using System;
using System.Collections.Generic;

namespace raktarProgram.Data.Filters
{
    [Serializable]
    public class HomeFilter
    {
        public List<Tuple<string, string>> Sorrend { get; set; }
        public List<Tuple<string, bool>> MibeKeres { get; set; }
        public string Kereses { get; set; }
        public DateTime? Mikor { get; set; }
        public bool Elotte { get; set; }
        public int Mennyiseg { get; set; }
    }
}