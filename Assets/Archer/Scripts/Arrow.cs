using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Vector3 m_target;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void setTarget(Vector3 target)
    {
        m_target = target;
    }
}
