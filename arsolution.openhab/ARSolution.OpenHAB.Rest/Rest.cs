using ARSolution.OpenHAB.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Resources;
using System.Text.Json;

namespace ARSolution.OpenHAB.Rest
{
    public class Rest
    {
        #region Variables

        private readonly Uri restUri;
        private readonly ResourceManager resourceManager = new ResourceManager("ARSolution.OpenHAB.Rest.RestRequests", Assembly.GetExecutingAssembly());

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Create a Rest Client
        /// </summary>
        /// <param name="server">IP-address or hostname without http://</param>
        /// <param name="port">Port on which OpenHAB Rest is running (Default: 8080)</param>
        public Rest(string server, int port)
        {
            UriBuilder uriBuilder = new UriBuilder
            {
                Host = server,
                Port = port,
            };
            this.restUri = uriBuilder.Uri;
        }

        #endregion Constructor

        #region Public

        public async System.Threading.Tasks.Task<Item[]> GetItemsAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(new Uri(restUri, resourceManager.GetString("GetItems"))).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<List<Item>>(responseBody).ToArray();
        }

        #endregion Public
    }
}