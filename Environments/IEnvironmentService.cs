namespace BoltBit.Core.Environments;

public interface IEnvironmentService
{
    string? GetEnvironment();

    bool IsDevelopment();
}