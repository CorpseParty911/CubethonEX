using UnityEngine;

public class KinematicFlee : MonoBehaviour
{
    GameObject target;

    public float maxSpeed = 1f;

    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Vector3 resVelocity = transform.position - target.transform.position;

        Vector3.Normalize(resVelocity);
        resVelocity *= maxSpeed;

        if (resVelocity.magnitude > 0)
        {
            this.transform.eulerAngles = new Vector3(0, Mathf.Atan2(resVelocity.x, resVelocity.z) * (180 / Mathf.PI), 0);
        }
        GetComponent<Rigidbody>().velocity = resVelocity;
    }
}
