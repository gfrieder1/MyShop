﻿using MyShop.Core.ViewModels;
using System.Collections.Generic;
using System.Web;

namespace MyShop.Core.Contracts
{
    public interface IBasketService
    {
        void AddToBasket(HttpContextBase httpContext, string productID);
        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
        void RemoveFromBasket(HttpContextBase httpContext, string itemID);
        void ClearBasket(HttpContextBase httpContext);
    }
}