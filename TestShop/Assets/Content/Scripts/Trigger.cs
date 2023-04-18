using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent<Player> OnEnterTrigger,OnExitTrigger;
    private Player curPlayer;
    [SerializeField]
    private GameObject areaZoneParticle;

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player!=null)
        {
            curPlayer = player;
            OnEnterTrigger.Invoke(curPlayer);
        }
        areaZoneParticle.gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>(); 
        if (player!=null)
        {
            OnExitTrigger.Invoke(curPlayer);
            curPlayer = null;
        }
        areaZoneParticle.gameObject.SetActive(true);
    }
}