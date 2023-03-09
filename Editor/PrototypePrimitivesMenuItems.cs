using UnityEditor;
using UnityEngine;

public class PrototypePrimitivesMenuItems 
{
    /// Add a menu item to create custom GameObjects.
    // Priority 10 ensures it is grouped with the other menu items of the same kind
    // and propagated to the hierarchy dropdown and hierarchy context menus.
    [MenuItem("GameObject/3D Object/Cone", false, 110)]
    static void CreateCone(MenuCommand menuCommand)
    {
        var cone = AssetDatabase.LoadMainAssetAtPath("Packages/com.hdyar.prototype-primitives/Models/cone.fbx");
        var go = (GameObject)GameObject.Instantiate(cone);
        go.name = "Cone";
        // Ensure it gets reparented if this was a context click (otherwise does nothing)
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }

    [MenuItem("GameObject/3D Object/Torus", false, 111)]
    static void CreateTorus(MenuCommand menuCommand)
    {
        var cone = AssetDatabase.LoadMainAssetAtPath("Packages/com.hdyar.prototype-primitives/Models/torus.fbx");
        var go = (GameObject)GameObject.Instantiate(cone);
        go.name = "Torus";
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }

    [MenuItem("GameObject/3D Object/Monkey", false, 111)]
    static void CreateMonkey(MenuCommand menuCommand)
    {
        var cone = AssetDatabase.LoadMainAssetAtPath("Packages/com.hdyar.prototype-primitives/Models/suzanne.fbx");
        var go = (GameObject)GameObject.Instantiate(cone);
        go.name = "Suzanne";
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }
}
