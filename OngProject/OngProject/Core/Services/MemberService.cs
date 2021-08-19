using OngProject.Core.DTOs;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class MemberService: IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImagenService _imagenService;

        public MemberService(IUnitOfWork unitOfWork, IImagenService imagenService)
        {
            _unitOfWork = unitOfWork;
            _imagenService = imagenService;
        }

        public async Task<IEnumerable<MemberModel>> GetMembers()
        {
            return await _unitOfWork.MemberRepository.GetAll();
        }


        public async Task<MemberModel> Post(MemberCreateDto memberCreateDto)
        {
            var mapper = new EntityMapper();
            var member = mapper.FromMemberCreateDtoToMember(memberCreateDto);

            try
            {
                member.Image = await _imagenService.Save(member.Image, memberCreateDto.Image);
                await _unitOfWork.MemberRepository.Insert(member);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return member;
        }

        public async Task<MemberModel> GetById(int id)
        {
            return await _unitOfWork.MemberRepository.GetById(id);
        }
        public async Task<bool> Delete(int Id)
        {
            try
            {
                await _unitOfWork.MemberRepository.Delete(Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.MemberRepository.EntityExists(id);
        }

        public async Task<MemberModel> Put(MemberUpdateDto memberUpdateDto, int id)
        {
            var mapper = new EntityMapper();
          
            try
            {
                MemberModel member = await _unitOfWork.MemberRepository.GetById(id);

                member = mapper.FromMemberUpdateDtoToMember(memberUpdateDto, member);

                if(memberUpdateDto.Image!=null)
                    member.Image = await _imagenService.Save(member.Image, memberUpdateDto.Image);
                await _unitOfWork.MemberRepository.Update(member);
                await _unitOfWork.SaveChangesAsync();
                return member;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); 
            }
           
        }

    }
}
