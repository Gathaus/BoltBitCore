namespace BoltBit.Core.Helpers;

public static class Guards
{
    public static void NullGuard(object objectToCheck)
    {
        if (objectToCheck == null) throw new ArgumentNullException(nameof(objectToCheck));
    }
}
