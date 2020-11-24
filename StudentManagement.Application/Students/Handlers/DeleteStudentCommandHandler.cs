using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using StudentManagement.Application.Interfaces;
using StudentManagement.Application.Students.Commands;

namespace StudentManagement.Application.Students.Handlers
{
    public class DeleteStudentCommandHandler:IRequestHandler<DeleteStudentCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteStudentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Students.Delete(request.Id);
            return result;
        }
    }
}
