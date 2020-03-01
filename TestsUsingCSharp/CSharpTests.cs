using System;
using FSharpDomain;
using Newtonsoft.Json;
using NUnit.Framework;

namespace TestsUsingCSharp
{
    public class Tests
    {
        [Test]
        public void UseFSharpFromCSharp()
        {
            var person1 = new Model.Person(name: "Sean", birthday: DateTime.Today.AddDays(-1));
            var person2 = new Model.Person(name: "Sean", birthday: DateTime.Today.AddDays(-1));
            Assert.IsTrue(person1.Equals(person2), "Structural quality is free.");
        }

        [Test]
        public void DeserialiseUsingNewtonSoft()
        {
            var json   = "{\"Name\": \"Sean\", \"Birthday\": \"2020-01-01T01:01:01\"}";
            var person = JsonConvert.DeserializeObject<Model.Person>(json);
            Assert.AreEqual("Sean", person.Name);
        }

        [Test]
        public void RoundTripJson()
        {
            var person = new Model.Person(name: "Sean", birthday: DateTime.Today.AddDays(-1));
            var json = Model.personToJson(person);
            var deserialisedPerson = JsonConvert.DeserializeObject<Model.Person>(json);
            Assert.AreEqual("Sean", person.Name);
        }
    }
}