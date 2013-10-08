using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper_BookStore_Demo;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.CreateMap<AddressDto, Address>();
            var mapper = AutoMapper.Mapper.Map<AddressDto, Address>(new AddressDto
                                                                    {
                                                                        Country = "Taiwan",
                                                                        Street = "a street"

                                                                    });
           
        }
    }
}
