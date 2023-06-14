using System.Data.SqlClient;

namespace Entidades
{
    public static class GestorDataBase
    {
        private static string stringConnection;
        private static CancellationTokenSource cancellationTokenSource;


        static GestorDataBase()
        {
            GestorDataBase.stringConnection = "Server=.;Database=mydatabase;Trusted_Connection=True;";
        }


        public static Task IniciarLectura(Action<Persona> delegado)
        {
            int numero = 1;
            GestorDataBase.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = GestorDataBase.cancellationTokenSource.Token;
            return Task.Run(() =>
            {
                do
                {
                    delegado(LeerDeLaBd(numero));
                    numero++;
                    Thread.Sleep(1000);

                } while (numero <= 51 && !GestorDataBase.cancellationTokenSource.IsCancellationRequested);

            });

        }


        private static Persona LeerDeLaBd(int id)
        {
            string query = "SELECT * FROM usuarios WHERE idUduario =@id";
            using (SqlConnection connection = new SqlConnection(GestorDataBase.stringConnection))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Persona() { Nombre = reader.GetString(1), Apellido = reader.GetString(2) };
                }
                throw new Exception("No exite el usuario con ese Id");
            }
        }


    }
}