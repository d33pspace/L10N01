using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using L10N01.Models;

namespace L10N01.Services
{
    public interface ICurrencyService
    {
        CultureInfo GetCurrent();
        List<Currency> GetAll();
        string GetSymbol(CultureInfo culture);
        string GetISOName(CultureInfo culture);
    }
}