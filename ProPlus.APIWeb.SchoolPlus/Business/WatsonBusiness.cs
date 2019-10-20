using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Cloud.SDK.Core.Http;
using IBM.Cloud.SDK.Core.Http.Exceptions;
using IBM.Watson.Discovery.v1;
using IBM.Watson.Discovery.v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProPlus.APIWeb.SchoolPlus.Business
{
    public class WatsonBusiness
    {
        const string apikey = "AfSKmskVuH33sPHgBTJrNoDgUOcMlPzw_3HoYiROmZqF";
        const string environmentId = "032eab3c-6347-4a7e-bc8e-45f75d25cb52";
        const string url = "https://gateway-wdc.watsonplatform.net/discovery/api";
        const string collectionId = "b528bd9e-bbfa-47a7-bc71-d4ff8dfc7b81";

        public WatsonBusiness()
        {
            var query = "Quem descobriu o Brasil?";
            var versaoDia = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                IamAuthenticator authenticator = new IamAuthenticator(apikey: $"{apikey}");
                DiscoveryService discovery = new DiscoveryService($"{versaoDia}", authenticator);
                discovery.SetServiceUrl($"{url}");
                discovery.DisableSslVerification(true);
                ListaCollection(discovery);
                ResponseQueries(discovery, environmentId, collectionId, query);
            }
            catch (ServiceResponseException e)
            {
                Console.WriteLine($"Error: {e.Message}, com status: {e.Status}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private void ResponseQueries(DiscoveryService discovery,
                                    string environmentId,
                                    string collectionId,
                                    string filter = null,
                                    string query = null,
                                    string naturalLanguageQuery = null,
                                    bool? passages = null,
                                    string aggregation = null,
                                    long? count = null,
                                    string _return = null,
                                    long? offset = null,
                                    string sort = null,
                                    bool? highlight = null,
                                    string passagesFields = null,
                                    long? passagesCount = null,
                                    long? passagesCharacters = null,
                                    bool? deduplicate = null,
                                    string deduplicateField = null,
                                    bool? similar = null,
                                    string similarDocumentIds = null,
                                    string similarFields = null,
                                    string bias = null,
                                    bool? spellingSuggestions = null,
                                    bool? xWatsonLoggingOptOut = null)
        {
            var results = discovery.Query(environmentId, collectionId, query);
            //var result = results.Result;            //  The result object
            //var responseHeaders = results.Headers;  //  The response headers
            //var responseJson = results.Response;    //  The raw response JSON
            //var statusCode = results.StatusCode;    //  The response status code
            ShowResults(results);
        }

        private void ListaCollection(DiscoveryService discovery)
        {
            var results = discovery.ListCollections(environmentId: $"{environmentId}");
            //var result = results.Result;            //  The result object
            //var responseHeaders = results.Headers;  //  The response headers
            //var responseJson = results.Response;    //  The raw response JSON
            //var statusCode = results.StatusCode;    //  The response status code
            ShowResults(results);
        }

        private static void ShowResults<T>(DetailedResponse<T> results) 
                where T : class
        {
            var tipo = results.GetType();
            Dictionary<string, object> responseHeaders = null;
            string responseJson = string.Empty;
            string statusCode = string.Empty;
            if (tipo == typeof(DetailedResponse<ListCollectionsResponse>))
            {
                var result = results.Result;            //  The result object
                responseHeaders = results.Headers;  //  The response headers
                responseJson = results.Response;    //  The raw response JSON
                statusCode = results.StatusCode.ToString();    //  The response status code
            }
            else
            {
                var result = results.Result;            //  The result object
                responseHeaders = results.Headers;  //  The response headers
                responseJson = results.Response;    //  The raw response JSON
                statusCode = results.StatusCode.ToString();    //  The response status code
            }
        }
    }
}
