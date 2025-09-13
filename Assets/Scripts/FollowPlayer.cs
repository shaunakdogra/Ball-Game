using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 1, -5);
    }
}
