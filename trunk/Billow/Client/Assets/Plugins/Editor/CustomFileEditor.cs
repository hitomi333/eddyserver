using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;

public class CustomFileEditor
{
    [MenuItem("Assets/Custom Edit %e")]
    static void Edit()
    {
        if (Selection.activeObject == null)
            return;

        var path = AssetDatabase.GetAssetPath(Selection.activeObject);
        //Debug.Log(path);

        if (path.EndsWith(".xls"))
            XlsEditor.Init(path);
    }
}
