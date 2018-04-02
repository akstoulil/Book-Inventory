public class Table
{
    private double isbn;
    private string title;
    private string lastName;
    private string firstName;
    private string category;
    private double rating;
    private string format;

    public Table()
    {
    }

    public double Isbn
    {
        get
        {
            return isbn;
        }
        set
        {
            isbn = value;
        }
    }

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }

    public string AuthorLName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
        }
    }

    public string AuthorFName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public string Category
    {
        get
        {
            return category;
        }
        set
        {
            category = value;
        }
    }

    public double Rating
    {
        get
        {
            return rating;
        }
        set
        {
            rating = value;
        }
    }

    public string Format
    {
        get
        {
            return format;
        }
        set
        {
            format = value;
        }
    }
}