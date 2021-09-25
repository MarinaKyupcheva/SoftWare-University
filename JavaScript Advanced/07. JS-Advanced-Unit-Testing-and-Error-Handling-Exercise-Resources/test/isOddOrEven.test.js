const isOddOrEven = require('../isOddOrEven');
const {assert} = require('chai');


describe('Test functionallity', () => {
it('Shoud return undefined when type is not a string', ()=> {

  assert.isUndefined(isOddOrEven(1));
});

it('Shoud return even when length is even number', () => {
    let expectedResult = 'even';
    assert.equal(isOddOrEven('aa'), expectedResult);
});

it('Shoud return odd when length is odd number', () => {
    let expectedResult = 'odd';
    assert.equal(isOddOrEven('a'), expectedResult);
});

it('Test with different strings', () => {
    let expectedResult = 'odd';
    assert.equal(isOddOrEven('a', 'bb', 'ccc'), expectedResult);
});
});