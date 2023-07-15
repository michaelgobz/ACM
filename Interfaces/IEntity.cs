namespace acm.Interfaces 
{
    public interface IEntity
    {
        int entityId { get; private set;}
        string ToString();
        bool Validate();
    }

    
}