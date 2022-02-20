using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_LP3
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Hacemos la conexion con la base de datos, en este caso la base de datos escogida y utilizada es Sql Server. Para conectarnos
        //le proporcionamos la cadena de conexión.
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        //Método que al clickear sobre el botón "Iniciar Sesión" obtiene lo introducido por el usuario a través del textbox y verifica si estos
        //datos coinciden con los datos que se encuentran dentro de la tabla Users de la base de datos. Dicha tabla contiene 3 columnas, las 
        //cuales son: Usuario, Contrasena y tipoUsuario.
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("SELECT Usuario,Contrasena,tipoUs FROM Users WHERE Usuario = @usuario AND Contrasena = @contrasena", connection);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
            SqlDataAdapter sda = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Si hay registros dentro de la tabla Users, se da inicio a la sesión
            if (dt.Rows.Count == 1)
            {
                connection.Close();

                //A traves de esta linea al cargar la pagina, se hace visible el nombre del usuario el cual inicio sesión
                Session["usuariologueado"] = txtUsuario.Text;

                //Si el usuario es ALUMNO, se le redirige a la venta CargaPuntos-VistaALUMNOS 
                if (dt.Rows[0][2].ToString() == "ALUMNO")
                {
                    Response.Redirect("CargaPuntos-VistaALUMNOS.aspx");
                }
                //Si el usuario es ADMINISTRADOR, se le redirige a la venta CargaPuntos-VistaADM
                else
                {
                    if (dt.Rows[0][2].ToString() == "ADMINISTRADOR")
                    {
                        Response.Redirect("CargaPuntos-VistaADM.aspx");
                    }
                }
            }
            else
            {
                //Envia un mensaje de error, en el caso de que no se haya podido iniciar la sesión ya sea por:
                //Error de nombre de usuario, contraseña o en el caso que el usuario introducido no se haya sido registrado
                labelMensajeError.Text = "Error de Usuario o Contraseña";
            }
        }

        //Al clickear sobre el botón Registro, éste me redirige a la ventana Registro
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

    }
}