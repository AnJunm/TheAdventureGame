using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionDestination : MonoBehaviour
{
    // Start is called before the first frame update
    public enum DestinationTag
    {

        ENTER,A,B,C
    }

    public DestinationTag destinationTag;
}
