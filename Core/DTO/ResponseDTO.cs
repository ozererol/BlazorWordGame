namespace blazorWords.Core.DTO
{
    public class ResponseDTO : BaseResponse
    {
        public long LogId { get; set; } 
        public UserDto Users { get; set; }

    }
}
