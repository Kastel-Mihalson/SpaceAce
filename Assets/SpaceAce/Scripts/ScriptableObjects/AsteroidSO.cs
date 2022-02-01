using UnityEngine;

[CreateAssetMenu(fileName = "AsteroidData", menuName = "ScriptableObjects/AsteroidSO")]
public class AsteroidSO : ScriptableObject
{
    public int value;

    public void ResetValues()
    {
        value = 0;
    }
}
