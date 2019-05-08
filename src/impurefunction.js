const addToCart = (cart, item, quantity) => {
    cart.items.push({
        item,
        quantity
    });

    return cart;
};