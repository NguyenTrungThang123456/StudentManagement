using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using StudentManagement.Application.Interfaces;
using StudentManagement.Application.Students.Dto;
using StudentManagement.Application.Students.Queries;

namespace StudentManagement.Application.Students.Handlers
{
    public class GetAllStudentsQueryHandler:IRequestHandler<GetAllStudentsQuery,List<StudentDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllStudentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StudentDto>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Students.GetAll();
            return _mapper.Map<List<StudentDto>>(result.ToList());
        }
    }
}
