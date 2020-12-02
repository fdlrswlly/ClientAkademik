using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClientAkademik
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_nim_Click(object sender, EventArgs e)
        {
            AkademikReference.Service1SoapClient obj = new AkademikReference.Service1SoapClient();
            DataSet dsObj = obj.QueryModel(Txt_nim.Text.Trim());
            if(dsObj.Tables[0].Rows.Count == 0)
            {
                lbl_msg.Text="Data tidak di temukan!";

            }
            else
            {
                Akademik_GD.DataSource =dsObj.Tables[0];
                lbl_msg.Text = "Data di temukan";
                Txt_nn.Text = dsObj.Tables[0].Rows[0][0].ToString();
                Txt_nn.DataBind();
                Txt_nama.Text = dsObj.Tables[0].Rows[0][1].ToString();
                Txt_nama.DataBind();
                Txt_alamat.Text = dsObj.Tables[0].Rows[0][2].ToString();
                Txt_alamat.DataBind();
                Txt_email.Text = dsObj.Tables[0].Rows[0][3].ToString();
                Txt_email.DataBind();
                Txt_nilai.Text = dsObj.Tables[0].Rows[0][4].ToString();
                Txt_nilai.DataBind();
            }
            Akademik_GD.DataBind();

    }

        protected void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                AkademikReference.Service1SoapClient obj = new AkademikReference.Service1SoapClient();
                obj.insertdata(Txt_nn.Text, Txt_nama.Text, Txt_alamat.Text, Txt_email.Text, Convert.ToInt16(Txt_nilai.Text));
                lbl_msg.Visible = true;
                lbl_msg.Text = "Data Tersimpan";

                DataSet dsObj = new DataSet();
                dsObj = obj.Display();
                
                Akademik_GD.DataSource = dsObj.Tables[0];
                Akademik_GD.DataBind();
                

            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.Message.ToString();
            }
            
        }

        protected void btn_ubah_Click(object sender, EventArgs e)
        {
            AkademikReference.Service1SoapClient obj = new AkademikReference.Service1SoapClient();
            obj.UbahAkademik(Txt_nn.Text, Txt_nama.Text, Txt_alamat.Text, Txt_email.Text, Convert.ToInt16(Txt_nilai.Text));
            lbl_msg.Visible = true;
            lbl_msg.Text = "Data Terupdate";

            DataSet dsObj = new DataSet();
            dsObj = obj.Display();

            Akademik_GD.DataSource = dsObj.Tables[0];
            Akademik_GD.DataBind();
        }

        protected void btn_hapus_Click(object sender, EventArgs e)
        {
            AkademikReference.Service1SoapClient obj = new AkademikReference.Service1SoapClient();
            obj.DeleteAkademik(Txt_nn.Text);
            lbl_msg.Visible = true;
            lbl_msg.Text = "Data Terhapus";
            DataSet dsObj = new DataSet();
            dsObj = obj.Display();

            Akademik_GD.DataSource = dsObj.Tables[0];
            Akademik_GD.DataBind();
        }
    }
}