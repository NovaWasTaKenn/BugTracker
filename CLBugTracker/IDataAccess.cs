namespace Bugtracker
{
    public interface IDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sqlCommand, U parameters);
        Task SaveData<T>(string sqlCommand, T parameters);
    }
}