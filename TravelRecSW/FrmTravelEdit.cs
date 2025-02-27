using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelRecSW
{
    public partial class FrmTravelEdit : Form
    {
        private int travelId;
        public FrmTravelEdit(int travelId)
        {
            InitializeComponent();
            this.travelId = travelId;

        }

        private void FrmTravelEdit_Load(object sender, EventArgs e)
        {
            //เอา travelId ไปดึงข้อมูลจาก DB มาแสดงผล
            //Save to DB
            //connect to DB
            SqlConnection conn = new SqlConnection(ShareInfo.conStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            //===============================================================
            //SQL command
            string strSql = "SELECT * FROM travel_tb WHERE travelId = @travelId";
            //create sql transaction and sql command for working with SQL
            SqlTransaction sqlTransaction = conn.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strSql;
            sqlCommand.Transaction = sqlTransaction;
            //===============================================================
            //bindParam
            sqlCommand.Parameters.AddWithValue("@travelId", travelId);

            //===============================================================
            //Run SQL
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            conn.Close();

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //===============================================================
            //เอาไปกำหนดค่าให้แต่ละส่วนของ UI
            tbTravelPlace.Text = dt.Rows[0]["travelPlace"].ToString();
            dtpTravelStartDate.Value = (DateTime)dt.Rows[0]["travelStartDate"];
            dtpTravelEndDate.Value = (DateTime)dt.Rows[0]["travelEndDate"];
            tbTravelCostTotal.Text = dt.Rows[0]["travelCostTotal"].ToString();

            //Show travelImage
            using (MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["travelImage"]))
            {
                pbTravelImage.Image = Image.FromStream(ms);
            }
            //===============================================================
        }
    }
}
