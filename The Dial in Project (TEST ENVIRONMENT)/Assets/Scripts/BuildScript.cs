using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript {
    [MenuItem("Build/Build Project")]
    public static void BuildGame() {
        string path = Path.Combine(Application.dataPath, "../Builds/MyGame.exe");
        
        Debug.Log("Building game to: " + path); 

        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Scenes/MainScene.unity" }, 
            path, 
            BuildTarget.StandaloneWindows, 
            BuildOptions.None
        );

        EditorUtility.RevealInFinder(path);
    }
}