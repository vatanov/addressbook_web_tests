using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData modifiedContact = new ContactData("AAAAA");
            modifiedContact.Firstname = "GGGGGGG";
            modifiedContact.Middlename = null;
            modifiedContact.Nickname = null;
            modifiedContact.Title = null;
            modifiedContact.Company = null;
            modifiedContact.Address = null;
            modifiedContact.Home = null;
            modifiedContact.Mobile = null;
            modifiedContact.Work = null;
            modifiedContact.Fax = null;
            modifiedContact.Email = null;
            modifiedContact.Email2 = null;
            modifiedContact.Email3 = null;
            modifiedContact.Homepage = null;
            modifiedContact.Bday = "23";
            modifiedContact.Bmonth = "June";
            modifiedContact.Byear = null;
            modifiedContact.Aday = "1";
            modifiedContact.Amonth = "December";
            modifiedContact.Ayear = null;
            modifiedContact.Address2 = null;
            modifiedContact.Phone2 = null;
            modifiedContact.Notes = null;

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData oldContact = oldContacts[0];

            app.Contacts.Modify(modifiedContact);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = modifiedContact.Firstname;
            oldContacts[0].Lastname = modifiedContact.Lastname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            // NEED TO CREATE THE SAME ASSERT LIKE FOR GROUPS!!!!
            //foreach (GroupData group in newGroups)
            //{
            //    if (group.Id == oldData.Id)
            //    {
            //        Assert.AreEqual(newData.Name, group.Name);
            //    }
            //}
        }
    }
}