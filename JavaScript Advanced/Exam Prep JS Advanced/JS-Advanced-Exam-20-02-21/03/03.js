const {describe} = require('mocha');
const {assert} = require('chai');

const numberOperations = {
    powNumber: function (num) {
        return num * num;
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input < 100) {
            return 'The number is lower than 100!';
        } else {
            return 'The number is greater or equal to 100!';
        }
    },
    sumArrays: function (array1, array2) {

        const longerArr = array1.length > array2.length ? array1 : array2;
        const rounds = array1.length < array2.length ? array1.length : array2.length;

        const resultArr = [];

        for (let i = 0; i < rounds; i++) {
            resultArr.push(array1[i] + array2[i]);
        }

        resultArr.push(...longerArr.slice(rounds));

        return resultArr
    }
};

describe("numberOperations", function() {
   
     describe("powNumber", function() {
        it("Shoud return correct result", function() {

            assert.equal(numberOperations.powNumber(3),9);
            assert.equal(numberOperations.powNumber(1.5), 1.5 * 1.5);
            assert.equal(numberOperations.powNumber(0), 0);
            assert.equal(numberOperations.powNumber(-2), 4);
            assert.isNaN(numberOperations.powNumber(NaN));
        });
     });

     describe("numberChecker", function() {
        it("Shoud return an Error because the input i not a number", function() {
           
            assert.throw(() => numberOperations.numberChecker('abc'), Error, 'The input is not a number!');
            assert.throw(() => numberOperations.numberChecker('123b'), Error, 'The input is not a number!');
            assert.throw(() => numberOperations.numberChecker(undefined), Error, 'The input is not a number!');
           
        });
     });

     describe("sumArrays", function() {
        it("Shoud check is the number bigger than 100", function() {
           
           assert.equal(numberOperations.numberChecker(105), 'The number is greater or equal to 100!');
           assert.equal(numberOperations.numberChecker(120.5), 'The number is greater or equal to 100!');
           assert.strictEqual(numberOperations.numberChecker(100), 'The number is greater or equal to 100!');

           
        });
     });

     describe("numberChecker", function() {
        it("Shoud check is the number lower than 100", function() {
           
           assert.equal(numberOperations.numberChecker(5), 'The number is lower than 100!');
           assert.equal(numberOperations.numberChecker(2.5), 'The number is lower than 100!');
           assert.equal(numberOperations.numberChecker(-10), 'The number is lower than 100!')
           assert.equal(numberOperations.numberChecker(''), 'The number is lower than 100!')
           assert.strictEqual(numberOperations.numberChecker('3'), 'The number is lower than 100!');
           
        });
     });

     describe("sumArrays", function() {
        it("Shoud sum correct the numbers in the arrays", function() {
           
           assert.deepEqual(numberOperations.sumArrays([1, 2, 3], [1, 2, 3]), [2, 4, 6]);
           assert.deepEqual(numberOperations.sumArrays([1.5, 2, 3], [1.5, 2, 3]), [3, 4, 6]);
           assert.deepEqual(numberOperations.sumArrays([-1, 2, 3], [1, 2, 3]), [0, 4, 6]);
           assert.deepEqual(numberOperations.sumArrays([2, 3], [1, 2, 3]), [3, 5, 3]);
           assert.deepEqual(numberOperations.sumArrays([], [1, 2, 3]), [1, 2, 3]);
           assert.deepEqual(numberOperations.sumArrays([1, 2, 3], []), [1, 2, 3]);
           assert.deepEqual(numberOperations.sumArrays(['a', 'b', 'c'], ['a', 'b', 'c']), ['aa', 'bb', 'cc']);
           assert.deepEqual(numberOperations.sumArrays([], []), []);
           assert.deepEqual(numberOperations.sumArrays([-1, 2, 7], [-2, 3]), [-3, 5, 7]);
        });
     });
     
});


