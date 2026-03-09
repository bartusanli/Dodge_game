using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flySpeed;
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        MoveToPlayer();
                if(transform.position  == player.transform.position){
            DestroyWhenReached();
        }
        
    }
    void MoveToPlayer(){
        transform.position = 
        Vector3.MoveTowards(transform.position, player.transform.position, flySpeed*Time.deltaTime);

    }
    void DestroyWhenReached(){
        Destroy(gameObject);
    }

}
