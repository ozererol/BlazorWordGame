namespace blazorWords.Core.Manager.Abstract
{
    public interface IPagingService
    {
        Task<PagingResult<ResponseDTO>> GetListForPaging(GlobalFilterModel globalFilter);
    }
}