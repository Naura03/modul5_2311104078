class Program
{
    static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(23);
        db.AddNewData(11);
        db.AddNewData(04);

        db.PrintAllData();
    }
}