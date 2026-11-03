# Framework rules
1. Playwright for .NET, NUnit, C#.
2. One page class per page under /Pages; tests never use raw selectors.
3. Selectors live as constants in the page class. Prefer data-test attributes, then role, then text. No XPath unless nothing else works.
4. Test data (user, names, zip) in /Data constants, not inline.
5. Every Expected result in the spec = one assertion. No extra assertions, no skipped ones.
6. No sleeps. Use Playwright auto-wait.
7. If a step is ambiguous or the app differs from the spec, STOP and ask. Do not guess.
8. Do not modify files outside /Pages, /Tests, /Data.
