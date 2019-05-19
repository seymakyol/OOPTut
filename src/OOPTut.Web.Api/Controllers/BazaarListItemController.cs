using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOPTut.Application.BazaarListItemServices;
using OOPTut.Application.BazaarListItemServices.Dto;
using OOPTut.Core.Bazaar;

namespace OOPTut.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BazaarListItemController : ControllerBase
    {

        private readonly IBazaarListItemService _bazaarListItemService;

        public BazaarListItemController(IBazaarListItemService bazaarListItemService)
        {
            _bazaarListItemService = bazaarListItemService;
        }


        [HttpGet("{id}")]
        public async Task<BazaarListItem> GetAsync(int id)
        {
            return await _bazaarListItemService.GetAsync(id);

        }


        //public async Task DeleteAsync(int id)
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _bazaarListItemService.DeleteAsync(id);
            return Ok();

        }

        [HttpPost]
        public async Task<BazaarListItem> CreateAsync(CreateBazaarListItem input)
        {


            return await _bazaarListItemService.CreateAsync(input);

        }
        [HttpPut]
        public async Task<BazaarListItem> UpdateAsync(UpdateBazaarListItem input)
        {
            return await _bazaarListItemService.UpdateAsync(input);
        }


        [HttpGet("{id}")]
        [ActionName("GetAll")]
        public async Task<ActionResult<List<BazaarListItem>>> GetAllByIdAsync(int id)
        {
          
            return await _bazaarListItemService.GetAllByIdAsync(id);
        }

        


        



        


    }
}