using Microsoft.Playwright;

namespace QueryBot.Pages;

public class InventoryPage(IPage page)
{
    const string InventoryList = "[data-test='inventory-list']";
    const string CartLink = "[data-test='shopping-cart-link']";

    public ILocator ProductList => page.Locator(InventoryList);

    // add-to-cart ids are the product name lowercased, spaces -> dashes
    public async Task AddToCartAsync(string productName) =>
        await page.ClickAsync($"[data-test='add-to-cart-{productName.ToLower().Replace(' ', '-')}']");

    public async Task OpenCartAsync() => await page.ClickAsync(CartLink);
}
