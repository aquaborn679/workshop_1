using UnityEngine;

public class RigidbodyMod : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private int index;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.isKinematic = false;
            _rb.linearDamping = index;
            _rb.useGravity = true;
            if (index == 0)
            {
                _rb.mass = 100.0f;
                _rb.angularDamping = 0.05f;
            }
            else if (index == 1)
            {
                _rb.mass = 1.0f;
                _rb.angularDamping = 1f;
            }
            else
            {
                _rb.mass = 35.0f;
                _rb.angularDamping = 0.1f;
            }
        }
    }
}