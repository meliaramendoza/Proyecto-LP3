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
            //Lista todos los elementos de la tabla tab_Alum al cargarse inicialmente la página
            listaAlum();
        }

        /*Hacemos la conexion con la base de datos, en este caso la base de datos escogida y utilizada es Sql Server. Para conectarnos
        le proporcionamos la cadena de conexión.*/
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        /*Método que lista todos los datos de la tabla tab_Alum, en donde se encuentra registrado todas las actividades realizadas por cada alumno,
        con sus respectivas fechas y los creditos obtenidos por cada actividad.*/
        void listaAlum()
        {
            SqlCommand comand = new SqlCommand("Select * from tab_Alum", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        //Método que actualiza los datos de los alumnos. 
        protected void btnActualizarDatosADMSol_Click(object sender, EventArgs e)
        {

        }

        //Método que elimina los datos de los alumnos. 
        protected void btnEliminarDatosADM_Click(object sender, EventArgs e)
        {

        }
    }
}