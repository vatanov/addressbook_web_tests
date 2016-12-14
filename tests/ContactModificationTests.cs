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
        modifiedContact.Firstname = "JJJJ";
        modifiedContact.Middlename = "BBBB";
        modifiedContact.Nickname = "KKKKK";
        modifiedContact.Title = "SSSSSSS";
        modifiedContact.Company = "OOOOOOO";
        modifiedContact.Address = "FGHFGHFG, 56";
        modifiedContact.Home = "4545454";
        modifiedContact.Mobile = "12121212";
        modifiedContact.Work = "90909090";
        modifiedContact.Fax = "676767676";
        modifiedContact.Email = "dfg@bnmg.fg";
        modifiedContact.Email2 = "mnzx@okw.ua";
        modifiedContact.Email3 = "bsejh@sdgnu.sez";
        modifiedContact.Homepage = "www.frks.com";
        modifiedContact.Bday = "23";
        modifiedContact.Bmonth = "June";
        modifiedContact.Byear = "1979";
        modifiedContact.Aday = "1";
        modifiedContact.Amonth = "December";
        modifiedContact.Ayear = "2011";
        modifiedContact.Address2 = "vxcfdgd, 43";
        modifiedContact.Phone2 = "0000000";
        modifiedContact.Notes = "VBCBDFGDFG DFGFDFG DFGDFG";
            app.Contacts.Modify(modifiedContact);
        }
    }
}