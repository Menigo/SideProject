const Tesseract = require('tesseract.js');


const OcrRead = ({img,lan})=>{
  const ans = Tesseract.recognize(img,lan);
  return ans;
}

const fs = require('fs');
const path = require('path');

const base64ToPNG = ({data}) => {
  data = data.replace(/^data:image\/png;base64,/, '');
  fs.writeFile(path.resolve(__dirname, '../tmp/tokenImg.png'), data, 'base64');
  return 0;
}




module.exports = {
  OcrRead,
  base64ToPNG
}


// Tesseract.recognize(
//   'https://tesseract.projectnaptha.com/img/eng_bw.png',
//   'eng',
//   { logger: m => console.log(m) }
// ).then(({ data: { text } }) => {
//   console.log(text);
// })