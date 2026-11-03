using NUnit.Framework;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using QueryBot.Data;
using QueryBot.Pages;

namespace QueryBot.Tests;

[TestFixture]
public class TC001_CheckoutOneItem : PageTest
{
    [Test]
    public async Task CheckoutOneItem()
    {
        var login = new LoginPage(Page);
        var inventory = new InventoryPage(Page);
        var cart = new CartPage(Page);
        var checkout = new CheckoutPage(Page);

        await login.OpenAsync();
        await login.LoginAsync(TestData.Username, TestData.Password);
        await Expect(inventory.ProductList).ToBeVisibleAsync();

        await inventory.AddToCartAsync(TestData.ProductName);
        await inventory.OpenCartAsync();
        await Expect(cart.ItemNames).ToHaveTextAsync(new[] { TestData.ProductName });

        await cart.StartCheckoutAsync();
        await checkout.EnterDetailsAsync(TestData.FirstName, TestData.LastName, TestData.PostalCode);
        await checkout.ContinueAsync();
        await checkout.FinishAsync();
        await Expect(checkout.ConfirmationMessage).ToHaveTextAsync(TestData.ConfirmationMessage);
    }
}
