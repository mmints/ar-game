# AR Game

#### Unity, ARToolkit, Android Deployment

1. Download newest Unity, JDK, Android SDK, ARToolkit5 Tools, ARToolkit5 for Unity
    - https://unity3d.com/de/get-unity/download
    - https://artoolkit.org/download-artoolkit-sdk
    - Create Unity Account if needed
2. Open Project (/ ARToolkit sample scene "Standard Asset Example Project" / "CubemarkerScene")
3. Open Unity, import ARToolkit Tools, ARToolkit Package
    - Assets->Import Package, only select those 3 Folders!
      ![screenshot1](https://cloud.githubusercontent.com/assets/16772796/26814401/7d36be58-4ad9-11e7-9582-7f45398bd31e.png)
4. Switch Project Type to Android (File->Build Settings)
5. Unity Edit->Preferences->External Tools set JDK Path and Android SDK Path
6. [Print example marker](https://github.com/artoolkit/artoolkit5/blob/master/doc/patterns/Hiro%20pattern.pdf)
7. Build Settings -> Build (Export to _game.apk_)
8. Install using Unity, Android Debug Bridge(_'adb install -r game.apk'_) or copy manually
9. Change AR params if needed (Unity SceneGraph->ARToolKit->Inspektor, Threshold und Cutoff)




##### Troubleshooting

- "unable to list target platforms": Apply Android SDK patch tools_r25.2.3-windows.zip. [\[Help\]](http://answers.unity3d.com/questions/1320634/unable-to-list-target-platforms-when-i-try-to-buil.html)
- "Plugins colliding error": delete _libARWrapper.so_ and _libc++\_shared.so_ in _PROJECT_DIR\Assets\Plugins\Android_




##### Notes

- According to docs, an older Unity version is compatible with ARToolkit. This is not true, new Versions are also supported
- Known issue: Autofocus / camera resolution fix. Solution available but **worse tracking?**
  - dest: _PROJECT\_DIR\Assets\Plugins\Android\UnityARPlayer.jar_
    - default Unity project path: _C:\Users\Public\Documents\Unity\Projects_
  - **Replace** this file (or move to entirely else Folder) with [this](http://augmentmy.world/wp-content/uploads/2016/10/UnityARPlayerU2.zip)
  - ([Source](http://augmentmy.world/augmented-reality-unity-games-artoolkit-video-resolution-autofocus))
To solve these issues, we may want to follow the issue trackers/forum
  
  
#### Tips & Tricks

-  Change Object Material: Mesh Renderer -> Material -> Element 0 -> Click small far right circle
-  Asset Store allows searching for free Assets (Textures, Shaders)
-  Invisible boxes by disabling Mesh Renderer
-  Object Layer should be "AR Background 2"
-  Physically interacting Objects need "RigidBody" component
-  "Marker Scene" contains "AR Tracked Object" component, set "stay visible" in seconds (f.i. 0.05)
-  Tilt-Device-Physics requires Accelerometer C# Code Snippet
   - Script File and Class name must match  
        
#### Game Object Setup

##### Flipper
- Hinge Joint
    - Spring: 5000
    - Damper: 15
    - Limit Min: 0 (left), -45 (right)
    - Limit Max: 45 (left), 0 (right)
- Flipper Controller
    - Input Button: left or right button from canvas (Canvas has to be part of the scene!)
    - Rest Position: 0 (L & R)
    - -45 (left), 45 (right)
    - Input Name: name of the input source witch is setted in the project preferences

  
  
#### References

- [Scripts in ARToolKit for Unity](https://artoolkit.org/documentation/doku.php?id=6_Unity:unity_scripts)
- [Marker Patterns](https://github.com/artoolkit/artoolkit5/tree/master/doc/patterns)
- [Unity Collisions](https://docs.unity3d.com/Manual/CollidersOverview.html)
- [ARToolkit for Unity info](https://artoolkit.org/documentation/doku.php?id=6_Unity:unity_about)
- [ARToolkit issues Forum](https://archive.artoolkit.org/community/forums/viewforum.php?f=28&sid=17f117f49402077333898890cefe4ec1)
- [ARToolkit issues GitHub](https://github.com/artoolkit/arunity5/issues)