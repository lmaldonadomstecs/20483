using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myWebAPI.Model;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;

namespace myWebAPI.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(Post item)
        {
            await this._container.CreateItemAsync<Post>(item, new PartitionKey(item.id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<Post>(id, new PartitionKey(id));
        }

        public async Task<Post> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Post> response = await this._container.ReadItemAsync<Post>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Post>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Post>(new QueryDefinition(queryString));
            List<Post> results = new List<Post>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, Post item)
        {
            await this._container.UpsertItemAsync<Post>(item, new PartitionKey(id));
        }
    }
}
