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
    public partial class Solicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listaAlum();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        void listaAlum()
        {
            SqlCommand comand = new SqlCommand("Select * from tab_Alum", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnActualizarDatosADMSol_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminarDatosADM_Click(object sender, EventArgs e)
        {

        }

        /*
        protected void btnActualizarDatosADMSol_Click(object sender, EventArgs e)
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

        protected void btnEliminarDatosADMXSol_Click(object sender, EventArgs e)
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
        */
    }
}