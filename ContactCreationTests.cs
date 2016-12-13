using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitContactCreation();
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
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
            navigator.ReturnToHomePage();
        }
    }
}
