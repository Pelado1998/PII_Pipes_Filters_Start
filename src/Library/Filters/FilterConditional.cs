// using System;
// using System.Collections.Generic;
// using System.Text;
// using CompAndDel;
// using System.Drawing;
// using System.Diagnostics;

// namespace CompAndDel.Filters
// {
//     public class FilterConditional : IFilter
//     {
//         /// <summary>
//         /// Recibe una imagen y la retorna con un filtro del tipo inventado aplicado
//         /// </summary>
//         /// <param name="image">Imagen a la cual se le va a plicar el filtro.</param>
//         /// <returns>Imagen con el filtro aplicado</returns>
//         public IPicture Filter(IPicture image)
//         {
//             Debug.Assert(image != null);
//             IPicture invento = image.Clone();

//             if (CognitiveApi(image))
//             {
//                 //FILTRO 1
//             }
//             else
//             {
//                 // FILTRO 2
//             }
//             return invento;
//         }
//     }
// }
