function solve() {
   let addProductButtonElements = Array.from(document.getElementsByClassName('add-product'));
   let checkoutButtonElement = document.getElementsByClassName('checkout')[0];
   let textAreaElement = document.querySelector('textarea');
   let totalMoney = 0;
   let productNames = [];

   addProductButtonElements.forEach(x => {
      x.addEventListener('click', (e) => {
         let currentProduct = e.target.parentNode.parentNode;
         let productName = currentProduct.children[1].getElementsByClassName('product-title')[0].textContent;
         if (productNames.includes(productName) == false) {
            productNames.push(productName);
         }
         let productPrice = Number(currentProduct.children[3].textContent);

         totalMoney += productPrice;

         textAreaElement.textContent += `Added ${productName} for ${productPrice.toFixed(2)} to the cart.\n`
      })
   });

   checkoutButtonElement.addEventListener('click', (e) => {
      addProductButtonElements.forEach(x => x.disabled = true);
      e.target.disabled = true;
      textAreaElement.textContent += `You bought ${productNames.join(', ')} for ${totalMoney.toFixed(2)}.`;
   });
}