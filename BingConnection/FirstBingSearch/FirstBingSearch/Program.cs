using System;

using System.Net;

namespace Microsoft.Samples.BingSearch
{
    /*
     * Minimal example of a connection to the Bing API (here the SearchAPI) and output of the results into the console
     * 
     */
    class Program
    {

        static void Main(string[] args)
        {

            // This is the query - or you could get it from args.

            string query = "FH Kiel";

            // Create a Bing container.

            string rootUri = "https://api.datamarket.azure.com/Bing/Search";

            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUri));

            // Replace this value with your account key.

            var accountKey = "mukZE9oHLj75rEkpKsRDXI6Aoa6DbzwoDyU9sRK0ahQ=";

            // Configure bingContainer to use your credentials.

            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);

            // Build the query.

            var imageQuery = bingContainer.Web(query, null, null, null, null, null, null, null);

            var imageResults = imageQuery.Execute();

            foreach (var result in imageResults)
            {

                Console.WriteLine(result.Title);        //Output of the titles from the search results

            }
            Console.ReadLine(); //Wait for input from user, so you can see the output in the console

        }

    }

}