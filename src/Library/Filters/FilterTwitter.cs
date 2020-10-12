using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        private string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro del tipo inventado aplicado
        /// </summary>
        /// <param name="image">Imagen a la cual se le va a plicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("ESTO ES UN FILTRO", $@"./../../images/bill{FilterSave.Instance.Count}.jpg"));
            return image;
        }
    }
}
