namespace LCLMS.RequestModel
{
    public class BaseRequestModel
    {
        public BaseRequestModel()
        {
            Page = 1;
            PerpageCount = 10;

        }

        public int Page { get; set; }
        public int PerpageCount { get; set; }
        public string OrderBy { get; set; }
        public bool IsAcesnding { get; set; }
    }
}