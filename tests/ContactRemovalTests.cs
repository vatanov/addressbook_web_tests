using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData contactForRemoving = oldContacts[0];

            app.Contacts.Remove(1);

            Assert.AreEqual(oldContacts.Count - 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();

            oldContacts.RemoveAt(0);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            // NEED TO CREATE THE SAME ASSERT LIKE FOR GROUPS!!!!
            //foreach (GroupData group in newGroups)
            //{
            //    Assert.AreNotEqual(group.Id, groupForRemoving.Id);
            //}
        }
    }
}
