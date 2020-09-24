using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0f, Random.Range(-2, 3), 0f);
            Destroy(newpipe, 3);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
