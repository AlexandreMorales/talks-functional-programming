const addToCart = (cart, item, quantity) => {
    const newCart = deepClone(cart);
    
    newCart.items.push({
        item,
        quantity
    });

    return newCart;
};