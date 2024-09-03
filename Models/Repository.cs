namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Melike",Email = "mlk99@gmail.com",Phone = "111111111",WillAttend = true});
            _users.Add(new UserInfo() { Id = 2, Name = "Hakan", Email = "hkn95@gmail.com", Phone = "22222222", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Derya", Email = "dry95@gmail.com", Phone = "33333333", WillAttend = false });
        }

        public static List<UserInfo> Users { 
            get { 
                return _users; 
            } 
        }   
   
    public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count +1 ;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
