const fs = require('fs')
const PNG = require('pngjs').PNG
//const path = require('path');

// open image
const dealwithPNG = ({path}) => {

    const captcha = fs.readFileSync(path)
    const imgData = PNG.sync.read(captcha)
    const threshold = 185;
    //let { data, height, width } = pngImage

    for (var i = 0; i < imgData.data.length; i += 4) {

        var R = imgData.data[i]; //R(0-255)

        var G = imgData.data[i + 1]; //G(0-255)

        var B = imgData.data[i + 2]; //G(0-255)

        var Alpha = imgData.data[i + 3]; //Alpha(0-255)

        var sum = (R + G + B) / 3;

        if (sum > threshold) {

            imgData.data[i] = 255;

            imgData.data[i + 1] = 255;

            imgData.data[i + 2] = 255;

            imgData.data[i + 3] = Alpha;

        }

        else {

            imgData.data[i] = 0;

            imgData.data[i + 1] = 0;

            imgData.data[i + 2] = 0;

            imgData.data[i + 3] = Alpha;

        }

    }
    

    // save new image
    const imageBuffer = PNG.sync.write(imgData)
    fs.writeFileSync(`${path.replace('.png', '')}.png`, imageBuffer)
    return 0;
}


module.exports = {
    dealwithPNG
}
