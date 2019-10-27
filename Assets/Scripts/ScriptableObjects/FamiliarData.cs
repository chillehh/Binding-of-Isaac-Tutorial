using UnityEngine;

[CreateAssetMenu(fileName = "Familiar.asset", menuName = "Familiars/FamiliarObject")]
public class FamiliarData : ScriptableObject
{
    public string familirType;
    public float speed;
    public float fireDelay;
    public GameObject bulletPrefab;
}
