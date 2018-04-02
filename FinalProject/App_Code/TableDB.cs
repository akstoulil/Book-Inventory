using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

[DataObject(true)]
public static class CategoryDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<Table> GetTable()
    {
        List<Table> tableList = new List<Table>();
        string sel = "SELECT Isbn, Title, AuthorLName, AuthorFName, Category, Rating, Format "
            + "FROM Table ORDER BY Title";
        using (SqlConnection con = new SqlConnection(GetConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sel, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Table table;
                while (dr.Read())
                {
                    table = new Table();
                    table.Isbn = (double)dr["Isbn"];
                    table.Title = dr["Title"].ToString();
                    table.AuthorLName = dr["AuthorLName"].ToString();
                    table.AuthorFName = dr["AuthorFName"].ToString();
                    table.Category = dr["Category"].ToString();
                    table.Rating = (double)dr["Rating"];
                    table.Format = dr["Format"].ToString();
                    tableList.Add(table);
                }
                dr.Close();
            }
        }
        return tableList;
    }

    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings
            ["IsbnTitleString"].ConnectionString;
    }
}