using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterBonus : IFilter
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
            for (int x = 1; x < invento.Width - 1; x += 3)
            {
                for (int y = 1; y < invento.Height - 1; y += 3)
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
                    colorCualquiera = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    // colorCualquiera = Color.FromArgb(rNeg, gNeg, bNeg);

                    invento.SetColor(x, y, colorCualquiera);
                }
            }
            return invento;
        }
    }
}

// rojo_nuevo[x, y] =
// (
//     (
//         r[x - 1, y - 1] * 1 + r[x, y - 1] * 1 + r[x + 1, y - 1] * 1 +
//         r[x - 1, y] * 1 + r[x, y] * 1 + r[x + 1, y] * 1 +
//         r[x - 1, y + 1] * 1 + r[x, y + 1] * 1 + r[x + 1, y + 1] * 1
// ) / 9) + 0