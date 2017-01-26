using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactInformationTest : AuthTestBase
    {
        [Test]
        public void testContactInformation()
        {
            ContactData fromTable = app.Contacts.GetContactInformationFromTable();
            ContactData fromForm = app.Contacts.GetContactInformationFromEditForm();

            // asserts
        }
    }
}
