using System.Security.Claims;
using Catalog.Dtos;
using Catalog.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Catalog
{
  public static class Extensions {
    public static ItemDto AsDto(this Item item){
      return new ItemDto
      {
        Id = item.Id,
        Name = item.Name,
        Price = item.Price,
        CreatedDate = item.CreatedDate
      };
    }
  }
}