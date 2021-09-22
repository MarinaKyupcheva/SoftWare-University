const {describe} = require('mocha');
const {assert} = require('chai');

const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        } else {
             sum = (num1 + num2).toFixed(2);
             return sum
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i]
        }

        return arraySum / arr.length
    }
};


describe("testNumbers", function() {
    describe("sumNumbers", function() {
       it("Shoud return number", function() {
           assert.equal(testNumbers.sumNumbers(5, 5), 10.00);
           assert.equal(testNumbers.sumNumbers(1.5, 1.5), 3.00);
           assert.equal(testNumbers.sumNumbers(-5, 5), 0.00);
           assert.equal(testNumbers.sumNumbers(-5, -5), -10.00);
           assert.equal(testNumbers.sumNumbers(-5.5, 5), -0.50);
           assert.equal(testNumbers.sumNumbers(0, 0), 0.00);
        }); 

        it("Shoudn't be a number", function() {
            //assert.isNaN(testNumbers.sumNumbers(Nan), undefined);
            assert.equal(testNumbers.sumNumbers('abc', 'abc'), undefined);
            assert.equal(testNumbers.sumNumbers('123b', 5), undefined);
            assert.equal(testNumbers.sumNumbers(1, 'abc'), undefined);
            assert.equal(testNumbers.sumNumbers(undefined, 5), undefined);
           
         }); 
         describe(" numberChecker", function() {
            it("Should throw an Error when the number is NaN", function() {

                assert.throw(() => testNumbers.numberChecker(), Error, 'The input is not a number!');
                
             }); 
             it("Should return even number", function() {

                assert.equal(testNumbers.numberChecker(4), 'The number is even!');
                assert.equal(testNumbers.numberChecker(-2), 'The number is even!');
                assert.equal(testNumbers.numberChecker(0), 'The number is even!');
                assert.equal(testNumbers.numberChecker(-104), 'The number is even!');
                assert.equal(testNumbers.numberChecker(104), 'The number is even!');
                //assert.equal(testNumbers.numberChecker(104.4), 'The number is even!');
                //assert.equal(testNumbers.numberChecker(-104.4), 'The number is even!');
             }); 

             it("Should return odd number", function() {

               assert.equal(testNumbers.numberChecker(5), 'The number is odd!');
               assert.equal(testNumbers.numberChecker(-5), 'The number is odd!');
               
               assert.equal(testNumbers.numberChecker(-125), 'The number is odd!');
               assert.equal(testNumbers.numberChecker(125), 'The number is odd!');
                
             }); 
            });

            describe("averageSumArray", function() {
                it("Should sum correct array", function() {
                    assert.deepEqual(testNumbers.averageSumArray([5, 5]), 10 / 2);
                    assert.deepEqual(testNumbers.averageSumArray([-5, -5, -5]), -15 / 3);
                    assert.deepEqual(testNumbers.averageSumArray([0, 0]), 0 / 2);
                    assert.deepEqual(testNumbers.averageSumArray([100, 100, 100]), 300 / 3);
                    assert.deepEqual(testNumbers.averageSumArray([1.5, 1.5, 1.5]), 4.5 / 3);
                    assert.deepEqual(testNumbers.averageSumArray([-1.5, -1.5, -1.5]), -4.5 / 3);
                 }); 

}); 
        });
});
