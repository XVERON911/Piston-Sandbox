using UnityEngine;

public class FixAxisCylincer : MonoBehaviour
{
    private Transform CylinderTransfrom;
    void Start()
    {
        CylinderTransfrom = this.GetComponent<Transform>();
    }
    
    void Update()
    {
        if(CylinderTransfrom.position.x >= 0.08f || CylinderTransfrom.position.x <= -0.08f)
        {
            CylinderTransfrom.position = new Vector3(0f, CylinderTransfrom.position.y, 0f);
            Debug.Log("Set Transform Correctly");
        }
    }
}
