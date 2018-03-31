using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            textTitle.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string title = textTitle.Text;
                string lastname = textLastName.Text;
                string firstname = textFirstName.Text;
                double rating = double.Parse(DropDownQuestNum.SelectedValue);
                string format = rblst_format.SelectedValue;
                double isbn = double.Parse(textIsbn.Text);

                //BookInventoryTableAdapters.TableAdapterManager insert = new BookInventoryTableAdapters.TableAdapterManager();
                BookInventoryTableAdapters.BookTableAdapter insert = new BookInventoryTableAdapters.BookTableAdapter();

                bool fiction = cbCategory.Items.FindByText("Fiction").Selected;
                bool children = cbCategory.Items.FindByText("Children's").Selected;
                bool foreign = cbCategory.Items.FindByText("Foreign").Selected;
                bool romance = cbCategory.Items.FindByText("Romance").Selected;
                bool suspense = cbCategory.Items.FindByText("Suspense").Selected;
                bool nonfiction = cbCategory.Items.FindByText("Non-Fiction").Selected;
                bool comedy = cbCategory.Items.FindByText("Comedy").Selected;
                bool history = cbCategory.Items.FindByText("History").Selected;
                bool sciFi = cbCategory.Items.FindByText("Sci-Fi").Selected;
                bool textbook = cbCategory.Items.FindByText("Textbook").Selected;
                bool autobiography = cbCategory.Items.FindByText("AutoBiography").Selected;
                bool drama = cbCategory.Items.FindByText("Drama").Selected;
                bool horror = cbCategory.Items.FindByText("Horror").Selected;
                bool selfHelp = cbCategory.Items.FindByText("Self-Help").Selected;
                bool thriller = cbCategory.Items.FindByText("Thriller").Selected;
                bool biography = cbCategory.Items.FindByText("Biography").Selected;
                bool fantasy = cbCategory.Items.FindByText("Fantasy").Selected;
                bool religious = cbCategory.Items.FindByText("Religious").Selected;

                insert.InsertBook(isbn, title, lastname, firstname, rating, format);

                insert.InsertBookCategories(isbn, fiction, foreign, children, romance, suspense, nonfiction, comedy, history, sciFi,
                    textbook, autobiography, drama, horror, selfHelp, thriller, biography, fantasy, religious);

                lbl_result.Text = "Record successfully updated for " + title;

                insert.Transaction.Commit();
            }         

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            cbCategory.ClearSelection();
            textTitle.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            DropDownQuestNum.Text = "N/A";
            textIsbn.Text = "";
        }
    }
}