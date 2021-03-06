﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Palamedes.Web.Helper
{
    public static class WebApiHelper
    {
        public static async Task<T> GetApiResultAsync<T>(string uri)
        {
            try
            {
                using HttpClient httpClient = new HttpClient();
                string response = await httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<T>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new NotImplementedException();
            }

        }

        public static T GetApiResult<T>(string uri)
        {
            try
            {
                using WebClient webClient = new WebClient();
                string response = webClient.DownloadString(uri);
                return JsonConvert.DeserializeObject<T>(response);
            }
            catch (Exception)
            {
                throw new NullReferenceException(nameof(T));
            }

        }

        public static async Task<Out> PutCallAPI<Out, In>(string uri, In entity)
        {
            return await CallAPI<Out, In>(uri, entity, HttpMethod.Put);
        }

        public static async Task<Out> PostCallAPI<Out, In>(string uri, In entity)
        {
            return await CallAPI<Out, In>(uri, entity, HttpMethod.Post);
        }

        public static async Task<Out> DelCallAPI<Out>(this HttpClient httpClient, string uri)
        {
            return await CallAPI<Out, object>(uri, null, HttpMethod.Delete);
        }

        private static async Task<Out> CallAPI<Out, In>(string uri, In entity, HttpMethod method)
        {
            Out result = default;
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response;
                if (method == HttpMethod.Post)
                {
                    response = await PostAsJsonAsync(httpClient, uri, entity);
                }
                else if (method == HttpMethod.Put)
                {
                    response = await PutAsJsonAsync(httpClient, uri, entity);
                }
                else
                {
                    response = await httpClient.DeleteAsync(uri);
                }
                result = await ReadAsJsonAsync<Out>(response.Content);
            }
            return result;

        }
        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonConvert.SerializeObject(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonConvert.SerializeObject(data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpClient.PutAsync(url, content);
        }

        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
        {
            var dataAsString = await content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(dataAsString);
        }
    }
}
