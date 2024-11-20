using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Magazine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnMagazine()
    {
        Instantiate(Magazine, new Vector3(-0.993f, 0.91f, 1.481f), Quaternion.identity);
    }
}
