using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditorBuilder : WorldBuilder
{
    public int tilesAroundEachVertex = 6;
    public int tilesExpansion;
    public GameObject defaultTile;
    public override int MaxExpansion()
    {
        HM.SetTileType(tilesAroundEachVertex);
        return tilesExpansion;
    }
    public override GameObject GetTile(string coord)
    {
        return Instantiate(defaultTile);
    }
}