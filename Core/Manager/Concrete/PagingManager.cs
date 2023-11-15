namespace blazorWords.Core.Manager.Concrete
{
    public class PagingManager: IPagingService
    {
        private IPagingRepository _pagingManagerRepository;
        private readonly IMapper _mapper;
        
        public PagingManager(IPagingRepository pagingRepository,
            IMapper mapper)
        {
            _pagingRepository = pagingRepository;
            _mapper = mapper;
        }

        public async Task<PagingResult<ResponseDTO>> GetListForPaging(GlobalFilterModel globalFilter)
        {
            var pagingDatas= await _pagingRepository.GetListForPaging(globalFilter, x => x.Users);
            var pagingDTO = pagingDatas.Data.Select(s => _mapper.Map<ResponseDTO>(s)).ToList();
            return new PagingResult<ResponseDTO>(pagingDTO, pagingDatas.TotalItemCount,true,"");
             
        }
    }
}