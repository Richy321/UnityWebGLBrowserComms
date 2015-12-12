using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public GameObject cubePrefab;
    public Bounds bounds; 
    public void SpawnCube()
    {
        Vector3 randPos = GetRandomVector(bounds);
        Instantiate(cubePrefab, randPos, Quaternion.identity);
    }

    private Vector3 GetRandomVector(Bounds bounds)
    {
        return new Vector3(Random.Range(bounds.min.x, bounds.max.x), Random.Range(bounds.min.y, bounds.max.y), Random.Range(bounds.min.z, bounds.max.z));
    }
}
