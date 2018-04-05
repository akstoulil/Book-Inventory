using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Remove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void dropDownEditSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            //lbl_result.Text = "";

            double isbn = double.Parse(dropDownEditSearch.SelectedValue);
            double rating = 0;
            string format = "";

            BookInventoryTableAdapters.BookTableAdapter tableAdapter = new BookInventoryTableAdapters.BookTableAdapter();
            BookInventory.BookInventoryTableDataTable bookInventory = tableAdapter.GetDataByIsbn(isbn);

            foreach (BookInventory.BookInventoryTableRow br in bookInventory)
            {

                lblFirstName.Text = br.AuthorFName.ToString();
                lblLastName.Text = br.AuthorLName.ToString();
                lblTitle.Text = br.Title.ToString();
                lblRating.Text = br.Rating.ToString();


                rating = br.Rating;
                format = br.Format;

            }


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                lblError.Text = "";

                BookInventoryTableAdapters.BookTableAdapter tableAdapter = new BookInventoryTableAdapters.BookTableAdapter();

                double Isbn = double.Parse(dropDownEditSearch.SelectedValue);

                string Title = lblTitle.Text.ToString();
                string AuthorLName = lblLastName.Text.ToString();
                string AuthorFName = lblFirstName.Text.ToString();
                string Rating = lblRating.ToString();
                //string Format = rblst_format.SelectedValue;                

                string bookSql = "DELETE FROM [Table] "
                    + "WHERE Isbn = @Isbn";

                string categorySql = "DELETE FROM Categories "
                    + "WHERE Isbn = @Isbn";

                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(bookSql, con))
                    {
                        cmd.Parameters.AddWithValue("Isbn", Isbn);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(categorySql, con))
                    {
                        cmd.Parameters.AddWithValue("Isbn", Isbn);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                lblResult.Text = Title + " successfully removed!";
                DataBind();

            }
            catch
            {

                lblResult.Text = "";
                lblError.Text = "A database error has occurred";

            }

        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["IsbnTitleString"].ConnectionString;
        }
    }
}