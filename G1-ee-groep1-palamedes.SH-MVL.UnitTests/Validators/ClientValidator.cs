using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.UnitTests.Validators
{
    public class ClientValidator
    {
        public async Task<ClientValidatorObject> ValidateObject(ClientValidatorObject client)
        {
            HttpResponseMessage respons = new HttpResponseMessage();
            switch (client.method)
            {
                case "post":
                    respons = await PostputRequest(client);
                    break;
                case "put":
                    respons = await PostputRequest(client);
                    break;
                case "get":
                    respons = await GetRequest(client);
                    break;
                case "delete":
                    respons = await DeleteRequest(client);
                    break;
            }

            client = ValidateStatusCode(client, respons);

            return client;

        }

        private ClientValidatorObject ValidateStatusCode(ClientValidatorObject client, HttpResponseMessage respons)
        {

            if (respons.StatusCode == HttpStatusCode.OK)
            {
                return client;
            }
            if (respons.StatusCode == HttpStatusCode.Unauthorized)
            {
                client.ValidationResults.Add(new ValidationResult("not a valid bearer token"));
                return client;
            }
            if (respons.StatusCode == HttpStatusCode.Forbidden)
            {
                client.ValidationResults.Add(new ValidationResult("forbidden for user"));
                return client;
            }
            if (respons.StatusCode == HttpStatusCode.NotFound)
            {
                client.ValidationResults.Add(new ValidationResult("not a valid bearer token"));
                return client;
            }
            else
            {
                client.ValidationResults.Add(new ValidationResult("client respons was not OK"));
                return client;
            }
        }

        async Task<HttpResponseMessage> GetRequest(ClientValidatorObject clientObject)
        {
            return await clientObject.httpclient.GetAsync(clientObject.Uri);
        }

        async Task<HttpResponseMessage> PostputRequest(ClientValidatorObject clientObject)
        {
            var dataAsString = JsonConvert.SerializeObject(clientObject.Data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            if(clientObject.method == "post") 
                return await clientObject.httpclient.PostAsync(clientObject.Uri, content);
            else
                return await clientObject.httpclient.PutAsync(clientObject.Uri, content);
        }

        async Task<HttpResponseMessage> DeleteRequest(ClientValidatorObject clientObject)
        {
            return await clientObject.httpclient.DeleteAsync(clientObject.Uri);
        }

    }

   
}
