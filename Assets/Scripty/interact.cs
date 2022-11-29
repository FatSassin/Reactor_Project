using UnityEngine;
/// <summary>
/// Attach this class to make object pickable.
/// </summary>
[RequireComponent(typeof(Rigidbody))]


public class interact : MonoBehaviour
{
    public bool pozdrawiam;
    /// <summary>
    /// Method called on initialization.
    /// </summary>

    private void Awake()
    {
        pozdrawiam = false;
    }
    private void Update()
    {
        if (pozdrawiam == false)
            transform.position = new Vector3(0, 90, 0);
        else
            transform.position = Vector3.zero;

    }
}