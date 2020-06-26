using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using AutoMapper;

namespace BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GroupService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public IEnumerable<GroupDTO > GetAll()
        {
            var groups = _unitOfWork.ChildRepository.GetAll();
            var GroupDto = _mapper.Map<IEnumerable<GroupDTO>>(groups);
            return GroupDto;
        }
    }
}
