﻿using System.IO;
using NuGet;
using SymbolSource.Gateway.Core;
using Version = SymbolSource.Server.Management.Client.WebService.Version;

namespace SymbolSource.Gateway.NuGet.Core
{
    public interface INuGetGatewayVersionExtractor : IGatewayVersionExtractor
    {
        
    }

    public class NuGetGatewayVersionExtractor : INuGetGatewayVersionExtractor
    {
        public Version Extract(Stream stream)
        {
            var version = NuGetTranslator.ConvertToVersion(stream);            
            return version;
        }
    }
}