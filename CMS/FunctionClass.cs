using iTextSharp.text;
using iTextSharp.text.pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    internal class FunctionClass
    {

        protected SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = Noor;Database=CinemaDB;integrated security=True";
            return conn;
        }

        public DataSet GetData(String sqlquery)
        { //Will get data from the database

            SqlConnection conn = Connection();  //Connection with db
            SqlCommand cmd = new SqlCommand();  //For command
            cmd.Connection = conn; //Connection for command
            cmd.CommandText = sqlquery; //text for command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); //with the help of adapter we will fill the dataset
            DataSet d = new DataSet();
            adapter.Fill(d);
            return d;
        }

        public void SetData(String sqlquery, String message)
        { //For CUD Queries
            SqlConnection conn = Connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sqlquery;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("" + message + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SetData(String sqlquery)
        { //For CUD Queries without message
            SqlConnection conn = Connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sqlquery;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public SqlDataReader GetDataReader(String sqlquery)
        {
            SqlConnection conn = Connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(sqlquery, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void SetMovieData(String sqlquery,byte[] img,String message)
        {
            SqlConnection conn = Connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sqlquery;
            cmd.Parameters.Add(new SqlParameter("@img", img));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("" + message + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public String GetImageData(String sqlquery,String image)
        {
            SqlConnection conn = Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery);
            image = cmd.ExecuteNonQuery().ToString();
            conn.Close();
            return image;
        }
        public void AutoFileSave(String custname, String tr_id,RichTextBox richTextBox)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            try
            {

                PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\Noor\\Desktop\\" + custname + "-" + tr_id + ".pdf", FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph(richTextBox.Text));
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData textdata = qr.CreateQrCode(richTextBox.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrcode = new QRCode(textdata);
                Bitmap qrcodeimage = qrcode.GetGraphic(3);
                iTextSharp.text.Image qrjpg = iTextSharp.text.Image.GetInstance(qrcodeimage, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(qrjpg);
                doc.Close();
                MessageBox.Show("Tranasction Successfully Completed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Process.Start("C:\\Users\\Noor\\Desktop\\" + custname + "-" + tr_id + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                doc.Close();
            }
        }

        public void SavePDF(RichTextBox richTextBox)
        {
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {

                        PdfWriter.GetInstance(doc, new FileStream(sf.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox.Text));
                        QRCodeGenerator qr = new QRCodeGenerator();
                        QRCodeData textdata = qr.CreateQrCode(richTextBox.Text, QRCodeGenerator.ECCLevel.Q);
                        QRCode qrcode = new QRCode(textdata);
                        Bitmap qrcodeimage = qrcode.GetGraphic(3);
                        iTextSharp.text.Image qrjpg = iTextSharp.text.Image.GetInstance(qrcodeimage, System.Drawing.Imaging.ImageFormat.Jpeg);
                        doc.Add(qrjpg);
                        doc.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }

            }
        }
        
        public void SetSeatNumAndRow(RichTextBox richTextBox, String tr_id,String tickquantity)
        {
            int[] seatnum = new int[int.Parse(tickquantity)];
            String[] seatrow = new string[seatnum.Length];
            String sqlquery = "select seat_number from cinema.Seat as A inner join cinema.Ticket as B on A.seat_id = B.seat_id where tr_id =" + tr_id + " order by seat_number";
            SqlDataReader dr = GetDataReader(sqlquery);
            int count = 0;
            String sqlquery2 = "select seat_row from cinema.Seat as A inner join cinema.Ticket as B on A.seat_id = B.seat_id where tr_id =" + tr_id + " order by seat_number";
            SqlDataReader dr2 = GetDataReader(sqlquery2);
            String text = null;

            while (dr.Read() && dr2.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    seatnum[count] = dr.GetInt32(i);
                    seatrow[count] = dr2.GetString(i);
                    text += "" + seatrow[count] + "-" + seatnum[count] +"";
                    text += ",";
                    count++;
                }
            }
            text = text.Remove(text.Length - 1);
            richTextBox.Text += "Seat Row & Number: " + text + "\n";
        }
    }
}