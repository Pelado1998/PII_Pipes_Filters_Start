using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterInvento : IFilter
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
            for (int x = 0; x < invento.Width; x++)
            {
                for (int y = 0; y < invento.Height; y++)
                {
                    Color colorOriginal = invento.GetColor(x, y);

                    byte rOriginal = colorOriginal.R;
                    byte gOriginal = colorOriginal.G;
                    byte bOriginal = colorOriginal.B;

                    byte rNeg = Convert.ToByte(Math.Abs(rOriginal / 2));
                    byte gNeg = Convert.ToByte(Math.Abs(gOriginal / 10));
                    byte bNeg = Convert.ToByte(Math.Abs(bOriginal / 5));

                    var rand = new Random();


                    Color colorCualquiera;
                    colorCualquiera = Color.FromArgb(rNeg, gNeg, bNeg);
                    // colorCualquiera = Color.FromArgb(rNeg, gNeg, bNeg);

                    invento.SetColor(x, y, colorCualquiera);
                }
            }
            return invento;
        }
    }
}
