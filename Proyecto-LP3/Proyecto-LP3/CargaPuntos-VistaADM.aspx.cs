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
    public partial class CargaPuntos_VistaADM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lista todos los elementos de la tabla tab_Alum al cargarse inicialmente la página
            if (!IsPostBack)
            {
                listaAlum();
            }

            //A través de este bloque al cargar la página, se hace visible el nombre del usuario el cual inició sesión
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "¡Bienvenido / a, " + usuariologueado + "!";
            }
        }

        //Hacemos la conexion con la base de datos, en este caso la base de datos escogida y utilizada es Sql Server. Para conectarnos
        //le proporcionamos la cadena de conexión.
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        //Carga los datos para la solicitud de acreditación de créditos del alumno/a, a la tabla tab_Alum dentro de la base de datos.
        //Y una vez enviados, éstos datos se visualizan 
        protected void btnCargaDatosADM_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbxCodigo.Text);
            string nombres = tbxNombres.Text;
            string apellidos = tbxApellidos.Text;
            string carrera = tbxCarrera.Text;
            string curso = tbxCurso.Text;
            DateTime fecha = DateTime.Parse(tbxFecha.Text);
            string fechasalida = fecha.ToString("G", CultureInfo.CreateSpecificCulture("en-US")); //conversor de formato de horoario al requerido por sql
            string acti = tbxActi.Text;
            int creditos = int.Parse(tbxCA.Text);

            connection.Open();
            SqlCommand comand = new SqlCommand("Insert into tab_Alum values ('" + codigo + "','" + nombres + "','" + apellidos + "','" + carrera + "','" + curso + "','" + fechasalida + "','" + acti + "','" + creditos + "')", connection);
            comand.ExecuteNonQuery();
            connection.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Guardado con éxito!');", true);

            listaAlum();

            limpiar();

        }

        //Con este método, se muestran todos los datos de todos los alumnos que enviaron sus respectivas solicitudes para la acreditación 
        //de sus respectivos créditos, ordenados por número de código de manera ascendente.
        //Datos alojados en la tabla tab_Alum de la base de datos. Esta funcionalidad sólo la tiene habilitada el administrador o encargado
        //general de contabilizar los créditos a los alumnos. 
        void listaAlum()
        {
            SqlCommand comand = new SqlCommand("Select Codigo,Nombres,Apellidos,Carrera,Curso,Fecha,Actividad,CreditosAcumulados from tab_Alum ORDER BY Codigo ASC", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        //Método que limpia los campos de los textboxs una vez cargados éstos en la base de datos
        void limpiar()
        {
            tbxCodigo.Text = "";
            tbxNombres.Text = "";
            tbxApellidos.Text = "";
            tbxCarrera.Text = "";
            tbxCurso.Text = "";
            tbxActi.Text = "";

            //Mantenemos el formato de la fecha
            tbxFecha.Text = "DD/MM/AAAA";
        }

        //Con este método logramos actualizar los datos anteriormente introducidos en la base de datos. En el caso de que haya algo que modificar.
        //Esta funcionalidad sólo la tiene habilitada el administrador o encargado general de asignar, actualizar o eliminar los respectivos créditos
        //académicos extracurriculares correspondientes a cada alumno. En este caso actualizar los datos anteriormente introducidos.
        protected void btnActualizarDatosADM_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbxCodigo.Text);
            string nombres = tbxNombres.Text;
            string apellidos = tbxApellidos.Text;
            string carrera = tbxCarrera.Text;
            string curso = tbxCurso.Text;
            DateTime fecha = DateTime.Parse(tbxFecha.Text);
            string acti = tbxActi.Text;
            int creditos = int.Parse(tbxCA.Text);

            connection.Open();
            SqlCommand comand = new SqlCommand("Update tab_Alum set Nombres = '" + nombres + "', Apellidos = '" + apellidos + "', Carrera = '" + carrera + "', Curso = '" + curso + "', Fecha = '" + fecha + "', Actividad = '" + acti + "', CreditosAcumulados = '" + creditos + "' where Codigo = '" + codigo + "'", connection);
            comand.ExecuteNonQuery();
            connection.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Actualizados con éxito!');", true);

            listaAlum();

            limpiar();
        }

        //Con este método logramos eliminar los datos anteriormente introducidos en la base de datos, proporcionándole el número de código 
        //Esta funcionalidad sólo la tiene habilitada el administrador o encargado general de asignar, actualizar o eliminar los respectivos créditos
        //académicos extracurriculares correspondientes a cada alumno. En este caso eliminar los datos anteriormente introducidos.
        protected void btnEliminarDatosADM_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbxCodigo.Text);
            connection.Open();
            SqlCommand comand = new SqlCommand("Delete tab_Alum where Codigo = '" + codigo + "'", connection);
            comand.ExecuteNonQuery();
            connection.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Datos Eliminados con éxito!');", true);

            listaAlum();

            limpiar();
        }

        /*
        //Nos redirige directamente a la ventana de solicitudes
        protected void btnSolicitudes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Solicitudes.aspx");
        }
        */
    }
}