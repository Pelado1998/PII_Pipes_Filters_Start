using System;
using System.Diagnostics;
using CognitiveCoreUCU;
using System.Drawing;


namespace CompAndDel.Filters
{
    public class FilterConditional : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro del tipo inventado aplicado
        /// </summary>
        /// <param name="image">Imagen a la cual se le va a plicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        public IPicture Filter(IPicture image)
        {
            var newImage = image.Clone();
            var recognition = Cognitive.FaceRecognition($@"./../../images/bill{FilterSave.Instance.Count}.jpg");
            if (recognition)
            {
                var grey = new FilterGreyscale();
                newImage = grey.Filter(newImage);
            }
            else
            {
                var blur = new FilterBlurConvolution();
                newImage = blur.Filter(newImage);
            }
            return newImage;
        }
    }
}
