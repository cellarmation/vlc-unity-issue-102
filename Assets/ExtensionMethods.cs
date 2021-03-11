public static class ExtensionMethods
{
    public static void Convert(this System.Numerics.Vector3 a, ref UnityEngine.Vector3 b)
    {
        b.x = a.X;
        b.y = a.Y;
        b.z = -a.Z;
    }

    public static void Convert(this System.Numerics.Quaternion a, ref UnityEngine.Quaternion b)
    {
        b.x = -a.X;
        b.y = -a.Y;
        b.z = a.Z;
        b.w = a.W;
    }
}