using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace Proj.Data
{
    public class UserHub : Hub
    {
        public  List<User> Users = new List<User>()
        {
            new User()
            {
                UserName = "jdoe",
                Name = "Jon Doe",
                Address = new Address()
                {
                    Street1 = "123 Example St.",
                    City = "Nowhere",
                    State = "KS",
                    ZipCode = "12345"
                }
            },
            new User()
            {
                UserName = "adoe",
                Name = "Abe Doe",
                Address = new Address()
                {
                    Street1 = "456 Example St.",
                    City = "la",
                    State = "CA",
                    ZipCode = "12345"
                }
            },
            new User()
            {
                UserName = "rdoe",
                Name = "Ron Doe",
                Address = new Address()
                {
                    Street1 = "789 Example St.",
                    City = "denver",
                    State = "CO",
                    ZipCode = "12345"
                }
            },
            new User()
            {
                UserName = "fdoe",
                Name = "Frank Doe",
                Address = new Address()
                {
                    Street1 = "386 Example St.",
                    City = "miami",
                    State = "FL",
                    ZipCode = "12345"
                }
            }
        };
        public async Task SendUser()
        {
            Random rng = new Random();
            await Clients.Caller.SendAsync("RecieveUser", Users[rng.Next(0, Users.Count)]);
        }
    }
    public class User
    {
        public string UserName {  get; set; }
        public string Name {  get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street1 { get; set; }
        public string? Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}
