using System.Data;
using System.Data.SqlClient;
namespace Entidades
{
    public delegate void EnviarMensaje(Mensaje mensaje);
    public static class GestorDataBase
    {
        public static event EnviarMensaje OnMensaje;
        private static string stringConnection;
        private static CancellationTokenSource cancellationTokenSource;
        private static int cantidad;
        private static Task tarea;


        static GestorDataBase()
        {
            GestorDataBase.cantidad = 1;
            GestorDataBase.stringConnection = "Server=.;Database=mydatabase;Trusted_Connection=True;";
        }

        public static bool IniciarLectura
        {
            get
            {
                return GestorDataBase.tarea is not null &&
                    (GestorDataBase.tarea.Status == TaskStatus.Running ||
                    GestorDataBase.tarea.Status == TaskStatus.WaitingToRun ||
                    GestorDataBase.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !GestorDataBase.IniciarLectura)
                {
                    GestorDataBase.cancellationTokenSource = new CancellationTokenSource();
                    GestorDataBase.Iniciar();
                }
                else
                {
                    GestorDataBase.cancellationTokenSource.Cancel();
                }
            }
        }

        public static void Iniciar()
        {
            
            CancellationToken token = GestorDataBase.cancellationTokenSource.Token;
            GestorDataBase.tarea = Task.Run(() =>
            {
                do
                {
                    Mensaje msj;
                    try
                    {
                        msj = GestorDataBase.LeerDeLaBd(GestorDataBase.cantidad);
                    }
                    catch(Exception ex)
                    {
                        msj = null;
                    }


                    if(msj is not null)
                    {
                        if(GestorDataBase.OnMensaje is not null)
                        {
                            GestorDataBase.OnMensaje(msj);
                            GestorDataBase.cantidad++;
                        }
                    }

                    Thread.Sleep(1000);
                } while (!GestorDataBase.cancellationTokenSource.IsCancellationRequested);

            });

        }


        private static Mensaje LeerDeLaBd(int id)
        {
            string query = "SELECT * FROM mensajes WHERE id =@id";
            using (SqlConnection connection = new SqlConnection(GestorDataBase.stringConnection))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Mensaje msj = new Mensaje(reader.GetInt32(0), reader.GetString(1));
                    return msj;
                }
                throw new Exception("No exite el mensaje con ese Id");
            }
        }


    }
}