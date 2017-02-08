using System.Diagnostics.Contracts;
using FactoryMethodDemo.Builders.Person.Interfaces;
using FactoryMethodDemo.Interfaces;

namespace FactoryMethodDemo.Builders.Person.Contracts
{
    [ContractClassFor(typeof(ISecondaryContactHolder))]
    public abstract class SecondaryContactHolderContracts : ISecondaryContactHolder
    {

        public abstract bool Contains(IContactInfo contact);

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact)
        {
            Contract.Requires(contact != null);
            Contract.Requires(!this.Contains(contact));
            return null;
        }

        public abstract IPersonBuilder AndNoMoreContacts();

    }
}