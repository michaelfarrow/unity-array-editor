using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    [System.Serializable]
    public class NameList : List<string> { }

    [FriendlyArray]
    public NameList namesCustomListType;

}
