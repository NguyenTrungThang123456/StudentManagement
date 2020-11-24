using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using StudentManagement.Application.Interfaces;
using StudentManagement.Application.Students.Commands;

namespace StudentManagement.Application.Students.Handlers
{
    public class UpdateStudentCommandHandler:IRequestHandler<UpdateStudentCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Students.Update(_mapper.Map<StudentManagement.Core.Entities.Student>(request));
            return result;
        }
    }
}
