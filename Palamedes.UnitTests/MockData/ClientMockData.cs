using System;
using Palamedes.API.Models;

namespace Palamedes.UnitTests.MockData
{
    public class ClientMockData
    {
        public const string bearerToken300D = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWFudTA5aWNlQGdtYWlsLmNvbSIsImV4cCI6MTYwNDc2MzU5MSwiaXNzIjoicGFsYW1lZGVzLmJlIiwiYXVkIjoicGFsYW1lZGVzLmJlIn0.LjcpbvjRNd7Sku3g__6GrE5kLeUDR-12FozKwtrSjBU";
        public const string ApiBaseUri = "https://api.palamedes.be/";
        public const string ValidUserEmail = "johndoe@email.com";

        // MockId
        public static string GoodUserId = "b9842a50-335a-42c1-ac56-82b4c4b1768f";
        public static string BadStringId = "sdkdskqskdsmfdklsfd";
        public static int GoodIntId = 5;


        //mock entities
        public static Art GoodArt = new Art { Id = 1L, ArtistId = 1L, Name = "Nachtegaal", Created = DateTime.Now, Description = "Dit is een nachtegaal", CategoryId = 1L, Price = 3759.99M, ImageName = "vogel.jpg" };
        public static Art EmptyArt = new Art();
        public static Artist GoodArtist = new Artist { Id = 2L, ArtistName = "Jenny", Dob = DateTime.Now, UserId = "2" };
        public static Artist EmptyArtist = new Artist();
        public static Category GoodCategory = new Category { Id = 6L, Name = "Filmkunst" };
        public static Category EmptyCategory = new Category();
    }
}
