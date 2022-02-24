using System.Collections.Generic;
using System.Threading.Tasks;
using myWebAPI.Model;

namespace myWebAPI.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Post>> GetItemsAsync(string query);
        Task<Post> GetItemAsync(string id);
        Task AddItemAsync(Post item);
        Task UpdateItemAsync(string id, Post item);
        Task DeleteItemAsync(string id);
    }
}