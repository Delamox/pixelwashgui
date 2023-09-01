# Pixelwashgui
Standalone GUI addon for [satyarth's pixelsorter](https://github.com/satyarth/pixelsort/).

## Installation:

#### (windows only)
1) Download and install: [python](https://www.python.org/ftp/python/3.11.4/python-3.11.4-amd64.exe) if you haven't already. Make sure to tick the 'add to PATH' option in the installer or it wont work.
2) TBA FFMPEG (video temp not working unless ffmpeg already installed)(sorry).
3) Install Satyarth's pixelsorter algorithm by pasting the following command in the command prompt (cmd.exe in windows): `pip install pixelsort`
3) Download the lastest [pixelwashgui.exe](https://github.com/Delamox/pixelwashgui/releases).

## Usage:
#### Images:
1) Open the downloaded pixelwashgui.exe file.
2) Drag and drop a [supported image](https://github.com/Delamox/pixelwashgui/blob/master/imageextensions.md) or select one manually by clicking the 'open file' button.
3) Adjust the sliders or type in values by clicking on the numbers next to the labels. Visit [satyarth's argumentation](https://github.com/satyarth/pixelsort/#parameters) for a more detailed explanation.
4) Click the 'pixelsort' button and wait until the generated image shows up.
5) Either click the 'save file' button to save the currently displayed image or return to step 3. Alternatively, you can put the output image back in to the input to apply multiple layers by pressing the 'new layer' button and returning to step 3.
#### Videos:
1) Open the downloaded pixelwashgui.exe file.
2) Drag and drop a [supported video](https://github.com/Delamox/pixelwashgui/blob/master/videoextensions.md) or select one manually by clicking the 'open file' button.
3) Adjust the sliders or type in values by clicking on the numbers next to the labels. Visit [satyarth's argumentation](https://github.com/satyarth/pixelsort/#parameters) for a more detailed explanation.
4) Select the desired test frame with the 'video frame' track.
5) Click the 'pixelsort' button and wait until the generated image shows up.
6) Keep returning to step 3 until you get the desired effect.
7) Click the 'videosort' button and wait until all frames are generated, a save window will automatically open once done.
##### WARNING: Layering will not work with videos (yet, maybe..), you will have to do this manually by uploading the output video.

## Masking and Thresholding
#### Apply a mask image to set what pixels you want changed:
1) Press the 'open mask' button, make sure the image is black-white only and has the same dimensions as the uploaded file.
2) Follow the usage steps.
#### Apply a threshold image to define intervals:
1) Press the 'open thres' button, make sure the image is black-white only and has the same dimensions as the uploaded file.
2) Select either the File or the File Edges function, File Edges will run an Edge-Detection on the image first.
3) Follor the usage steps.
##### WARNING: Black-white detection is not yet implemented and the program will hang if you upload a colored image. Might also not work with videos. Code will not return an error.
