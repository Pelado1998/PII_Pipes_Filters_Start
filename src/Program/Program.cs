using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;
using TwitterUCU;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture(@"./../../images/bill.jpg");

            var blur = new FilterBlurConvolution();
            var grey = new FilterGreyscale();
            var negative = new FilterNegative();
            var invento = new FilterInvento();
            var saving = FilterSave.Instance;
            var pipe1 = new PipeSerial(saving, new PipeNull());
            var pipe2 = new PipeSerial(grey, pipe1);
            var twitt = new PipeSerial(new FilterTwitter(), pipe2);
            var pipe3 = new PipeSerial(saving, twitt);
            var pipe4 = new PipeSerial(negative, pipe3);

            pipe4.Send(pic);


            // var fork = new PipeFork(prueba2, prueba1);
        }
    }
}
