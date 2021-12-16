Feature: Shopping Cart feature

Scenario: Search for a product on a shopping website and add the product to cart
	Given there is availability on <ShoppingWebsite> for <Product>
	When the <Category> is added to the shopping cart
	Then the product is successfully added and price remains the same

Examples:
| ShoppingWebsite | Product             | Category |
| Nykaa           | Nykaa Matte To Last | Mastani  |
