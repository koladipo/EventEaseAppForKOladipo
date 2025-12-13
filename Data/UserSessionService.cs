namespace EventApp.Data
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }
        public string? UserEmail { get; private set; }
        public int? CurrentEventId { get; private set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);

        public void StartSession(string name, string email)
        {
            UserName = name;
            UserEmail = email;
        }

        public void EndSession()
        {
            UserName = null;
            UserEmail = null;
            CurrentEventId = null;
        }

        public void SetCurrentEvent(int eventId)
        {
            CurrentEventId = eventId;
        }
    }
}
