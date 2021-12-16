using RestSharp;

namespace APITests.API.Methods
{
    class UserMethods
    {
        static public IRestResponse executegetusers(string endpoint)
        {
            string url = BaseMethods.SetUrl(endpoint);
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);

            return response;
        }
        
    }
}
