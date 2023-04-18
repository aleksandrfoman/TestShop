using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent<Player> OnEnterTrigger,OnExitTrigger;
    private Player curPlayer;
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player!=null)
        {
            curPlayer = player;
            OnEnterTrigger.Invoke(curPlayer);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>(); 
        if (player!=null)
        {
            OnExitTrigger.Invoke(curPlayer);
            curPlayer = null;
        }
    }
}