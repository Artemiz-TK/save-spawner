using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float intervalo = 2f;
    public float raio = 5f;

    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo >= intervalo)
        {
            tempo = 0f;
        }
    }

    void Spawnar()
    {
        Vector3 pos = transform.position + new Vector3(
            Random.Range(-raio, raio),
            0,
            Random.Range(-raio, raio)
        );

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
