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
            if (!IsPostBack)
            {
                listaAlum();
            }

            //A traves de este bloque al cargar la pagina, se hace visible el nombre del usuario el cual accedio
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "¡Bienvenido / a, " + usuariologueado + "!";
            }
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

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

        void listaAlum()
        {
            SqlCommand comand = new SqlCommand("Select Codigo,Nombres,Apellidos,Carrera,Curso,Fecha,Actividad,CreditosAcumulados from tab_Alum", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void limpiar()
        {
            tbxCodigo.Text = "";
            tbxNombres.Text = "";
            tbxApellidos.Text = "";
            tbxCarrera.Text = "";
            tbxCurso.Text = "";
            tbxFecha.Text = "";
            tbxActi.Text = "";
            tbxCA.Text = "";
        }

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

        protected void btnSolicitudes_Click(object sender, EventArgs e)
        {
            //Nos lleva a la ventana de solicitudes
            Response.Redirect("Solicitudes.aspx");
        }
    }
}