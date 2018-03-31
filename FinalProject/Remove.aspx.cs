using System;
using System.Collections.Generic;
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

                rating = br.Rating;
                format = br.Format;

            }


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}