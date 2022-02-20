using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_LP3
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*Hacemos la conexion con la base de datos, en este caso la base de datos escogida y utilizada es Sql Server. Para conectarnos
        le proporcionamos la cadena de conexión.*/
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        /*Método que al clickear sobre el botón "Enviar Registro", envia los datos necesarios para registrar a dicho usuario.
        Datos como: Nombre de Usuario, Contraseña y tipo de usuario. Éstos datos son introducidos a través de los textboxs
        y son insertados a la tabla Users, para posteriormente poder dar inicio de sesión con el usuario y contraseña crados.*/ 
        protected void btnEnviarRegistro_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasenaUsuario = txtContrasenaUsuario.Text;
            string tipoUsuario = rbtnAlumno.Text;

            connection.Open();
            SqlCommand comand = new SqlCommand("Insert into Users values ('" + nombreUsuario + "','" + contrasenaUsuario + "','" + tipoUsuario + "')", connection);
            comand.ExecuteNonQuery();
            connection.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Guardado con éxito!');", true);

            limpiar();
        }

        /*Método que una vez enviado los datos para el registro de usuario, limpia los campos de los textboxs:
        Nombre de Usuario y Contraseña*/
        void limpiar()
        {
            txtNombreUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
        }

        //Al clickear sobre el botón "Iniciar Sesión", éste me redirige a la ventana de InicioSesion
        protected void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }
    }
}