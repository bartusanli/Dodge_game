using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float flySpeed;

    void Awake() {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        if(transform.position  == playerPosition){
            DestroyWhenReached();
        }
        
    }
    void MoveToPlayer(){
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, flySpeed*Time.deltaTime);

    }
    void DestroyWhenReached(){
        Destroy(gameObject);
    }

}
