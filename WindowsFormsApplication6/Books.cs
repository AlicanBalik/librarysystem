using System;

public class Books
{
	public Books()
	{
	}

    // bu class veritabanındaki bookinfo tablosunun karşılığıdır,
    // databaseden gelen kitap bilgilerini saklamak için kullanılır
    // private variableı propertye çevirmek için üzerine gelip CTRL + R + E

  
    private int _ISBN;
    public int ISBN
    {
        get { return _ISBN; }
        set { _ISBN = value; }
    }

    private string _author;
    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    private string _bookName;
    public string BookName
    {
        get { return _bookName; }
        set { _bookName = value; }
    }

    private int _publishedYear;
    public int PublishedYear
    {
        get { return _publishedYear; }
        set { _publishedYear = value; }
    }
    // //
    


    // bu fonksiyon tostring fonksiyonunun ne göstermesi gerektiğini
    // ayarlıyo, bu durumda ben listbox, combobox gibi formlarda
    // gösterilmesi için bookname i seçtim
    // istersen bunu değiştirerek o listte gösterilen verileri değiştirebilirsin

    public override string ToString()
    {
        // return "[" + ISBN + "] " + BookName;
        return BookName;
    }

}
