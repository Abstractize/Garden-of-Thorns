using UnityEngine;
using Pathfinding;

public class EnemySprite : MonoBehaviour
{

    public AIPath aIPath;

    // Update is called once per frame
    void Update()
    {
        if(aIPath.desiredVelocity.x >= 0.1f){
            transform.localScale = new Vector3(-1f,1f,1f);
        }
        else if(aIPath.desiredVelocity.x <= 0.1f){
            transform.localScale = new Vector3(1f,1f,1f);
        }
    }
}
