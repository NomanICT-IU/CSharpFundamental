using System.Collections.Generic;
using System.Linq;

namespace ExceptionHandling
{
    internal class Service
    {
        private List<User> _users = new List<User>
        {
            new User{Id = 1, Name = "Noman"},
            new User{Id = 2,Name = "Showon"}
        };

        public User GetUserId(int id)
        {
            InvalidUserIdException.ValidateId(id);
            var user = _users.First(x => x.Id == id);
            return user;
        }

        public void Clear() => _users.Clear();
    }
}
