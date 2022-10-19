using UnityEngine;

public class FirstTask : MonoBehaviour
{    
    [SerializeField] private float _speed;
    private readonly Vector3[] vector3 = new Vector3[4];    
    private int i = 0;

    private void Start()
    {
        vector3[0] = new Vector3(0, 0, 0);
        vector3[1] = new Vector3(10, 0, 0);
        vector3[2] = new Vector3(10, 0, 10);
        vector3[3] = new Vector3(0, 0, 10);       
        transform.position = vector3[i];
    }
        
    private void Update()
    {
        Running();        
    }

    private void Running()
    {
        if (i < vector3.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, vector3[i + 1], Time.deltaTime * _speed);

            transform.LookAt(vector3[i + 1]);

            if (transform.position == vector3[i + 1])
            {
                transform.position = vector3[i + 1];
                i++;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, vector3[0], Time.deltaTime * _speed);

            transform.LookAt(vector3[0]);

            if (transform.position == vector3[0])
            {                
                i = 0;
                transform.position = vector3[i];
            }
        }
    }
}
