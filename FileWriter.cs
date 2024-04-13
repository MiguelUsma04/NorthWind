using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    public class FileWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            File.AppendAllText("AppLogs.txt",
                string.Format("ConsoleWriter: {0}, {1}, {2}",
            action.CreatedDateTime, action.User, action.Description));
        }
    }
}