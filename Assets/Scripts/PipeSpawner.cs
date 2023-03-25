using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float _timer;
    public float height = 5;
    private int _pipeColor;
    public GameObject prefabPipe;
    public GameObject prefabRedPipe;

    // Update is called once per frame
    void Update()
    {
        if (_timer > repeatRate)
        {
            _timer = 0;
            SpawnPipe();
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        _pipeColor = Random.Range(0, 2);
        GameObject newPipe;

        if (_pipeColor == 0)
        {
            newPipe = Instantiate(prefabPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }
        else if (_pipeColor == 1)
        {
            newPipe = Instantiate(prefabRedPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }
    }
}
