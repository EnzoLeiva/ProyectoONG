﻿using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class MemberService: IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<MemberModel>> GetMembers()
        {
            return await _unitOfWork.MemberRepository.GetAll();
        }


        public async Task<MemberModel> Post(MemberCreateDto memberCreateDto)
        {
            var mapper = new EntityMapper();
            var member = mapper.FromMemberCreateDtoToMember(memberCreateDto);

            await _unitOfWork.MemberRepository.Insert(member);
            await _unitOfWork.SaveChangesAsync();

            return member;
        }
    }
}
