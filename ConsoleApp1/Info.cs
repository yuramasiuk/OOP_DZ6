using System.Reflection;
using System.Text.Json.Serialization;

namespace hometask
{
    class House
    {
       // [JsonIgnore]
        public int PublishingHouseId { get; set; }

        //[JsonPropertyName("Name")]
        public string? Title { get; set; }

        public CPublishingHouse? PublishingHouse { get; set;}
        public House(int publishingHouseId, string title, CPublishingHouse publishingHouse)
        {
            PublishingHouseId = publishingHouseId;
            Title = title;
            PublishingHouse = publishingHouse;
        }
    }

}
