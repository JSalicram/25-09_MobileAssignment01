using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCube : MonoBehaviour
{
    public float m_Speed = 20f;

    private Vector3 m_Direction = Vector3.forward;

    public void ToggleDirection()
    {
        Debug.Log("Toggling direction");

        if (m_Direction == Vector3.forward)
        {
            m_Direction = Vector3.back;
        }
        else
        {
            m_Direction = Vector3.forward;
        }
    }

    void Update()
    {
        transform.Translate(m_Direction * Time.deltaTime * m_Speed);
    }
}
