using UnityEngine;

public static class ScreenBorder
{
    private static Vector3 _mainCamera = Camera.main.ViewportToWorldPoint(Vector3.one);
    public static float Left => -_mainCamera.x;
    public static float Right => _mainCamera.x;
    public static float Top => -_mainCamera.z;
    public static float Bottom => _mainCamera.z;
}
