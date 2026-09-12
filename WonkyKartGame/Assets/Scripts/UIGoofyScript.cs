using UnityEngine;

public class UIGoofyScript : MonoBehaviour
{
    private GameObject self;
    public int rotSpeed;
    //private Vector3 rotSpeed = Vector3.forward * rotSpeed;
    private void Awake()
    {
        self = gameObject;
    }
    private void FixedUpdate()
    {
        self.transform.Rotate(transform.rotation.eulerAngles * Mathf.Sin(rotSpeed));
        rotSpeed += 1;
    }
}
