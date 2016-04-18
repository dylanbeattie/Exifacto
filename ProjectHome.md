Exifacto is designed to offer an intuitive API for reading EXIF data from JPEG and TIFF images. EXIF documentation and notes are included in the API's Intellisense comments so you can explore the API whilst you're coding and see what fields are available and what they do.


```

var exifData = new Exifacto.ExifData("C:\myfile.jpg");
Console.WriteLine("Photo taken at: " + exifData .DateTimeOriginal.ToString());

Console.WriteLine("Taken with a " + exifData .CameraModel);

// Do we need to rotate this photo to display it properly?
int rotationRequired;
switch(exifData.Orientation) {
    case CameraOrientation.Normal:
        rotationRequired = 0;
        break;
    case CameraOrientation.LeftSideOfCameraTowardsSky:
        rotation = -90;
        break;
    case CameraOrientation.LeftSideOfCameraTowardsGround:
        rotationRequired = 90;
        break;
    case CameraOrientation.UpsideDown:
         rotationRequired = 180;
         break;
}

```

![http://www.dylanbeattie.net/misc/exifacto.png](http://www.dylanbeattie.net/misc/exifacto.png)