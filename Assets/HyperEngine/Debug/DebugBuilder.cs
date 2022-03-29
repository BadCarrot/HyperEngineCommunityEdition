using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBuilder : WorldBuilder
{
    public int RADIUS = 6;
    public GameObject debug_tile;

    public override int MaxExpansion()
    {
        HM.SetTileType(RADIUS);
        return RADIUS;
    }

    public override GameObject GetTile(string coord)
    {
        return Instantiate(debug_tile);
    }
}
