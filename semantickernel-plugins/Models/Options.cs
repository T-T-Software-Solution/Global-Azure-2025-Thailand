using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semantickernel_plugins;

public class JwtOptions
{
    public string? Key { get; set; }
}

public class AuthOptions
{
    public string? AdminUser { get; set; }
    public string? AdminPassword { get; set; }
}

public class SoftwareOptions
{
    public string? Version { get; set; }
}

public class AzureOpenAIOptions
{
    public string? ChatModel { get; set; }
    public string? Endpoint { get; set; }
    public string? ApiKey { get; set; }
}
