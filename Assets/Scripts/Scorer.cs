using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Hits = 0;

   

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit"){
        Hits++;
        Debug.Log("You painted " + Hits +" object!");
        }
    }
}
