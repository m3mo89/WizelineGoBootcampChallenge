using System.Runtime.Serialization;

namespace WizelineGoBootcampChallenge.Models
{
    [DataContract]
    public class SearchResponse<T>
    {
        [DataMember(Name = "results")]
        public IReadOnlyList<T>? Results { get; set; }

        [DataMember(Name = "page")]
        public int PageNumber { get; set; }

        [DataMember(Name = "total_pages")]
        public int TotalPages { get; set; }

        [DataMember(Name = "total_results")]
        public int TotalResults { get; set; }
    }
}
