using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRTeleportInteractor : XRRayInteractor
{
    public LayerMask teleportBlockMask;

    public override void GetValidTargets(List<XRBaseInteractable> validTargets)
    {
        base.GetValidTargets(validTargets);

        //if (validTargets.Count > 0 && validTargets[0].interactionLayerMask == LayerMask.GetMask("TeleportBlock"))
        //{
        //    validTargets.Clear();
        //}


        GetCurrentRaycastHit(out RaycastHit hit);
        if (hit.collider.gameObject.layer == LayerMask.GetMask("TeleportBlock"))
        {
            validTargets.Clear();
        }
    }
}
