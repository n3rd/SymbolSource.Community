using SymbolSource.Server.Management.Client.WebService;

namespace SymbolSource.Server.Management.Client
{
    public interface IManagementSessionFactory : IManagementPreauthentication
    {
        IManagementSession Create(Caller caller);
    }
}
