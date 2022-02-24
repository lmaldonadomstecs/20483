using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myWebAPI.Data;
using myWebAPI.Model;
using myWebAPI.Services;

namespace myWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ICosmosDbService _cosmosDbService;

        public PostsController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        // GET api/posts
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _cosmosDbService.GetItemsAsync("SELECT * FROM c"));
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _cosmosDbService.GetItemAsync(id));
        }

        // POST api/items
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Post item)
        {
            item.id = Guid.NewGuid().ToString();
            await _cosmosDbService.AddItemAsync(item);
            return CreatedAtAction(nameof(Get), new { id = item.id }, item);
        }

        // PUT api/items/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromBody] Post item)
        {
            await _cosmosDbService.UpdateItemAsync(item.id, item);
            return NoContent();
        }

        // DELETE api/items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _cosmosDbService.DeleteItemAsync(id);
            return NoContent();
        }

    }
}
