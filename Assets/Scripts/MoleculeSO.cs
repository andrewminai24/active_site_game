using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Molecule", menuName = "Inventory/Molecule", order = 1)]
public class MoleculeSO : ScriptableObject
{
    public GameObject atomicPreview;
    public Sprite thumbnail;
    public string name = "Molecule";
    public string compound = "Compound";
    //public TextAsset molFile;    // maybe not useful
}
