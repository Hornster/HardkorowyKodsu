using AutoMapper;

namespace HardkorowyKodsu_Server.Services
{
    public class BaseService
    {
        protected IMapper _mapper;
        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
