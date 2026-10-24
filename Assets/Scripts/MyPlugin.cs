using System.Runtime.InteropServices;
using UnityEngine;

[StructLayout(LayoutKind.Sequential)]
public struct Vector2D
{
    public float x;
    public float y;
}

public static class MyPlugin
{
    [DllImport("DLL_2024_Unity")]
    private static extern int GetID();

    [DllImport("DLL_2024_Unity")]
    private static extern void SetID(int id);

    [DllImport("DLL_2024_Unity")]
    private static extern Vector2D GetPosition();

    [DllImport("DLL_2024_Unity")]
    private static extern void SetPosition(float x, float y);

    public static int ID
    {
        get { return GetID(); }
        set { SetID(value); }
    }

    public static Vector2D Position
    {
        get { return GetPosition(); }
        set { SetPosition(value.x, value.y); }
    }
}