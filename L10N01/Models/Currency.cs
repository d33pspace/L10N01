using System.ComponentModel.DataAnnotations;

namespace L10N01.Models
{
    public class Currency
    {
        public string Symbol { get; set; }
        public string CultureName { get; set; }
    }
}