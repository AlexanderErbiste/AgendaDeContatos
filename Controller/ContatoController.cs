using AgendaDeContatos.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace AgendaDeContatos.Controller
{
    internal class ContatoController
    {
        private static SQLiteConnection SQLiteConnection;

        public ContatoController() { }

        public static SQLiteConnection DbConnection() 
        {
            var sql = @"DataSource=c:\dados\Contato.sqlite; Version=3;";
            SQLiteConnection = new SQLiteConnection(sql);
            SQLiteConnection.Open();
            return SQLiteConnection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"c:\dados\Contato.sqlite");
            }
            catch
            {
                throw;
            }
        }

        public static void CriarTabelaSQLite() 
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    var sql = "CREATE TABLE IF NOT EXISTS Contatos(Id int, Nome varchar(100), Celular varchar(25), Email varchar(75))";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        
        public static DataTable GetContatos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public static DataTable GetContato(int Id)
        {
            SQLiteDataAdapter data = null; 
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos WHERE Id = " + Id;
                    data = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    data.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex) 
            {
                throw ex;
            }
            
        }

        public static void AddContato(Contato contato)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contatos(Id, Nome, Celular, Email) VALUES (@Id, @Nome, @Celular, @Email)";
                    cmd.Parameters.AddWithValue("@Id", contato.Id);
                    cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@Celular", contato.Celular);
                    cmd.Parameters.AddWithValue("@Email", contato.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public static void UpdateContato(Contato contato)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if(contato.Id != null)
                    {
                        cmd.CommandText = "UPDATE Contatos SET Nome= @Nome, Celular= @Celular, Email= @Email WHERE Id= @Id";
                        cmd.Parameters.AddWithValue("@Id", contato.Id);
                        cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                        cmd.Parameters.AddWithValue("@Celular", contato.Celular);
                        cmd.Parameters.AddWithValue("@Email", contato.Email);
                        cmd.ExecuteNonQuery ();
                    }
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public static void DeleteContato(int Id)
        {
            try
            {
                using (var cmd =  new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Contatos WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery ();
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        } 

    }
}
