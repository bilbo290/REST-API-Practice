using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using System.Collections.Generic;
using Catalog.Dtos;

namespace Catalog.Controllers
{
  // GET /items
  [ApiController]
  [Route("items")]
  public class ItemsController : ControllerBase
  {
    private readonly IItemsRepository respository;

    public ItemsController(IItemsRepository repository)
    {
      this.respository = repository;
    }

    // GET /items
    [HttpGet]
    public IEnumerable<ItemDto> GetItems() {
      var items = respository.GetItems().Select(item => item.AsDto());
      return items;
    }

    [HttpGet("{id}")]
    public ActionResult<ItemDto> GetItem(Guid id)
    {
      var item = respository.GetItem(id);

      if (item is null){
        return NotFound();
      }
      return item.AsDto();
    }

  }
}