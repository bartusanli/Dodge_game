using UnityEngine;

public class Spinner : MonoBehaviour
{
     [SerializeField] float moveSpeedx,moveSpeedy,moveSpeedz;

    void Start()
    {
        
    }

    void Update()
    {
        float    x=Time.deltaTime*moveSpeedx,
                 y=Time.deltaTime*moveSpeedy,
                 z=Time.deltaTime*moveSpeedz;
        transform.Rotate(x*Time.deltaTime, y*Time.deltaTime, z*Time.deltaTime);
    }
}
