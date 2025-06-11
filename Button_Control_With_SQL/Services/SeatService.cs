using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Button_Control_With_SQL.Models;

namespace Button_Control_With_SQL.Services
{
    public class SeatService
    {
        private readonly string _connectionString;

        public SeatService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Seat> GetAllSeats()
        {
            var seats = new List<Seat>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = "SELECT * FROM Seat";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        seats.Add(new Seat
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            KuvvetSetDegeri = Convert.ToSingle(reader["KuvvetSetDegeri"]),
                            BosTakiAsagiHizSet = Convert.ToSingle(reader["BosTakiAsagiHizSet"]),
                            YuktekiHizSet = Convert.ToSingle(reader["YuktekiHizSet"]),
                            YukarıHizSet = Convert.ToSingle(reader["YukarıHizSet"]),
                            BasmaYukDegeri = Convert.ToSingle(reader["BasmaYukDegeri"]),
                            KalkmaYukDegeri = Convert.ToSingle(reader["KalkmaYukDegeri"]),
                            YukeBasmaZamani = Convert.ToInt32(reader["YukeBasmaZamani"]),
                            TestTekrarSayisi = Convert.ToInt32(reader["TestTekrarSayisi"]),
                            BostaYukarıKalkma = Convert.ToInt32(reader["BostaYukarıKalkma"])
                        });
                    }
                }
            }

            return seats;
        }

        public void AddSeat(Seat seat)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                const string query = @"INSERT INTO Seat 
                    (Name, KuvvetSetDegeri, BosTakiAsagiHizSet, YuktekiHizSet, YukarıHizSet,
                     BasmaYukDegeri, KalkmaYukDegeri, YukeBasmaZamani, TestTekrarSayisi, BostaYukarıKalkma)
                    VALUES (@Name, @KuvvetSetDegeri, @BosTakiAsagiHizSet, @YuktekiHizSet, @YukarıHizSet,
                            @BasmaYukDegeri, @KalkmaYukDegeri, @YukeBasmaZamani, @TestTekrarSayisi, @BostaYukarıKalkma)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    BindParameters(command, seat);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSeat(Seat seat)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                const string query = @"UPDATE Seat SET
                    Name = @Name,
                    KuvvetSetDegeri = @KuvvetSetDegeri,
                    BosTakiAsagiHizSet = @BosTakiAsagiHizSet,
                    YuktekiHizSet = @YuktekiHizSet,
                    YukarıHizSet = @YukarıHizSet,
                    BasmaYukDegeri = @BasmaYukDegeri,
                    KalkmaYukDegeri = @KalkmaYukDegeri,
                    YukeBasmaZamani = @YukeBasmaZamani,
                    TestTekrarSayisi = @TestTekrarSayisi,
                    BostaYukarıKalkma = @BostaYukarıKalkma
                    WHERE Id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    BindParameters(command, seat);
                    command.Parameters.AddWithValue("@Id", seat.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSeat(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                const string query = "DELETE FROM Seat WHERE Id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void BindParameters(SQLiteCommand command, Seat seat)
        {
            command.Parameters.AddWithValue("@Name", seat.Name);
            command.Parameters.AddWithValue("@KuvvetSetDegeri", seat.KuvvetSetDegeri);
            command.Parameters.AddWithValue("@BosTakiAsagiHizSet", seat.BosTakiAsagiHizSet);
            command.Parameters.AddWithValue("@YuktekiHizSet", seat.YuktekiHizSet);
            command.Parameters.AddWithValue("@YukarıHizSet", seat.YukarıHizSet);
            command.Parameters.AddWithValue("@BasmaYukDegeri", seat.BasmaYukDegeri);
            command.Parameters.AddWithValue("@KalkmaYukDegeri", seat.KalkmaYukDegeri);
            command.Parameters.AddWithValue("@YukeBasmaZamani", seat.YukeBasmaZamani);
            command.Parameters.AddWithValue("@TestTekrarSayisi", seat.TestTekrarSayisi);
            command.Parameters.AddWithValue("@BostaYukarıKalkma", seat.BostaYukarıKalkma);
        }
    }
}
