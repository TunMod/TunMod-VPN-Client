using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace TunMod_VPN_Client.BL
{
    public  class QrCodeReader
    {
        public static string Read_QrCode(string _QrPath)
        {
            IBarcodeReader reader = new BarcodeReader();
        
            var barcodeBitmap = (Bitmap)Image.FromFile(_QrPath);
          
            var result = reader.Decode(barcodeBitmap);
        
            if (result != null)
            {
                 return result.Text;
            }
            return null;
        }
    }
}
