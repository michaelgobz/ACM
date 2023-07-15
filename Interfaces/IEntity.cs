using System.Collections.Generic;
using acm.BL;

namespace acm.Interfaces 
{
    public interface IEntity
    {
        int entityId { get; private set;}
        string ToString();
        bool Validate();
    }

    public interface IEntityWithAddresses 
    {
        Repository<Address> addresses;
    }

}