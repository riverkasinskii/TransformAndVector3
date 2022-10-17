using UnityEngine;

public class FirstTask : MonoBehaviour
{    
    [SerializeField] private float _speed;
    private readonly Vector3[] vector3 = new Vector3[4];
    private Vector3 _target;
    private bool _isForward;     
        
    private void Start()
    {                
        vector3[0] = new Vector3(0, 0, 0);
        vector3[1] = new Vector3(10, 0, 0);
        vector3[2] = new Vector3(10, 0, 10);
        vector3[3] = new Vector3(0, 0, 10);

        _isForward = true;
        _target = vector3[0];
        transform.position = _target;
    }
        
    private void Update()
    {        
        transform.position = Vector3.MoveTowards(transform.position, _target, Time.deltaTime * _speed);
                
        if (transform.position == _target)
        {
            if (_isForward == true)
            {
                if (_target == vector3[0])
                {
                    _target = vector3[1];
                }
                else if (_target == vector3[1])
                {
                    _target = vector3[2];
                }
                else if (_target == vector3[2])
                {
                    _target = vector3[3];
                }
                else if (_target == vector3[3])
                {
                    _target = vector3[0];
                    _isForward = false;
                }                
            }
            else
            {
                if (_target == vector3[0])
                {
                    _target = vector3[3];
                }
                else if (_target == vector3[3])
                {
                    _target = vector3[2];
                }
                else if (_target == vector3[2])
                {
                    _target = vector3[1];
                }
                else if (_target == vector3[1])
                {
                    _target = vector3[0];
                    _isForward = true;
                }                
            }      
            
            transform.LookAt(_target);
        }
        
    }
}
