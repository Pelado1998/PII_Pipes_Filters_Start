using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        private int count = 0;
        public int Count { get; set; }
        private static FilterSave instance;
        public static FilterSave Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FilterSave();
                }
                return instance;
            }
        }

        /// <summary>
        /// Recibe una imagen y la retorna con un filtro del tipo inventado aplicado
        /// </summary>
        /// <param name="image">Imagen a la cual se le va a plicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        public IPicture Filter(IPicture image)
        {

            Count++;
            Debug.Assert(image != null);
            IPicture saving = image.Clone();
            PictureProvider p = new PictureProvider();
            p.SavePicture(saving, $@"./../../images/bill{Count}.jpg");
            return saving;
        }
    }
}
