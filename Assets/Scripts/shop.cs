
using UnityEngine;

public class shop : MonoBehaviour {

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }


	public void PurchaseStandardTurret ()
    {
        Debug.Log("standard turret selected");
        buildManager.setTurretTobuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncher()
    {
        Debug.Log("Mssile Launcher selected");
        buildManager.setTurretTobuild(buildManager.missileLauncherPrefab);
    }

    public void jesuschrist()
    {
        shut up liam;
    }
}
