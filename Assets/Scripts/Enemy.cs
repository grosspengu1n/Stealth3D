using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;

    public float fieldOfViewAngle = 90f;
    public float killRadius = 5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        float angleToPlayer = Vector3.Angle(transform.forward, directionToPlayer);

        if (angleToPlayer < fieldOfViewAngle * 0.5f)
        {
            if (Vector3.Dot(transform.forward, directionToPlayer.normalized) > 0.5f)
            {
                GameManager.visible = false;
                Debug.Log("Enemy cant see you");


                if (Vector3.Distance(transform.position, player.position) <= killRadius)
                {
                    GameManager.killable = true;
                    Debug.Log("Press F to kill");
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        Destroy(gameObject);
                    }


                }
                else
                {
                    GameManager.killable = false;
                }


            }
            else
            {
                GameManager.visible = true;
            }
        }
    }
}

