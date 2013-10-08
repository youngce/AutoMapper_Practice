using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper_BookStore_Demo;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapper = AutoMapper.Mapper.Map<AddressDto, Address>(new AddressDto());
           
        }
    }
}
