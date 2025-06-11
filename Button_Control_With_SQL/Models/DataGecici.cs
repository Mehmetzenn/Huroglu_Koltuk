public class DataGecici
{
    public bool HomeButton { get; set; }
    public bool AsagiButton { get; set; }
    public bool YukariButton { get; set; }
    public bool StartButton { get; set; }
    public bool StopButton { get; set; }
    public bool AcilStopButton { get; set; }
    public float ActualKuvvet { get; set; }
    public int TestAdimSayisi { get; set; }
    public int ActualTestSayisi { get; set; } 
    public bool TestDevamEdiyor { get; set; }
    

    public static DataGecici FromBuffer(byte[] buffer)
    {
        return new DataGecici
        {
            HomeButton = Sharp7.S7.GetBitAt(buffer, 0, 0),        // DBX0.0
            AsagiButton = Sharp7.S7.GetBitAt(buffer, 0, 1),       // DBX0.1
            YukariButton = Sharp7.S7.GetBitAt(buffer, 0, 2),      // DBX0.2
            StartButton = Sharp7.S7.GetBitAt(buffer, 0, 3),       // DBX0.3
            StopButton = Sharp7.S7.GetBitAt(buffer, 0, 4),        // DBX0.4
            AcilStopButton = Sharp7.S7.GetBitAt(buffer, 0, 5),    // DBX0.5
            ActualKuvvet = Sharp7.S7.GetRealAt(buffer, 2),        // DBD2 
            TestAdimSayisi = Sharp7.S7.GetDIntAt(buffer, 6),       // DBD6 
            ActualTestSayisi = Sharp7.S7.GetDIntAt(buffer, 8),
            TestDevamEdiyor = Sharp7.S7.GetBitAt(buffer, 12,0),// DBD10
        };
    }

    public byte[] ToBuffer()
    {
        byte[] buffer = new byte[14]; 

        Sharp7.S7.SetBitAt(ref buffer, 0, 0, HomeButton);
        Sharp7.S7.SetBitAt(ref buffer, 0, 1, AsagiButton);
        Sharp7.S7.SetBitAt(ref buffer, 0, 2, YukariButton);
        Sharp7.S7.SetBitAt(ref buffer, 0, 3, StartButton);
        Sharp7.S7.SetBitAt(ref buffer, 0, 4, StopButton);
        Sharp7.S7.SetBitAt(ref buffer, 0, 5, AcilStopButton);

        Sharp7.S7.SetRealAt(buffer, 2, ActualKuvvet);
        Sharp7.S7.SetDIntAt(buffer, 6, TestAdimSayisi);

        Sharp7.S7.SetDIntAt(buffer, 8, ActualTestSayisi);
        Sharp7.S7.SetBitAt(ref buffer, 12, 0, TestDevamEdiyor);

        return buffer;
    }
}
