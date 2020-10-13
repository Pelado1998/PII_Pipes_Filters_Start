using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel
{
    public class Cognitive
    {
        public static bool FaceRecognition(string image)
        {
            CognitiveFace recognition = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", false);
            recognition.Recognize(image);
            return recognition.FaceFound;
        }
    }
}
