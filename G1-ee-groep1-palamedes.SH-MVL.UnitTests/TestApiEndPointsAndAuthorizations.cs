using G1_ee_groep1_palamedes.SH_MVL.API.Controllers;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using G1_ee_groep1_palamedes.SH_MVL.UnitTests.MockData;
using G1_ee_groep1_palamedes.SH_MVL.UnitTests.Validators;

using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.UnitTests
{
    public class TestApiEndPointsAndAuthorizations
    {

        /// <summary>
        ///         these unit tests are to validate the endpoints when the api is online, 
        ///         to ensure authorization and safety of data and functionalities
        /// 
        ///  test next:
        ///  - get all arts
        ///  - get all artists
        ///  - get all users
        ///  - get all categories
        ///  - get bearertoken
        ///  
        ///  - getall:
        ///     - arts, artists, users, categories
        ///  - getByid:
        ///     - arts, artists, users, categories
        ///  
        ///  authorize:
        ///  - create , update , delete
        ///  - get all users 
        ///  
        /// </summary>


        HttpClient httpclient;
        ClientValidatorObject clienttoValidate;
        ClientValidator ClientValidator;
        public TestApiEndPointsAndAuthorizations()
        {
               
        }

        #region - TestGetAll -
        [TestCase]
        public async Task TestGetArts()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            //clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestGetCategories()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            //clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestGetArtists()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            //clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestGetUsers()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "users";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }

        #endregion

        #region - TestGetByIdGOODandBAD
        [TestCase]
        public async Task TestGetUsersByGoodId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "users/" + ClientMockData.GoodUserId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }

        [TestCase]
        public async Task TestGetUsersByBadId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "users/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }

        [TestCase]
        public async Task TestGetArtsByGoodId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts/" + ClientMockData.GoodIntId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }

        [TestCase]
        public async Task TestGetArtsByBadId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "users/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestGetArtistsByGoodId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists/" + ClientMockData.GoodIntId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestGetArtistsByBadId()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }


        #endregion

        #region - TestAuthController -
        [TestCase]
        public async Task TestBearerControllerWithGoodUserLogin()
        {
            // arange 
            var webRequest = WebRequest.Create(ClientMockData.ApiBaseUri + "auth/token");
            webRequest.Headers["Authorization"] = "Basic "
                                                + Convert.ToBase64String(Encoding.Default.GetBytes(ClientMockData.ValidUserEmail)
                                                );
            webRequest.Method = "POST";

            //act
            var respons = await webRequest.GetResponseAsync();
            var responsstream = respons.GetResponseStream();
            var reader = new StreamReader(responsstream);
            var bearerToken = reader.ReadToEnd();

            //assert
            Assert.AreNotEqual(bearerToken, "User logged in.");

        }
        [TestCase]
        public async Task TestBearerControllerWithBadUserLogin()
        {
            // arange 
            var webRequest = WebRequest.Create(ClientMockData.ApiBaseUri + "auth/token");
            webRequest.Headers["Authorization"] = "Basic "
                                                + Convert.ToBase64String(Encoding.Default.GetBytes(ClientMockData.ValidUserEmail)
                                                );
            webRequest.Method = "POST";

            //act
            var respons = await webRequest.GetResponseAsync();
            var responsstream = respons.GetResponseStream();
            var reader = new StreamReader(responsstream);
            var bearerToken = reader.ReadToEnd();

            //assert
            Assert.AreEqual(bearerToken, "User logged in.");

        }

        #endregion

        #region - Test crud Authorization on api endpoints -
        [TestCase]
        public async Task TestUserIDEndpointWithAuthorization()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "get";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "users/userid/" + ClientMockData.GoodUserId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }

        [TestCase]
        public async Task TestPutGoodArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.GoodArt;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPutEmptyArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.EmptyArt;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPutGoodArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.GoodArtist;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPutBadArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.EmptyArtist;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPutGoodCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.GoodCategory;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPutBadCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "put";
            clienttoValidate.Data = ClientMockData.EmptyCategory;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostGoodArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.GoodArt;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostEmptyArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.EmptyArt;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostGoodArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.GoodArtist;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostBadArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.EmptyArtist;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostGoodCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.GoodCategory;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestPostBadCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "post";
            clienttoValidate.Data = ClientMockData.EmptyCategory;
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories";


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteGoodIDCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories/" + ClientMockData.GoodIntId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteBadIDCategory()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "categories/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteGoodIDArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists/" + ClientMockData.GoodIntId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteBadIDArtist()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "artists/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteGoodIDArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts/" + ClientMockData.GoodIntId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        [TestCase]
        public async Task TestDeleteBadIDArt()
        {
            //act 
            ClientValidator = new ClientValidator();
            clienttoValidate = new ClientValidatorObject();
            clienttoValidate.httpclient = new HttpClient();
            clienttoValidate.httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ClientMockData.bearerToken300D);
            clienttoValidate.method = "delete";
            clienttoValidate.Uri = ClientMockData.ApiBaseUri + "arts/" + ClientMockData.BadStringId;


            //arrange
            clienttoValidate = await ClientValidator.ValidateObject(clienttoValidate);

            //assert
            Assert.IsTrue(clienttoValidate.ValidationResults.Count == 1, "the number of errors is more as 1");
        }
        #endregion


    }
}
