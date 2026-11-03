# QueryBot-Demo

Spec-driven UI test demo: Playwright for .NET + NUnit + C#, targeting https://www.saucedemo.com.

## Layout
- `Video1/RULES.md` - framework rules
- `Video1/specs/` - test case specs
- `Video1/Pages/` - page objects (selectors live here)
- `Video1/Data/` - test data constants
- `Video1/Tests/` - NUnit tests

## Run
```bash
cd Video1
dotnet build
pwsh bin/Debug/net10.0/playwright.ps1 install chromium
dotnet test
```

## Videos
| Folder | Video |
|--------|-------|
| `Video1/` | [AI Writes the Test, Then Leaves \| Zero-Token Playwright C# Demo](https://www.youtube.com/watch?v=H6dvGWsFUjs) |
