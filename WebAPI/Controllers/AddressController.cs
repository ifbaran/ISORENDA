﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Abstract;
using Core.Entities.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("AddAddress")]
        public IActionResult AddAddress(Address address, User user)
        {
            var result = _addressService.Add(address, user);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("UpdateAddress")]
        public IActionResult UpdateAddress(Address address)
        {
            var result = _addressService.Update(address);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);

        }

        [HttpDelete("DeleteAddress")]
        public IActionResult DeleteAddress(Address address)
        {
            var result = _addressService.Delete(address);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("GetAddresses")]
        public IActionResult GetAddresses()
        {
            var result = _addressService.GetAddresses();
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("GetAddressByUserId")]
        public IActionResult GetAddressByUserId(Guid userId)
        {
            var result = _addressService.GetAddressesByUserId(userId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("GetAddressById")]
        public IActionResult GetAddressById(Guid addressId)
        {
            var result = _addressService.GetAddressById(addressId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
