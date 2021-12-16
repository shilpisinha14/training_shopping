using APITests.API.Methods;
using APITests.API.Models.Response;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace APITests.APITest
{
    [TestFixture]
    public class UserAPITest
    {
        const string endpoint = "users";
        IRestResponse _userresponse = UserMethods.executegetusers(endpoint);

        [Test]
        public void VerifyStatusCode()
        {
            Assert.That(_userresponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void VerifyHeaderContent()
        {
            Assert.That(_userresponse.ContentType, Is.EqualTo("application/json; charset=utf-8")); 
        }

        [Test]
        public void VerifyContentArray()
        {
            var response = JsonConvert.DeserializeObject<List<UserResponse>>(_userresponse.Content);
            Assert.AreEqual(10, response.Count, "No. of users isn't correct");
        }
    }
}
