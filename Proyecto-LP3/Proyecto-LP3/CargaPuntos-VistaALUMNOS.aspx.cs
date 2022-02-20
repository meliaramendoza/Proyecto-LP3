using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Proyecto_LP3
{
    public partial class CargaPuntos_VistaALUMNOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //A traves de este bloque al cargar la página, se hace visible el nombre del usuario el cual inició sesión
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "¡Bienvenido / a, " + usuariologueado + "!";
            }
        }

        /*Hacemos la conexion con la base de datos, en este caso la base de datos escogida y utilizada es Sql Server. Para conectarnos
        le proporcionamos la cadena de conexión.*/
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        //Método que limpia los campos de los textboxs una vez cargados éstos en la base de datos
        void limpiar()
        {
            txtCodigoAlumnos.Text = "";
            txtNombresAlumnos.Text = "";
            txtApellidosAlumnos.Text = "";
            txtCarreraAlumnos.Text = "";
            txtCursoAlumnos.Text = "";
            txtActiAlumnos.Text = "";

            //Mantenemos el formato de la fecha
            txtFechaActividadAlumnos.Text = "DD/MM/AAAA";
        }

        /*Carga los datos para la solicitud de acreditación de créditos del alumno/a, a la tabla tab_Alum dentro de la 
        base de datos. Y una vez enviados estos datos se visualiza la fecha, actividad y los créditos acumulados del alumno/a. */
        protected void btnEnviarDatosALUMNOS_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigoAlumnos.Text);
            string nombres = txtNombresAlumnos.Text;
            string apellidos = txtApellidosAlumnos.Text;
            string carrera = txtCarreraAlumnos.Text;
            string curso = txtCursoAlumnos.Text;
            DateTime fecha = DateTime.Parse(txtFechaActividadAlumnos.Text);
            string fechasalida = fecha.ToString("G", CultureInfo.CreateSpecificCulture("en-US")); //conversor de formato de horoario al requerido por sql
            string acti = txtActiAlumnos.Text;
            int creditos = int.Parse(txtCreditosAcumuladosAlumnos.Text);

            connection.Open();
            SqlCommand comand = new SqlCommand("Insert into tab_Alum values ('" + codigo + "','" + nombres + "','" + apellidos + "','" + carrera + "','" + curso + "','" + fechasalida + "','" + acti + "','" + creditos + "')", connection);
            comand.ExecuteNonQuery();
            connection.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Guardado con éxito!');", true);

            limpiar();

            /*-------------------------------------------------------------------------------------------------------------------------------------------*/

            SqlCommand comando = new SqlCommand("Select Fecha,Actividad,CreditosAcumulados from tab_Alum WHERE Codigo = '" + codigo + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        /*Me redirige a la ventana MisCreditosAcademicos
        Este método lo que hace es hacer visible la fecha, actividad y los creditos obtenidos por los alumnos
        proporcionándo el número de código del interesado.*/
        protected void btnVerMisCreditos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisCreditosAcademicos.aspx");
        }
    }
}