using System.Collections.Generic;
using AutoMapper;
using AutoMapper_BookStore_Demo;

namespace AutoMapperTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var createAddressMap=Mapper.CreateMap<AddressDto, Address>();

            var address = Mapper.Map<AddressDto, Address>(new AddressDto
                                                              {
                                                                  Country = "Taiwan",
                                                                  Street = "a street"
                                                              });
            

            var bookStoreDto = new BookStoreDto
                      {
                          Name = "My Store",
                          Address = new AddressDto {City = "Beijing"},
                          Books =
                              new List<BookDto>
                              {
                                  new BookDto
                                  {
                                      Title = "RESTful Web Service"
                                  },
                                  new BookDto {Title = "Ruby for Rails"},
                              }
                      };
            IMappingExpression<BookDto, Book> expression = Mapper.CreateMap<BookDto, Book>(); 
            
            var createBookStoreMap= Mapper.CreateMap<BookStoreDto, BookStore>();
            var bookStore = Mapper.Map<BookStoreDto, BookStore>(bookStoreDto);


        }
    }
}