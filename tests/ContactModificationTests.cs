using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
        ContactData modifiedContact = new ContactData("DDDD");
        modifiedContact.Firstname = null;
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
            app.Contacts.Modify(modifiedContact);
        }
    }
}