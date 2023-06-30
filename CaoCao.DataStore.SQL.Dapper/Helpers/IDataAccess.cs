namespace CaoCao.DataStore.SQL.Dapper.Helpers
{
    public interface IDataAccess
    {
        void ExecuteCommand<U>(string sql, U parameter);
        List<T> Query<T, U>(string sql, U parameter);
        T QueryFirst<T, U>(string sql, U parameter);
        T QuerySingle<T, U>(string sql, U parameter);
    }
}