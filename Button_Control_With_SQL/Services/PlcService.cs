using Button_Control_With_SQL.Models;
using Sharp7;
using System;

public class PlcService
{
    private S7Client plc;
    private const int DB8 = 8;
    private const int DB2 = 2;
    private const int DB = 11;

    public bool Connect(string ip, int rack = 0, int slot = 1)
    {
        try
        {
            plc = new S7Client();
            int result = plc.ConnectTo(ip, rack, slot);
            return result == 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bağlantı hatası: " + ex.Message);
            return false;
        }
    }

    public void Disconnect()
    {
        if (plc != null && plc.Connected)
        {
            plc.Disconnect();
        }
    }

    public bool IsConnected()
    {
        return plc != null && plc.Connected;
    }

    public DataGecici ReadDataGecici()
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = new byte[14];
        int result = plc.DBRead(DB8, 0, buffer.Length, buffer);

        if (result == 0)
            return DataGecici.FromBuffer(buffer);
        else
            throw new Exception($"DB8 Read Error: {plc.ErrorText(result)}");
    }

    public void WriteDataGecici(DataGecici data)
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = data.ToBuffer();
        int result = plc.DBWrite(DB8, 0, buffer.Length, buffer);

        if (result != 0)
            throw new Exception($"DB8 Write Error: {plc.ErrorText(result)}");
    }

    public DataKalici ReadDataKalici()
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = new byte[60];
        int result = plc.DBRead(DB2, 0, buffer.Length, buffer);

        if (result == 0)
            return DataKalici.FromBuffer(buffer);
        else
            throw new Exception($"DB2 Read Error: {plc.ErrorText(result)}");
    }

    public void WriteDataKalici(DataKalici data)
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = data.ToBuffer();
        int result = plc.DBWrite(DB2, 0, buffer.Length, buffer);

        if (result != 0)
            throw new Exception($"DB2 Write Error: {plc.ErrorText(result)}");
    }
    public PozisyonDataKalıcı ReadPozisyonData()
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = new byte[24]; // PozisyonDataKalıcı aktif olarak 24 byte kullanıyor
        int result = plc.DBRead(DB, 0, buffer.Length, buffer);

        if (result == 0)
            return PozisyonDataKalıcı.FromBuffer(buffer);
        else
            throw new Exception($"DB11 Read Error: {plc.ErrorText(result)}");
    }
    public void WritePozisyonData(PozisyonDataKalıcı data)
    {
        if (!IsConnected())
            throw new InvalidOperationException("PLC bağlı değil.");

        byte[] buffer = data.ToBuffer(); // Bu 60 byte döndürüyor, ama 24 byte yeterli
        int result = plc.DBWrite(DB, 0, 24, buffer); // Sadece 24 byte yaz

        if (result != 0)
            throw new Exception($"DB11 Write Error: {plc.ErrorText(result)}");
    }

}
