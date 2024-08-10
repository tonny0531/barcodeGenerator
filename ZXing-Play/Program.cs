using System;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

const BarcodeFormat DEFAULT_BARCODE_FORMAT = BarcodeFormat.QR_CODE;
ImageFormat DEFAULT_IMAGE_FORMAT = ImageFormat.Png;
const String DEFAULT_OUTPUT_FILE = "out";
const int DEFAULT_WIDTH = 650;
const int DEFAULT_HEIGHT = 300;

BarcodeWriter br = new BarcodeWriter()
{
    Format =BarcodeFormat.CODE_39,
    Options = new EncodingOptions()
    {
        Width = DEFAULT_WIDTH,
        Height = DEFAULT_HEIGHT
    }
};

string content = "JeffTEst";

Bitmap img = br.Write(content);
img.Save("MyCode128.png");