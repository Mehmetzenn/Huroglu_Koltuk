public class DataKalici
{
    public float ActualPozisyon { get; set; } 
    public float MaxPozisyon { get; set; }
    public float MinPozisyon { get; set; }
    public float KuvvetSetDegeri { get; set; }
    public float MaxKuvvet { get; set; }
    public float BosTakiAsagiHizSet { get; set; }
    public float YuktekiHizSet { get; set; }
    public float YukarıHizSet { get; set; }
    public float ManHizSet { get; set; }
    public float BasmaYukDegeri { get; set; }
    public float KalkmaYukDegeri { get; set; }

    public int YukeBasmaZamani { get; set; }
    public int TestTekrarSayisi { get; set; }
    public int BostaYukarıKalkma { get; set; }
    public float KuvvetKalibrasyonCarpani { get; set; }

    public static DataKalici FromBuffer(byte[] buffer)
    {
        return new DataKalici
        {
            ActualPozisyon = Sharp7.S7.GetRealAt(buffer, 0),
            MaxPozisyon = Sharp7.S7.GetRealAt(buffer, 4),
            MinPozisyon = Sharp7.S7.GetRealAt(buffer, 8),
            KuvvetSetDegeri = Sharp7.S7.GetRealAt(buffer, 12),
            MaxKuvvet = Sharp7.S7.GetRealAt(buffer, 16),
            BosTakiAsagiHizSet = Sharp7.S7.GetRealAt(buffer, 20),
            YuktekiHizSet = Sharp7.S7.GetRealAt(buffer, 24),
            YukarıHizSet = Sharp7.S7.GetRealAt(buffer, 28),
            ManHizSet = Sharp7.S7.GetRealAt(buffer, 32),
            BasmaYukDegeri = Sharp7.S7.GetRealAt(buffer, 36),
            KalkmaYukDegeri = Sharp7.S7.GetRealAt(buffer, 40),
            TestTekrarSayisi = Sharp7.S7.GetDIntAt(buffer, 44),
            YukeBasmaZamani = Sharp7.S7.GetDIntAt(buffer, 48),
            BostaYukarıKalkma = Sharp7.S7.GetDIntAt(buffer, 52),
            KuvvetKalibrasyonCarpani = Sharp7.S7.GetRealAt(buffer, 56)
        };
    }

    public byte[] ToBuffer()
    {
        byte[] buffer = new byte[60];

        Sharp7.S7.SetRealAt(buffer, 0, ActualPozisyon);
        Sharp7.S7.SetRealAt(buffer, 4, MaxPozisyon);
        Sharp7.S7.SetRealAt(buffer, 8, MinPozisyon);
        Sharp7.S7.SetRealAt(buffer, 12, KuvvetSetDegeri);
        Sharp7.S7.SetRealAt(buffer, 16, MaxKuvvet);
        Sharp7.S7.SetRealAt(buffer, 20, BosTakiAsagiHizSet);
        Sharp7.S7.SetRealAt(buffer, 24, YuktekiHizSet);
        Sharp7.S7.SetRealAt(buffer, 28, YukarıHizSet);
        Sharp7.S7.SetRealAt(buffer, 32, ManHizSet);
        Sharp7.S7.SetRealAt(buffer, 36, BasmaYukDegeri);
        Sharp7.S7.SetRealAt(buffer, 40, KalkmaYukDegeri);
        Sharp7.S7.SetDIntAt(buffer, 44, TestTekrarSayisi);
        Sharp7.S7.SetDIntAt(buffer, 48, YukeBasmaZamani);
        Sharp7.S7.SetDIntAt(buffer, 52, BostaYukarıKalkma);
        Sharp7.S7.SetRealAt(buffer, 56, KuvvetKalibrasyonCarpani);

        return buffer;
    }
}
