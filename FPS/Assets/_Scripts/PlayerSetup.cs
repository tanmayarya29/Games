using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] compnentsToDisable;

    Camera sceneCam;

    [SerializeField]
    string remlyrname = "RemotePlrLyr";


    void Start()
    {
        if (!isLocalPlayer)
        {
            disableComp();
            assignRemLyr();
        }
        else
        {
            sceneCam = Camera.main;
            if (sceneCam != null)
            {
                sceneCam.gameObject.SetActive(false);
            }
        }
    }

    void assignRemLyr()
    {
        gameObject.layer = LayerMask.NameToLayer(remlyrname);

    }
    void disableComp()
    {
        for (int i = 0; i < compnentsToDisable.Length; i++)
        {
            compnentsToDisable[i].enabled = false;
        }

    }
    void OnDisable()
    {
        if (sceneCam != null)
        {
            sceneCam.gameObject.SetActive(true);
        }
    }


}
