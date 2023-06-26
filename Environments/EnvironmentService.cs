namespace BoltBit.Core.Environments;

public class EnvironmentService : IEnvironmentService
{
    private readonly string ENVIRONMENT_KEY = "ENVIRONMENT";


    public string GetEnvironment()
    {
        ArgumentException.ThrowIfNullOrEmpty(ENVIRONMENT_KEY + " no set");
        return Environment.GetEnvironmentVariable("ENVIRONMENT")!;
    }

    public bool IsDevelopment()
    {
        ArgumentException.ThrowIfNullOrEmpty(ENVIRONMENT_KEY + " no set");

        string environmentVariable = Environment.GetEnvironmentVariable("ENVIRONMENT")!;

        return environmentVariable == EnvironmentNames.Development;
    }
}