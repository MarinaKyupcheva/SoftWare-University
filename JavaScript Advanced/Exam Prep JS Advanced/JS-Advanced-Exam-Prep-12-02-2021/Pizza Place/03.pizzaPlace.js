const {describe} = require('mocha');
const {assert} = require('chai');

let pizzUni = {
    makeAnOrder: function (obj) {

        if (!obj.orderedPizza) {
            throw new Error('You must order at least 1 Pizza to finish the order.');
        } else {
            let result = `You just ordered ${obj.orderedPizza}`
            if (obj.orderedDrink) {
                result += ` and ${obj.orderedDrink}.`
            }
            return result;
        }
    },

    getRemainingWork: function (statusArr) {

        const remainingArr = statusArr.filter(s => s.status != 'ready');

        if (remainingArr.length > 0) {

            let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ')
            let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`

            return pizzasLeft;
        } else {
            return 'All orders are complete!'
        }

    },

    orderType: function (totalSum, typeOfOrder) {
        if (typeOfOrder === 'Carry Out') {
            totalSum -= totalSum * 0.1;

            return totalSum;
        } else if (typeOfOrder === 'Delivery') {

            return totalSum;
        }
    }
}


describe("Tests …", function() {

        it("Make an order", function() {
            let order = {orderedPizza: 'pizza', orderedDrink: 'drink'};
            let secondOrder = {orderedPizza: 'pizza'};
            let thirdOrder = {orderedDrink: 'drink'};
            let fourthOrder = {};

            assert.throws(()=>pizzUni.makeAnOrder(thirdOrder), 'You must order at least 1 Pizza to finish the order.');
            assert.throws(()=>pizzUni.makeAnOrder(fourthOrder), 'You must order at least 1 Pizza to finish the order.');

            assert.equal(pizzUni.makeAnOrder(secondOrder), `You just ordered ${secondOrder.orderedPizza}`);
            assert.equal(pizzUni.makeAnOrder(order),`You just ordered ${order.orderedPizza} and ${ order.orderedDrink}.`);
        });
        
        it("getRemainingWork", function(){
            let firstOrder = [{pizzaName: 'pizza', status: 'ready'}, 
            {pizzaName: 'secondPizza', status: 'ready'},
             {pizzaName: 'thirdPizza', status: 'ready'}];

            let secondOrder = [{pizzaName: 'pizza', status: 'preparing'}, 
            {pizzaName: 'secondPizza', status: 'preparing'},
             {pizzaName: 'thirdPizza', status: 'preparing'}];

            let thirdOrder = [{pizzaName: 'pizza', status: 'ready'}, 
            {pizzaName: 'secondPizza', status: 'preparing'},
             {pizzaName: 'thirdPizza', status: 'preparing'}];

            assert.equal(pizzUni.getRemainingWork(secondOrder), `The following pizzas are still preparing: pizza, secondPizza, thirdPizza.`)
            assert.equal(pizzUni.getRemainingWork(thirdOrder), `The following pizzas are still preparing: secondPizza, thirdPizza.`)

            assert.equal(pizzUni.getRemainingWork(firstOrder), 'All orders are complete!')
        });

        it(" orderType", function(){
            let firstTypeOfOrder = 'Carry Out';
            let secondTypeOfOrder = 'Delivery';

            let totalSum = 100;
            let totalSumWithDiscount = 90;

           

            assert.equal(pizzUni.orderType(totalSum, firstTypeOfOrder), totalSumWithDiscount, 'Carry Out');
            assert.equal(pizzUni.orderType(totalSum, secondTypeOfOrder), totalSum, secondTypeOfOrder);
            ;
        });

    
});
