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
    public class ChildService : IChildService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ChildService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public IEnumerable<ChildDTO> GetAll()
        {
            var children = _unitOfWork.ChildRepository.GetAll();
            var childrenDto = _mapper.Map<IEnumerable<ChildDTO>>(children);
            return childrenDto;
        }
    }
}
