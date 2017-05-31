# AR Game

#### Unity, ARToolkit, Android Deployment

 1. Download Unity 5.3.4, JDK, Android SDK. ARToolkit Tools, ARToolkit for Unity
    - https://unity3d.com/de/get-unity/download/archive
    - https://artoolkit.org/download-artoolkit-sdk
    - Create Unity Account if needed
 2. Open Unity, import ARToolkit Tools, ARtoolkit Package
    - Assets->Import Package
 3. Apply Android SDK patch tools_r25.2.3-windows.zip
    - http://answers.unity3d.com/questions/1320634/unable-to-list-target-platforms-when-i-try-to-buil.html
 4. Open ARToolkit sample scene ("Standard Asset Example Project" / "CubemarkerScene")
 5. Switch Project Type to Android (File->Build Settings)
 6. Unity Edit->Preferences->External Tools set JDK Path and Android SDK Path
 7. Print example marker
    - https://github.com/artoolkit/artoolkit5/blob/master/doc/patterns/Hiro%20pattern.pdf
 8. Autofocus / resolution fix
    - dest: _C:\Users\<BENUTZER>\Documents\Unity\ Projects\Standard\ Assets\ Example\ Project\Assets\Plugins\Android\UnityARPlayer.jar_
    - src:  http://augmentmy.world/wp-content/uploads/2016/10/UnityARPlayerU2.zip
    - **Replace** old file (or move to entirely else Folder, f.i. Downloads):
    - (Source: http://augmentmy.world/augmented-reality-unity-games-artoolkit-video-resolution-autofocus)
 9. Build Settings -> Build (Export to _game.apk_)
 10. On "Plugins colliding error", delete _libARWrapper.so_ and _libc++\_shared.so_ in _C:\Users\<BENUTZER>\Documents\Unity\ Projects\Standard\ Assets\ Example\ Project\Assets\Plugins\Android_
 11. Install using Android Debug Bridge: _'adb install -r game.apk'_ or copy manually
 12. Change AR params if needed (Unity SceneGraph->ARToolKit->Inspektor, Threshold und Cutoff)

      
      

#### Tips & Tricks

-  Change Object Material: Mesh Renderer -> Material -> Element 0 -> Click small far right circle

-  Asset Store allows searching for free Assets (Textures, Shaders)

-  Invisible boxes by disabling Mesh Renderer

-  Object Layer should be "AR Background 2"

-  Physically interacting Objects need "RigidBody" component

-  "Marker Scene" contains "AR Tracked Object" component, set "stay visible" in seconds (f.i. 0.05)

-  Tilt-Device-Physics requires Accelerometer C# Code Snippet
   - Script File and Class name must match

      
      

#### References

- Scripts in ARToolKit for Unity [https://artoolkit.org/documentation/doku.php?id=6_Unity:unity_scripts]
- Marker Patterns [https://github.com/artoolkit/artoolkit5/tree/master/doc/patterns]
- Unity Collisions [https://docs.unity3d.com/Manual/CollidersOverview.html]
- ARToolkit for Unity info [https://artoolkit.org/documentation/doku.php?id=6_Unity:unity_about]
