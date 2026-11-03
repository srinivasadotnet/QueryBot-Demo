using Microsoft.Playwright;

namespace QueryBot.Pages;

public class CartPage(IPage page)
{
    const string ItemName = "[data-test='inventory-item-name']";
    const string CheckoutButton = "[data-test='checkout']";

    public ILocator ItemNames => page.Locator(ItemName);

    public async Task StartCheckoutAsync() => await page.ClickAsync(CheckoutButton);
}
