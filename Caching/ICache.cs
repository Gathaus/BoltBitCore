namespace BoltBit.Core.Caching;

public interface ICache
{
    T Get<T>(string key);
    void Set<T>(string key, T value);
    void Remove(string key);
}
