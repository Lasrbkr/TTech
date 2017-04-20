using System;
using TTech.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(JavaScriptStringEncoder_IOS))]
namespace TTech.iOS
{
    public class JavaScriptStringEncoder_IOS : IJavaScriptStringEncoder
    {
        public string EncodeString(string value)
        {
            return System.Web.HttpUtility.JavaScriptStringEncode(value);
        }
    }
}