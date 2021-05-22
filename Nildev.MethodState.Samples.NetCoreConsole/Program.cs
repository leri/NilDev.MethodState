using NilDev.MethodState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nildev.MethodState.Samples.NetCoreConsole
{
    class Program
    {
        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public class UserAlreadyExists
        {
            public User User { get; }

            public UserAlreadyExists(User user)
            {
                User = user;
            }
        }

        public class InvalidUserData
        {
            public string Error { get; }

            public InvalidUserData(string error)
            {
                Error = error;
            }
        }

        public class UserStore
        {
            private readonly IDictionary<int, User> _users = new Dictionary<int, User>
            {
                {
                    1,
                    new User
                    {
                        Id = 1,
                        Name = "Joe"
                    }
                },

                {
                    2,
                    new User
                    {
                        Id = 2,
                        Name = "Tom"
                    }
                }
            };

            public MethodState<User> GetById(int id)
            {
                _users.TryGetValue(id, out User user);

                return user;
            }

            public async Task<MethodState<User, InvalidUserData, UserAlreadyExists>> AddUserAsync(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    return new InvalidUserData("Given username is empty");
                }

                var getUserByNameState = await GetByNameAsync(name);

                return await getUserByNameState.Observe(GenerateUserAlreadyExists, () => AddNonExistentUser(name));
            }

            public async Task<MethodState<User>> GetByNameAsync(string name)
            {
                await Task.Delay(1000);

                var user = _users?.Values?.FirstOrDefault(u => u?.Name == name);

                return user;
            }

            private async Task<MethodState<User, InvalidUserData, UserAlreadyExists>> AddNonExistentUser(string name)
            {
                await Task.Delay(1000);
                
                int id = _users.Count + 1;
                var newUser = new User { Id = id, Name = name };

                _users.Add(id, newUser);

                return newUser;
            }

            private Task<MethodState<User, InvalidUserData, UserAlreadyExists>> GenerateUserAlreadyExists(User existingUser) =>
                Task.FromResult<MethodState<User, InvalidUserData, UserAlreadyExists>>(new UserAlreadyExists(existingUser));
        }

        public interface IActionResult
        {
            int StatusCode { get; }

            string Body { get; }
        }

        public class NotFound : IActionResult
        {
            public int StatusCode => 404;

            public string Body => "Not found.";
        }

        public class Ok : IActionResult
        {
            public int StatusCode => 200;

            public string Body { get; }

            public Ok(string body)
            {
                Body = body;
            }
        }

        public class BadRequest : IActionResult
        {
            public int StatusCode => 400;

            public string Body { get; }

            public BadRequest(string message)
            {
                Body = message;
            }
        }

        static async Task Main(string[] args)
        {
            var userStore = new UserStore();

            while (true)
            {
                Console.WriteLine("Enter user id to find the user name:");
                string input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                if (int.TryParse(input, out int id))
                {
                    var state = userStore.GetById(id);
                    var actionResult = state.Observe<IActionResult>(UserFound, UserNotFound);

                    Console.WriteLine($@"Emulating http response to retreive user by entered id: Status code: {actionResult.StatusCode}, body: ""{actionResult.Body}""");

                    if (actionResult.StatusCode == 404)
                    {
                        Console.WriteLine("Please enter the name to add the user:");
                        string name = Console.ReadLine();

                        var addUserState = await userStore.AddUserAsync(name);

                        var addUserResult = addUserState.Observe<IActionResult>(UserAdded, OnErrorAddingUser, OnUserAlreadyExists, UserNotFound);

                        Console.WriteLine($@"Emulating http response to insert a new user by entered id: Status code: {addUserResult.StatusCode}, body: ""{addUserResult.Body}""");
                    }
                }
            }
        }

        private static NotFound UserNotFound() => new NotFound();

        public static Ok UserFound(User user) => new Ok($@"User ""#{user.Id} {user.Name}"" found.");

        public static Ok UserAdded(User user) => new Ok($@"User ""#{user.Id} {user.Name}"" successfully added.");

        public static BadRequest OnErrorAddingUser(InvalidUserData invalidUserData) => new BadRequest(invalidUserData.Error);

        public static BadRequest OnUserAlreadyExists(UserAlreadyExists userAlreadyExists) => new BadRequest($@"User ""#{userAlreadyExists.User.Id} {userAlreadyExists.User.Name}"" already exists.");
    }
}
