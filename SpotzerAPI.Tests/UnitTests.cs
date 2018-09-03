using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SpotzerModel;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SpotzerAPI.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PartnerA_Test()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerA Body Message.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest,message.StatusCode);
        }

        [TestMethod]
        public void PartnerA_Test2()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerA Body Message - Additional Info.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, message.StatusCode);
        }

        [TestMethod]
        public void PartnerB_Test()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerB Body Message - String Lenght.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            IList<ValidationResult> result = ValidateModel(partnerOrder);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void PartnerB_Test2()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerB Body Message.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, message.StatusCode);
        }

        [TestMethod]
        public void PartnerC_Test()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerC Body Message.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, message.StatusCode);
        }

        [TestMethod]
        public void PartnerC_Test2()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerC Body Message Missing Values.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, message.StatusCode);
        }

        [TestMethod]
        public void PartnerD_Test()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerD Body Message.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, message.StatusCode);
        }

        [TestMethod]
        public void PartnerD_Test2()
        {
            string path = System.Environment.CurrentDirectory;
            string requestBodyPath = Path.Combine(Directory.GetParent(Directory.GetParent(path).FullName).FullName, @"Request Bodies\PartnerD Body Message - Redundant Information.txt");
            string requestBody = File.ReadAllText(requestBodyPath);

            PartnerOrderModel partnerOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<PartnerOrderModel>(requestBody);


            var controller = new SpotzerAPI.Controllers.ApplyOrderController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            HttpResponseMessage message = controller.Post(partnerOrder);
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, message.StatusCode);
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }
    }
}
