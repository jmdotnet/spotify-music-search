using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jmdotnet.MusicSearch.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jmdotnet.MusicSearch.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MusicSearchController : ControllerBase
    {

        private readonly ISearchService _searchService;


        public MusicSearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {

            var result = await _searchService.Search(query);

            return Ok(result);

       


        }
    }
}