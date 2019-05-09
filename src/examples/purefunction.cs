static Cart AddToCart(Cart cart, string item, int quantity)
{
  Cart newCart = DeepClone(cart);
  
  newCart.Items.Add(
    new Item { Item = item, Quantity = quantity }
  );

  return newCart;
}