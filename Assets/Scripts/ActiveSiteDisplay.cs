using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSiteDisplay : MonoBehaviour
{
    void Start()
    {
        DisplayActiveSite();
    }

    void DisplayActiveSite()
    {
        FileManager.MetaFile[] activeSite = FileManager.GetPieces("ActiveSite");
        // TODO: update for multiple Active Sites

        MolFile molFile = new MolFile(activeSite[0]);
        // TODO: be able to select other Active Sites (if available)

        Transform activeSiteTrans = CreateTransform("ActiveSite", transform);
        
        DisplayAtoms.Display(molFile.GetAtomDetailList(), activeSiteTrans);
    }

    Transform CreateTransform(string name, Transform parent, Vector3 localPosition = default(Vector3))
    {
        Transform trans = new GameObject(name).transform;
        trans.transform.parent = parent;
        trans.transform.localPosition = localPosition;

        return trans;
    }
}
