using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics; 
using TwitterUCU;

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
            Debug.Assert(image != null);
            IPicture invento = image.Clone();
            PictureProvider pic = new PictureProvider();
            pic.SavePicture(invento, $@"./../../images/bill{FilterSave.Instance.Count}.jpg");

            if (CognitiveApi(pic))
            {
                
                Console.WriteLine("ESTO ES UN FILTRO", $@"./../../images/bill{FilterSave.Instance.Count}.jpg");
                

            }
            else
            {
                pic.SavePicture(invento, $@"./../../images/bill{FilterSave.Instance.Count}.jpg");
                //Console.WriteLine(invento.PublishToTwitter("ESTO ES UN FILTRO", $@"./../../images/bill{FilterSave.Instance.Count}.jpg"));
            }
            return invento;
        }
    }
}
