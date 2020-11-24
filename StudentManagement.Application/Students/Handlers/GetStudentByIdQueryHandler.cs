using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using StudentManagement.Application.Interfaces;
using StudentManagement.Application.Students.Dto;
using StudentManagement.Application.Students.Queries;

namespace StudentManagement.Application.Students.Handlers
{
    public class GetStudentByIdQueryHandler:IRequestHandler<GetStudentByIdQuery,StudentDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetStudentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<StudentDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Students.Get(request.Id);
            return _mapper.Map<StudentDto>(result);
        }
    }
}
