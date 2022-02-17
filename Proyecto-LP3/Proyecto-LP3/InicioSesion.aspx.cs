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

        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("SELECT Usuario,Contrasena,tipoUs FROM Users WHERE Usuario = @usuario AND Contrasena = @contrasena", connection);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
            SqlDataAdapter sda = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Si hay registros dentro de la tabla, se da inicio a la sesion
            if (dt.Rows.Count == 1)
            {
                connection.Close();
                //A traves de esta linea al cargar la pagina, se hace visible el nombre del usuario el cual accedio
                Session["usuariologueado"] = txtUsuario.Text;

                //Response.Redirect("CargaPuntos-VistaALUMNOS.aspx");

                if (dt.Rows[0][2].ToString() == "ALUMNO")
                {
                    Response.Redirect("CargaPuntos-VistaALUMNOS.aspx");
                }
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
                //Envia un mensaje de error, no se pudo iniciar la sesion
                labelMensajeError.Text = "Error de Usuario o Contraseña";
            }

            /*
            if (dt.Rows.Count == 1)
            {
                connection.Close();
                //A traves de esta linea al cargar la pagina, se hace visible el nombre del usuario el cual accedio
                Session["usuariologueado"] = txtUser.Text;

                Response.Redirect("CargaPuntos-VistaALUMNOS.aspx");
            }
            else
            {
                lblError.Text = "Error de Usuario o Contraseña";
            }
            */
        }

        
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
        
    }
}