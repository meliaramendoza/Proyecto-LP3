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
    public partial class MisCreditosAcademicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = CAE; Integrated Security=True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        protected void btnBusquedaCreditosPorCodigo_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtBusqCodigo.Text);

            SqlCommand comando = new SqlCommand("Select Fecha,Actividad,CreditosAcumulados from tab_Alum WHERE Codigo = '" + codigo + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}