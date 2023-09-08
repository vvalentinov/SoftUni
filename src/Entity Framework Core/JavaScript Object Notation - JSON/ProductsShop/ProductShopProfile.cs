namespace ProductsShop
{
    using AutoMapper;
    using ProductsShop.DataTransferDto;
    using ProductsShop.Models;

    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<UserDto, User>();
        }
    }
}
