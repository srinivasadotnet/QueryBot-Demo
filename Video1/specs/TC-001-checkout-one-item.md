# TC-001 Checkout one item

## Metadata
- App: https://www.saucedemo.com
- Priority: High
- Type: Happy path

## Preconditions
- Browser closed, no saved session
- User: standard_user / secret_sauce (public demo account)

## Steps
1. Open the app.
2. Log in with the user above.
3. Add "Sauce Labs Backpack" to the cart.
4. Open the cart.
5. Start checkout.
6. Enter first name "Test", last name "User", postal code "12345".
7. Continue, then Finish.

## Expected results
- After step 2: product list page is shown.
- After step 4: cart contains exactly one item, "Sauce Labs Backpack".
- After step 7: confirmation message "Thank you for your order!" is shown.

## Out of scope
- Payment (demo app has none), other users, sorting.
