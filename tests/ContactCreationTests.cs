using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("eeee");
            contact.Firstname = "ddd";
            contact.Middlename = "kkkk";
            contact.Nickname = "nnnn";
            contact.Title = "yyyyy";
            contact.Company = "hhhhh";
            contact.Address = "dfgjk, 56";
            contact.Home = "789789";
            contact.Mobile = "45766745";
            contact.Work = "675420";
            contact.Fax = "0934576";
            contact.Email = "dfg@bnmg.fg";
            contact.Email2 = "mnzx@okw.ua";
            contact.Email3 = "bsejh@sdgnu.sez";
            contact.Homepage = "www.frks.com";
            contact.Bday = "23";
            contact.Bmonth = "June";
            contact.Byear = "1979";
            contact.Aday = "1";
            contact.Amonth = "December";
            contact.Ayear = "2011";
            contact.Address2 = "vxcfdgd, 43";
            contact.Phone2 = "836784";
            contact.Notes = "sdfdfgd fghfghtfgh fghfdhdf";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();

            foreach (ContactData oldContact in oldContacts) 
            {
                Console.Write(oldContact + "; ");
            }
           
            // Console.WriteLine();
            
            foreach (ContactData newContact in newContacts)
            {
                Console.Write(newContact + "; ");
            }

            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}
