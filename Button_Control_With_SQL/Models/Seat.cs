using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Control_With_SQL.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public float KuvvetSetDegeri { get; set; }
        public float BosTakiAsagiHizSet { get; set; }
        public float YuktekiHizSet { get; set; }
        public float YukarıHizSet { get; set; }
        public float BasmaYukDegeri { get; set; }
        public float KalkmaYukDegeri { get; set; }

        public int YukeBasmaZamani { get; set; }
        public int TestTekrarSayisi { get; set; }
        public int BostaYukarıKalkma { get; set; }

    }
}
