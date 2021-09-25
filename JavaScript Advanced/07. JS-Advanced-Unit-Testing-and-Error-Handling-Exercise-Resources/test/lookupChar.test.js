const lookupChar = require('../lookupChar');
const {assert} = require('chai');

describe('lookupCharr', () => {
    it('Should return undefine when type is not string and index is not number', () => {
        assert.isUndefined(lookupChar('abs', 0.2));
        assert.isUndefined(lookupChar('ab', 'a'));
        assert.isUndefined(lookupChar(1, 1));
    });

    it('Should return Incorrect index', () => {
        assert.equal(lookupChar('abc', 4), 'Incorrect index');
        assert.equal(lookupChar('abc', -1), 'Incorrect index');
    });

    it('Should work correct', () => {
        assert.equal(lookupChar('abc', 1), "b");
        
    });
});