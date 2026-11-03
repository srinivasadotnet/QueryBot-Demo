using Microsoft.Playwright;
using QueryBot.Data;

namespace QueryBot.Pages;

public class LoginPage(IPage page)
{
    const string UsernameInput = "[data-test='username']";
    const string PasswordInput = "[data-test='password']";
    const string LoginButton = "[data-test='login-button']";

    public async Task OpenAsync() => await page.GotoAsync(TestData.BaseUrl);

    public async Task LoginAsync(string user, string password)
    {
        await page.FillAsync(UsernameInput, user);
        await page.FillAsync(PasswordInput, password);
        await page.ClickAsync(LoginButton);
    }
}
