using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("/members")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<MemberModel>> GetMembers()
        {
            return await _memberService.GetMembers();           
        }

        [Authorize]
        [HttpPost]

        public async Task<IActionResult> Post([FromForm] MemberCreateDto memberCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                try
                {
                    var response = await _memberService.Post(memberCreateDto);

                    return CreatedAtAction("POST", response);
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
            }            

        }


    }
}
