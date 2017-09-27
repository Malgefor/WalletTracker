using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WalletTracker.ViewModels
{
    public class WalletInfoViewModel
    {
        public string WalletAddress { get; set; }

        public string CurrencyType { get; set; }

        public static IEnumerable<SelectListItem> CurrencyTypes
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem
                    {
                        Value = "Please select a currency",
                        Text = "Please select a currency",
                        Selected = true,
                        Disabled = true
                    }
                }.Concat(Domain.Currency.CurrencyType
                    .All()
                    .Where(c => c.BaseCurrencyType == null)
                    .Select(
                        c => new SelectListItem
                        {
                            Value = c.Symbol,
                            Text = c.Name
                        })).ToList();
            }
        }
    }
}
