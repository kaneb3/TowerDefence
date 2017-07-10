
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("more than one build manager in the scene");
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

  
    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;

    }

    public void setTurretTobuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
