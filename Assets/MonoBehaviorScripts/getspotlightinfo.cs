using UnityEngine;

public class GetSpotlightInfo : MonoBehaviour
{
    public Light spotLight;
    public Renderer renderer;
    void Update()
    {
        if (spotLight != null)
        {
            renderer.material.SetVector("_CustomSpotPosition", spotLight.transform.position);
            renderer.material.SetVector("_CustomSpotDirection", spotLight.transform.forward);
            
            float cosAngle = Mathf.Cos(spotLight.spotAngle * 0.5f * Mathf.Deg2Rad);
            renderer.material.SetFloat("_CustomSpotAngleCos", cosAngle);
        }
    }
}
