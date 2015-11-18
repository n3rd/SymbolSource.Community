using System.IO;
using Version = SymbolSource.Server.Management.Client.WebService.Version;

namespace SymbolSource.Gateway.Core
{
    public interface IGatewayVersionExtractor
    {
        Version Extract(Stream stream);
    }
}