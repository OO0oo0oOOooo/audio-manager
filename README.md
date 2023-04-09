# audio-manager
Basic audio manager

# Features
* Custom PlayRandomClipAtPosition() uses AudioMixer
* PlayOnParent() creates audiosource on a transform that loops until StopOnParent()

# Setup
* Drop prefab in scene
* Assign the scripts AudioSources from children
* Create Audio Clips scriptable objects
* Assign Scriptable objects to script
* Assign Mixer Group that you want PlayRandomClipAtPosition() and PlayOnParent() to use
* Place VolumeSettings scriptin the scene and assign the mixer and ui sliders
