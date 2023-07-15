using System;
using System.Collections.Generic;

namespace acm.BL
{

    public class Repository<T> : IRepository<T>
    {
        private int _repositoryId;
        public string Name { get; set; }

        public string Description { get; set; }
        public int repositoryId { get { return _repositoryId; } private set { _repositoryId = value; } }

        private List<T> _items;

        public Repository()
        {

        }

        public Repository(int id, string name)
        {
            repositoryId = id;
            Name = name;
            _items = new List<T>();
        }

        public T Retrieve(int Id)
        {
            return _items.Find(id == Id);
        }

        public override string ToString()
        {
            var repo = $"{Name} : {Description}";
            return repo;
        }

        public List<T> Retrieve()
        {

            return _items.FindAll();

        }

        public bool Save(T item)
        {
            _items.Add(item);
            return _items.Contains(item);
        }

        public int GetItemsCount()
        {
            return _items.Count;
        }

        public void LogItem(T item)
        {
            System.Console.WriteLine(item);
        }

        public void LogItems()
        {
            List<T> items = _items.FindAll();
            if (items == null)
            {
                System.Console.WriteLine($"Please no items of type {TypeOf(T)} found");
            }
            else
            {
                foreach (var item in items)
                {
                    System.Console.WriteLine(item);
                }
                System.Console.ReadLine();
            }

        }
    }

}