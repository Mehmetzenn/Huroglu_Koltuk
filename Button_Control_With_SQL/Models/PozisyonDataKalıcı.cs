using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button_Control_With_SQL.Models
{
    public class PozisyonDataKalıcı
    {
        public float PozisyonOne { get; set; }
        public float PozizyonOneSpeed { get; set; }
        public float PozisyonTwo { get; set; }
        public float PozisyonTwoSpeed { get; set; }
        
        public int SetTestSayısı { get; set; }
        
        public int ActualTestSayısı { get; set; }

        public static PozisyonDataKalıcı FromBuffer(byte[] buffer)
        {
            return new PozisyonDataKalıcı
            {
                PozisyonOne = Sharp7.S7.GetRealAt(buffer, 0),
                PozizyonOneSpeed = Sharp7.S7.GetRealAt(buffer, 4),
                PozisyonTwo = Sharp7.S7.GetRealAt(buffer, 8),
                PozisyonTwoSpeed = Sharp7.S7.GetRealAt(buffer, 12),
                SetTestSayısı = Sharp7.S7.GetDIntAt(buffer, 16),
                ActualTestSayısı = Sharp7.S7.GetDIntAt(buffer, 20),
            };
        }

        public byte[] ToBuffer()
        {
            byte[] buffer = new byte[24];

            Sharp7.S7.SetRealAt(buffer, 0, PozisyonOne);
            Sharp7.S7.SetRealAt(buffer, 4, PozizyonOneSpeed);
            Sharp7.S7.SetRealAt(buffer, 8, PozisyonTwo);
            Sharp7.S7.SetRealAt(buffer, 12, PozisyonTwoSpeed);
            Sharp7.S7.SetRealAt(buffer, 16, SetTestSayısı);
            Sharp7.S7.SetRealAt(buffer, 20, ActualTestSayısı);
            return buffer;
        }

    }
}
