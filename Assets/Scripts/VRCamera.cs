using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCamera : MonoBehaviour
{
    [SerializeField]
    Color rayColor = Color.green;
    [SerializeField, Range(0.1f, 100f)]
    float rayDistance = 5f;
    [SerializeField]
    LayerMask rayLayerDetection;
    RaycastHit hit;
    [SerializeField]
    Transform reticleTrs;

    [SerializeField]
    Vector3 initialScale;

    bool objectTouched;

    void Start()
    {
        reticleTrs.localScale = initialScale;
    }

    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, rayLayerDetection))
        {
            Target target = hit.collider.GetComponent<Target>();
            target.HandleColor();
            reticleTrs.localPosition = hit.point;
            reticleTrs.localScale = initialScale * hit.distance;
            reticleTrs.localRotation = Quaternion.LookRotation(hit.normal);
        }
        else
        {
            reticleTrs.localScale = initialScale;
            reticleTrs.localPosition = Vector3.zero;
            reticleTrs.localRotation = Quaternion.identity;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
    }
}
