using app.Core;
using AutoMapper;

namespace app.Service.Base
{
    public class BaseService
    {
        public readonly IUnitOfWorks _unitOfWork;
        public readonly IMapper _mapper;

        public BaseService(IUnitOfWorks unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
