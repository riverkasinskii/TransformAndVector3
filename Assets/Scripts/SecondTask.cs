using UnityEngine;

public class SecondTask : MonoBehaviour
{        
    [SerializeField] private Transform[] runner = new Transform[5];
    [SerializeField] private Transform _wand;
    [SerializeField] private float _speed;
    private int i = 0;   

    private void Start()
    {
        _wand.SetParent(runner[0]);                
    }

    private void Update()
    {
        Running();        
    }

    private void Running()
    {
        if (i < runner.Length - 1)
        {
            runner[i].position = Vector3.MoveTowards(runner[i].position, runner[i+1].position, Time.deltaTime * _speed);

            runner[i].LookAt(runner[i+1].position);            

            if (runner[i].position == runner[i + 1].position)
            {
                _wand.SetParent(runner[i+1]);
                i++;                
            }
        }
        else
        {
            runner[i].position = Vector3.MoveTowards(runner[i].position, runner[0].position, Time.deltaTime * _speed);

            runner[i].LookAt(runner[0].position);

            if (runner[i].position == runner[0].position)
            {
                _wand.SetParent(runner[0]);
                i = 0;                
            }
        }
    }
}
