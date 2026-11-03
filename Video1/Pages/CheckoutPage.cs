using Microsoft.Playwright;

namespace QueryBot.Pages;

public class CheckoutPage(IPage page)
{
    const string FirstNameInput = "[data-test='firstName']";
    const string LastNameInput = "[data-test='lastName']";
    const string PostalCodeInput = "[data-test='postalCode']";
    const string ContinueButton = "[data-test='continue']";
    const string FinishButton = "[data-test='finish']";
    const string CompleteHeader = "[data-test='complete-header']";

    public ILocator ConfirmationMessage => page.Locator(CompleteHeader);

    public async Task EnterDetailsAsync(string first, string last, string postal)
    {
        await page.FillAsync(FirstNameInput, first);
        await page.FillAsync(LastNameInput, last);
        await page.FillAsync(PostalCodeInput, postal);
    }

    public async Task ContinueAsync() => await page.ClickAsync(ContinueButton);
    public async Task FinishAsync() => await page.ClickAsync(FinishButton);
}
