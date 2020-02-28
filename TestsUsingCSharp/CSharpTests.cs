using System;
using NUnit.Framework;

namespace TestsUsingCSharp
{
    public class Tests
    {
        [Test]
        public void UseFSharpFromCSharp()
        {
            var person = new FSharpDomain.Model.Person(name: "Sean", birthday: DateTime.Today.AddDays(-1));
            Assert.AreEqual("Sean", person.Name);
        }
    }
}