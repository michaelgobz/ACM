namespace acm.Interfaces
{
    public interface IRepository<T>
    {
        string Name { get; set; }
        string Description { get; set; }
        int repositoryId { get; }

        int GetItemsCount();
        void LogItem(T item);
        void LogItems();
        T Retrieve(int Id);
        List<T> Retrieve();
        bool Save(T item);
        string ToString();
    }
}