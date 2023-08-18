# Basic audio manager

# Features
* Custom PlayRandomClipAtPosition() uses AudioMixer
* PlayOnParent() creates audiosource on a transform that loops until StopOnParent()

# Setup
* Drop prefab in scene
* Assign the AudioSources from children
* Create Audio Clips scriptable object
* Assign Scriptable objects
* Assign Mixer Group that you want PlayRandomClipAtPosition() and PlayOnParent() to use
* Place VolumeSettings script in the scene and assign the mixer and ui sliders

# Useage
Call methods from Singleton "AudioSystem.Instance".

When adding Audio Clips to the Audio Clip Scriptable Objects the first list should be different sounds(grass step, rock step, attack), the second list should be varuations of that sound (grass step 01 - grass step 09). To use a random variation use "PlayRandomClipAtPoint(int array, vector3 pos, float volume)". You can also use "PlayClipAtPoint(int array, int index, vector3 pos, float volume)" to pick a specific variation manually.

# Oneshot
* PlayMusicClip
* PlayMenuClip
* PlayGameClip

# GameClip AudioSource Methods
* PlayClipAtPoint()
* PlayRandomClipAtPoint()
* PlayOnParent()
* StopOnParent()
