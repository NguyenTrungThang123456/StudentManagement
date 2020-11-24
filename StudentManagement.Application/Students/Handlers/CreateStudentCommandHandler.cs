using System;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using StudentManagement.Application.Interfaces;
using StudentManagement.Application.Students.Commands;
using StudentManagement.Application.Students.MappingProfiles;

namespace StudentManagement.Application.Students.Handlers
{
    public class CreateStudentCommandHandler:IRequestHandler<CreateStudentCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Students.Add(_mapper.Map<Core.Entities.Student>(request));
            return result;
        }
    }
}
