using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JohnController : MonoBehaviour
{
    NavMeshAgent _agent;
    Camera _camera;
    Animator _animator;

    bool _hasTarget = false;

    Vector3 _cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _camera = Camera.main;
        _cameraOffset = Camera.main.transform.position - transform.position;
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                _agent.destination = hit.point;
                _hasTarget = true;
            }
        } 
        else if (_hasTarget)
        {
            _hasTarget = Vector3.Distance(transform.position, _agent.destination) > 0.3f;
        }
        else if (!_hasTarget)
        {
            _agent.isStopped = true;
            _agent.ResetPath();
        }

        _camera.transform.position = transform.position + _cameraOffset;

        // _animator.SetBool("IsWalking", (_agent.velocity.magnitude > 0.01f));
        _animator.SetBool("IsWalking", _hasTarget);
    }

    private void FixedUpdate()
    {
        
    }
}
