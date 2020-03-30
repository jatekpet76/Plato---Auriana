using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorkController : MonoBehaviour
{
    float _time = -1;
    bool _enabled = false;

    public float duration = 2;
    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckStatus());
    }

    IEnumerator CheckStatus()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            if (_enabled && _time < Time.time)
            {
                _enabled = false;

                Debug.Log("FireWorkController Stop");
            }
        }

    }

    public void Invoke()
    {
        _time = Time.time + duration;

        _enabled = true;

        Debug.Log("FireWorkController Invoke");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("FireWorkController SetActive ${_enabled}");
        particles.SetActive(_enabled);
    }
}
